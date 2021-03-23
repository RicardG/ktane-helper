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
    public partial class The_Knob : Form
    {
        public The_Knob()
        {
            InitializeComponent();
            Initialisation();
            Reset();
        }

        #region Globals
        //constants
        PictureBox[,] INPUT_BOX = new PictureBox[3, 2];
        const int PICBOX_SIZE = 75;
        const int PICBOX_SPACING = 16;
        const int PICBOX_OFFSET_X = 11;
        const int PICBOX_OFFSET_Y = 24;
        Image IMAGE_SELECTION = Properties.Resources.Cross;

        const int NO_DATA = -1;

        const bool X = true;
        const bool O = false;
        bool[, ,] data = new bool[8, 3, 2];
        //global variables
        bool[,] lights = new bool[3, 2];
        #endregion

        #region Initialisation
        private void Initialisation()
        {
            //set up clickable pictureboxes
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    PictureBox temp = new PictureBox();
                    temp.BorderStyle = BorderStyle.Fixed3D;
                    temp.Tag = new Point(x, y);
                    temp.Size = new Size(PICBOX_SIZE, PICBOX_SIZE);
                    temp.SizeMode = PictureBoxSizeMode.Zoom;
                    temp.MouseDown += ToggleLight;

                    groupInput.Controls.Add(temp);
                    temp.Location = new Point(PICBOX_OFFSET_X + (PICBOX_SPACING + PICBOX_SIZE) * x, PICBOX_OFFSET_Y + (PICBOX_SPACING + PICBOX_SIZE) * y);
                    INPUT_BOX[x, y] = temp;
                }
            }

            //set up data so that it is usable
            string[] tempData = Properties.Resources.Knob_Data.Split(' ');
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tempData[i][j] == 'O')
                    {
                        //this is not a light
                        data[i, j % 3, j / 3] = false;

                    }
                    else if (tempData[i][j] == 'X')
                    {
                        //this is a light
                        data[i, j % 3, j / 3] = true;
                    }
                }
            }
        }
        #endregion

        #region Input
        private void ToggleLight(object sender, EventArgs e)
        {
            PictureBox input = (PictureBox)sender;
            int x = ((Point)input.Tag).X;
            int y = ((Point)input.Tag).Y;
            lights[x, y] = !lights[x, y];

            Evaluation();
            UpdateDisplay();
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            lblResult.Text = "Waiting for input";
            //compare the curent configuration with each available configuration
            //if one matches then display the appropriate result
            //otherwise, display unknown configuration
            int config = NO_DATA;
            for (int i = 0; i < 8; i++) //for each config
            {
                int correctLights = 0;
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        if (data[i, x, y] == lights[x, y])
                        {
                            correctLights++;
                        }
                    }
                }
                if (correctLights == 6)
                {
                    //this is a correct configuration
                    config = i;
                    break;
                }
            }

            if (config != NO_DATA)
            {
                //this is a valid configuration
                //up,down,left,right
                switch (config / 2)
                {
                    case 0: lblResult.Text = "Turn the knob to the UP position"; //up
                        break;
                    case 1: lblResult.Text = "Turn the knob to the DOWN position"; //down
                        break;
                    case 2: lblResult.Text = "Turn the knob to the LEFT position"; //left
                        break;
                    case 3: lblResult.Text = "Turn the knob to the RIGHT positition"; //right
                        break;
                }
            }

        }

        private void UpdateDisplay()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    if (lights[x, y])
                    {
                        INPUT_BOX[x, y].Image = IMAGE_SELECTION;
                    }
                    else
                    {
                        INPUT_BOX[x, y].Image = null;
                    }
                }
            }
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    lights[x, y] = false;
                }
            }

            Evaluation();
            UpdateDisplay();
        }
        #endregion
    }
}
