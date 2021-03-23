using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Helper
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            Initialisation();
            ResetModule();
        }

        #region Globals
        //constants
        struct MazeID
        {
            internal int x1,y1,x2,y2;
            public MazeID(int p1, int p2, int p3, int p4)
            {
                x1 = p1;
                y1 = p2;
                x2 = p3;
                y2 = p4;
            }
        }

        const int NO_DATA = -1;
        Point NO_POINT = new Point(-1, -1);

        const bool WALL = true;
        const bool PATH = false;

        const int MAZE_SIZE = 6;
        const int NUM_MAZES = 9;
        const int NUM_MAZE_ELEMENTS = 13;
        const int NUM_ID_POINTS = 2;

        const int MAZE_BORDER_SIZE = 13;//9;//12;
        const int PIC_POINT_SPACING = 23;//15;//13; //15
        Size PIC_POINT_SIZE = new Size(78, 78); //86


        Image[] MAZE_IMAGES = { Properties.Resources.Blank_Maze, 
                                Properties.Resources.Maze_1, 
                                Properties.Resources.Maze_2, 
                                Properties.Resources.Maze_3, 
                                Properties.Resources.Maze_4, 
                                Properties.Resources.Maze_5, 
                                Properties.Resources.Maze_6, 
                                Properties.Resources.Maze_7, 
                                Properties.Resources.Maze_8, 
                                Properties.Resources.Maze_9};
        Image MAZE_POINT = Properties.Resources.Point;
        Image MAZE_CIRCLE = Properties.Resources.Circle_Point;
        Image MAZE_START = Properties.Resources.Start_Position;
        Image MAZE_END = Properties.Resources.End_Position;
        Image MAZE_RIGHT = Properties.Resources.Right;
        Image MAZE_UP = Properties.Resources.Up;
        Image MAZE_LEFT = Properties.Resources.Left;
        Image MAZE_DOWN = Properties.Resources.Down;

        MazeID[] MAZE_IDENTIFIERS = new MazeID[NUM_MAZES]{  new MazeID(0,1,5,2), 
                                                            new MazeID(1,3,4,1), 
                                                            new MazeID(3,3,5,3),
                                                            new MazeID(0,0,0,3), 
                                                            new MazeID(4,2,3,5), 
                                                            new MazeID(4,0,2,4), 
                                                            new MazeID(1,0,1,5), 
                                                            new MazeID(3,0,2,3), 
                                                            new MazeID(0,4,2,1)};
        bool [, ,] MAZE_DATA;
        Point[] DIRECTIONS = new Point[4] { new Point(1, 0), new Point(0, -1), new Point(-1, 0), new Point(0, 1) }; //right, up, left, down

        PictureBox[,] mazePoints = new PictureBox[MAZE_SIZE, MAZE_SIZE];

        //int[,] selectionData = new int[MAZE_SIZE, MAZE_SIZE];
        //variables
        int pointsSelected = 0;
        Point[] selectedPointData = new Point[2];
        int selectedMaze = NO_DATA;
        bool step1Complete = false;

        Point startPoint;
        Point endPoint;
        #endregion

        #region Initialisation
        private void Initialisation()
        {
            //picMaze.Image = MAZE_IMAGES[0];
            picMaze.BackColor = Color.White;
            //create picture boxes that are clickable and represent each point on the maze
            for (int x = 0; x < MAZE_SIZE; x++)
            {
                for (int y = 0; y < MAZE_SIZE; y++)
                {
                    mazePoints[x, y] = new PictureBox();
                    mazePoints[x, y].MouseDown += MazePointClick;
                    mazePoints[x, y].Size = PIC_POINT_SIZE;
                    mazePoints[x, y].Location = new Point(MAZE_BORDER_SIZE + picMaze.Location.X + (PIC_POINT_SPACING + PIC_POINT_SIZE.Width) * x - 1, MAZE_BORDER_SIZE + picMaze.Location.Y + (PIC_POINT_SPACING + PIC_POINT_SIZE.Height) * y - 1);
                    mazePoints[x, y].Image = MAZE_POINT;
                    //mazePoints[x, y].BackColor = Color.Red;
                    mazePoints[x, y].Tag = new Point(x, y); //its position in the array
                    mazePoints[x, y].SizeMode = PictureBoxSizeMode.CenterImage;

                    groupInput.Controls.Add(mazePoints[x, y]);
                }
            }
            picMaze.SendToBack();

            MAZE_DATA = new bool[NUM_MAZES, NUM_MAZE_ELEMENTS, NUM_MAZE_ELEMENTS];

            //populate maze with data
            int dataLength = Properties.Resources.Maze_Data.Length;
            int currentMaze = -1;
            int row = 0;
            int col = 0;

            for (int i = 0; i < dataLength; i++)
            {
                char elem = Properties.Resources.Maze_Data[i];
                if (elem == 'M')
                {
                    //then we have encountered a new maze, add 1 to the maze counter and skip to the new line.
                    currentMaze++;
                    while (Properties.Resources.Maze_Data[i] != '\n')
                    {
                        i++;
                    }
                    col = 0;
                    row = 0;
                }
                else if (elem == '\r' || elem == '\n')
                {
                    //i++;
                }
                else //these are valid maze elements
                {
                    if (elem == 'X')
                    {
                        MAZE_DATA[currentMaze, col, row] = WALL;
                    }
                    else if (elem == ' ')
                    {
                        MAZE_DATA[currentMaze, col, row] = PATH;
                    }
                    col++;
                    if (col == NUM_MAZE_ELEMENTS)
                    {
                        col = 0;
                        row++;
                    }
                }
            }
        }
        #endregion

        #region Input
        private void MazePointClick(object sender, EventArgs e)
        {
            PictureBox input = (PictureBox)sender;
            if (!step1Complete)
            {
                //MessageBox.Show(input.Tag.ToString());
                if (input.Image == MAZE_POINT)
                {
                    if (pointsSelected < 2)
                    {
                        //input.Image = MAZE_CIRCLE;
                        selectedPointData[pointsSelected] = (Point)input.Tag;
                        pointsSelected++;
                    }
                }
                else
                {
                    //input.Image = MAZE_POINT;
                    pointsSelected--;

                    if ((Point)input.Tag == selectedPointData[0])
                    {
                        selectedPointData[0] = selectedPointData[1];
                    }
                }

                MazeEvaluation();
                Step1Evaluation();
            }
            else
            {
                MouseEventArgs mouseClick = (MouseEventArgs)e;
                if (mouseClick.Button == MouseButtons.Left && (Point)input.Tag != endPoint) //left = start
                {
                    startPoint = (Point)input.Tag;
                }
                else if (mouseClick.Button == MouseButtons.Right && (Point)input.Tag != startPoint) //right = end 
                {
                    endPoint = (Point)input.Tag;
                }

                Step2Evaluation();
            }

            UpdateDisplay();
        }

        //private void 
        #endregion

        #region Evaluation
        private void MazeEvaluation() //determines the currently selected maze after valid points given
        {
            selectedMaze = NO_DATA;
            if (pointsSelected == NUM_ID_POINTS) {
                //check if the current points selected match the points required for a maze.
                for (int i = 0; i < NUM_MAZES; i++)
                {
                    if (((selectedPointData[0].X == MAZE_IDENTIFIERS[i].x1 && selectedPointData[0].Y == MAZE_IDENTIFIERS[i].y1) ||
                        (selectedPointData[0].X == MAZE_IDENTIFIERS[i].x2 && selectedPointData[0].Y == MAZE_IDENTIFIERS[i].y2)) &&
                        ((selectedPointData[1].X == MAZE_IDENTIFIERS[i].x1 && selectedPointData[1].Y == MAZE_IDENTIFIERS[i].y1) ||
                        (selectedPointData[1].X == MAZE_IDENTIFIERS[i].x2 && selectedPointData[1].Y == MAZE_IDENTIFIERS[i].y2)))
                    {
                        selectedMaze = i;
                        break;
                    }
                }
            }
        }

        private void Step1Evaluation() //determines user feedback based on given points (step 1)
        {
            lblStep1Selected.Text = "Points Selected: " + pointsSelected + "/2";
            if (selectedMaze != NO_DATA)
            {
                btnStep1Confirm.Enabled = true;
                lblStep1Valid.Text = "* This is maze number " + (selectedMaze+1);
            }
            else
            {
                btnStep1Confirm.Enabled = false;
                lblStep1Valid.Text = "* This is not a valid maze";
            }
        }

        private void Step2Evaluation() //determines user feedback based on start and end points (step 2)
        {
            btnStep2Confirm.Enabled = false;
            lblStep2Selected.Text = "Selected: ";
            if (startPoint != NO_POINT) 
            {
                if (endPoint != NO_POINT) //both have been selected
                {
                    lblStep2Selected.Text += "Start, End";
                    lblStep2Valid.Text = "* Click confirm to start\n   pathfinding";
                    btnStep2Confirm.Enabled = true;
                }
                else //only start has been selected
                {
                    lblStep2Selected.Text += "Start";
                    lblStep2Valid.Text = "* You need to place an\n   end marker";
                }
            }
            else if (endPoint != NO_POINT)//only end selected
            {
                lblStep2Selected.Text += "End";
                lblStep2Valid.Text = "* You need to place a\n   start marker";
            }
            else //nothing selected
            {
                lblStep2Selected.Text += "No Points";
                lblStep2Valid.Text = "* You need to place a\n   start and end marker";
            }

            if (step1Complete)
            {
                groupStep2.Visible = true;
            }
            else
            {
                groupStep2.Visible = false;
            }
        }

        private void UpdateDisplay()
        {
            for (int x = 0; x < MAZE_SIZE; x++)
            {
                for (int y = 0; y < MAZE_SIZE; y++)
                {
                    mazePoints[x, y].Image = MAZE_POINT;
                }
            }

            for (int i = 0; i < pointsSelected; i++)
            {
                mazePoints[selectedPointData[i].X, selectedPointData[i].Y].Image = MAZE_CIRCLE;
            }

            if (startPoint != NO_POINT)
            {
                mazePoints[startPoint.X, startPoint.Y].Image = MAZE_START;
            }

            if (endPoint != NO_POINT)
            {
                mazePoints[endPoint.X, endPoint.Y].Image = MAZE_END;
            }

        }
        #endregion

        #region Reset
        private void ResetModule()
        {
            //insert reset stuff here
            picMaze.Image = MAZE_IMAGES[0];
            pointsSelected = 0;
            step1Complete = false;
            selectedMaze = NO_DATA;

            startPoint = NO_POINT;
            endPoint = NO_POINT;

            MazeEvaluation();
            Step1Evaluation();
            Step2Evaluation();
            UpdateDisplay();
            MazeSelectionPointsVisibility(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }
        #endregion

        private void btnStep1Confirm_Click(object sender, EventArgs e)
        {
            picMaze.Image = MAZE_IMAGES[selectedMaze + 1];
            btnStep1Confirm.Enabled = false;
            step1Complete = true;
            pointsSelected = 0;
            Step2Evaluation();
            UpdateDisplay();
        }

        private void btnStep2Confirm_Click(object sender, EventArgs e)
        {
            //perform pathfinding
            Pathfinding();
        }

        private void Pathfinding()
        {
            //create temporary maze that can be used for pathfinding
            bool[,] mazeData = new bool[NUM_MAZE_ELEMENTS,NUM_MAZE_ELEMENTS];
            //string maze = "";
            for (int y = 0; y < NUM_MAZE_ELEMENTS; y++)
            {
                for (int x = 0; x < NUM_MAZE_ELEMENTS; x++)
                {
                    mazeData[x, y] = MAZE_DATA[selectedMaze, x, y];
                    /*
                    if (mazeData[x, y] == WALL)
                    {
                        maze += "X";
                    }
                    else
                    {
                        maze += " ";
                    }
                    */
                }
                //maze += "\n";
            }
            //MessageBox.Show(maze);


            
            //find all dead ends and remove them from the maze
            //scan each point in the maze which is not a wall, if this point is a dead end 
            //(3 walls around it) and it is not the start or end point then change it into a wall
            //check for surrounding points which are also dead ends, if a dead end is found then
            //continue using that point. once a point which is not a dead end is reached then the
            //scan starts from the beginning.
            //scan stops when the last element is reached and no dead end is encountered
            for (int x = 1; x < NUM_MAZE_ELEMENTS-1; x++)
            {
                for (int y = 1; y < NUM_MAZE_ELEMENTS-1; y++)
                {
                    if (mazeData[x,y] == PATH && CheckDeadEnd(new Point(x, y), mazeData)) //if it is a dead end
                    {
                        mazeData[x, y] = WALL;
                        //now find another point which is also a dead end
                        int xx = x;
                        int yy = y;
                        while (xx != NO_DATA && yy != NO_DATA)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                Point currPoint = new Point(xx + DIRECTIONS[i].X, yy + DIRECTIONS[i].Y);
                                if (mazeData[currPoint.X, currPoint.Y] == PATH && CheckDeadEnd(currPoint, mazeData))
                                {
                                    //found new dead end point, continue from that point
                                    mazeData[currPoint.X, currPoint.Y] = WALL;
                                    xx = xx + DIRECTIONS[i].X;// -1;
                                    yy = yy + DIRECTIONS[i].Y;// -1;

                                    //there can only be one, so break loop
                                    break;
                                }
                                else if (i == 3)
                                {
                                    //there are no dead ends (occurs at intersections)
                                    xx = NO_DATA;
                                    yy = NO_DATA;
                                    //restart scan
                                    x = 1;
                                    y = 1;
                                }
                            }
                        }
                    }
                }
            }

            //scan finished, start 'pathfinding'
            Point currentPoint = new Point(startPoint.X * 2 + 1, startPoint.Y * 2 + 1);
            Point end = new Point(endPoint.X * 2 + 1, endPoint.Y * 2 + 1);
            while (currentPoint != end)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (mazeData[currentPoint.X + DIRECTIONS[i].X, currentPoint.Y + DIRECTIONS[i].Y] == PATH)
                    {
                        //set the arrow pointer
                        switch (i)
                        {
                            case 0: mazePoints[(currentPoint.X - 1) / 2, (currentPoint.Y - 1) / 2].Image = MAZE_RIGHT;//right
                                break;
                            case 1: mazePoints[(currentPoint.X - 1) / 2, (currentPoint.Y - 1) / 2].Image = MAZE_UP;//up
                                break;
                            case 2: mazePoints[(currentPoint.X - 1) / 2, (currentPoint.Y - 1) / 2].Image = MAZE_LEFT;//left
                                break;
                            case 3: mazePoints[(currentPoint.X - 1) / 2, (currentPoint.Y - 1) / 2].Image = MAZE_DOWN;//down
                                break;
                        }

                        //set the new point
                        mazeData[currentPoint.X + DIRECTIONS[i].X, currentPoint.Y + DIRECTIONS[i].Y] = WALL;
                        currentPoint = new Point(currentPoint.X + 2 * DIRECTIONS[i].X, currentPoint.Y + 2 * DIRECTIONS[i].Y);
                    }
                }
            }

        }

        private bool CheckDeadEnd(Point loc, bool[,] mazeData) //returns true for dead end (only works for non-boundary points)
        {
            int walls = 0;
            bool deadEnd = false;
            if (loc != new Point(startPoint.X * 2 + 1, startPoint.Y * 2 + 1) && loc != new Point(endPoint.X * 2 + 1, endPoint.Y * 2 + 1) && mazeData[loc.X, loc.Y] == PATH)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (mazeData[loc.X + DIRECTIONS[i].X, loc.Y + DIRECTIONS[i].Y] == WALL)
                    {
                        walls++;
                    }
                }

                if (walls >= 3)
                {
                    deadEnd = true;
                }
            }

            return deadEnd;
        }

        private void MazeSelectionPointsVisibility(bool visible)
        {
            for (int x = 0; x < MAZE_SIZE; x++)
            {
                for (int y = 0; y < MAZE_SIZE; y++)
                {
                    mazePoints[x, y].Visible = visible;
                }
            }
        }
    }
}
