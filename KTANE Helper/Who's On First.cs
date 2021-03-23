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
    public partial class Who_s_On_First : Form
    {
        public Who_s_On_First()
        {
            InitializeComponent();

            SetupAnswerArray();
            CreateButtons();          
            //string[] test = step2Answer[0].Replace(" ", "").Split(',');
            //groupsize = 642, 249
            ResetModule();
        }

        #region Globals
        string[] step1Labels = { "BLANK", "C", "CEE", "DISPLAY", "FIRST", "HOLD ON", "LEAD", "LED", "LEED", "NO", "NOTHING", "OKAY", "READ", "RED", "REED", "SAYS", "SEE", "THEIR", "THERE", "THEY'RE", "THEY ARE", "UR", "YES", "YOU", "YOU'RE", "YOUR", "YOU ARE", "" };
        int[] step1Answer = new int[28];
        string[] step2Labels = { "BLANK", "DONE", "FIRST", "HOLD", "LEFT", "LIKE", "MIDDLE", "NEXT", "NO", "NOTHING", "OKAY", "PRESS", "READY", "RIGHT", "SURE", "U", "UH HUH", "UH UH", "UHHH", "UR", "WAIT", "WHAT", "WHAT?", "YES", "YOU", "YOU ARE", "YOUR", "YOU'RE" };
        string[] step2Answer = new string[28];

        Button[] step1Buttons = new Button[28];
        Button[] step2Buttons = new Button[28];
        int xSpacing = 106;
        int ySpacing = 46;
        Point startLocation = new Point(6, 19);
        Size buttonSize = new Size(100, 40);
        //List<int> selectedLabelsPart2 = new List<int>();
        string[] step2Result = new string[14];

        int step2CurrentView = 0;

        //location identifiers
        const int TOP_LEFT = 0;
        const int TOP_RIGHT = 1;
        const int MIDDLE_LEFT = 2;
        const int MIDDLE_RIGHT = 3;
        const int BOTTOM_LEFT = 4;
        const int BOTTOM_RIGHT = 5;
        #endregion

        #region Initialisation
        private void SetupAnswerArray()
        {
            //set up answer array (step 1)
            step1Answer[00] = MIDDLE_RIGHT; //BLANK
            step1Answer[01] = TOP_RIGHT; //C
            step1Answer[02] = BOTTOM_RIGHT; //CEE
            step1Answer[03] = BOTTOM_RIGHT; //DISPLAY
            step1Answer[04] = TOP_RIGHT; //FIRST
            step1Answer[05] = BOTTOM_RIGHT; //HOLD ON
            step1Answer[06] = BOTTOM_RIGHT; //LEAD
            step1Answer[07] = MIDDLE_LEFT; //LED
            step1Answer[08] = BOTTOM_LEFT; //LEED
            step1Answer[09] = BOTTOM_RIGHT; //NO
            step1Answer[10] = MIDDLE_LEFT; //NOTHING
            step1Answer[11] = TOP_RIGHT; //OKAY
            step1Answer[12] = MIDDLE_RIGHT; //READ
            step1Answer[13] = MIDDLE_RIGHT; //RED
            step1Answer[14] = BOTTOM_LEFT; //REED
            step1Answer[15] = BOTTOM_RIGHT; //SAYS
            step1Answer[16] = BOTTOM_RIGHT; //SEE
            step1Answer[17] = MIDDLE_RIGHT; //THEIR
            step1Answer[18] = BOTTOM_RIGHT; //THERE
            step1Answer[19] = BOTTOM_LEFT; //THEY'RE
            step1Answer[20] = MIDDLE_LEFT; //THEY ARE
            step1Answer[21] = TOP_LEFT; //UR
            step1Answer[22] = MIDDLE_LEFT; //YES
            step1Answer[23] = MIDDLE_RIGHT; //YOU
            step1Answer[24] = MIDDLE_RIGHT; //YOU'RE
            step1Answer[25] = MIDDLE_RIGHT; //YOUR
            step1Answer[26] = BOTTOM_RIGHT; //YOU ARE
            step1Answer[27] = BOTTOM_LEFT; //""

            //set up answer array (step 2)
            step2Answer[00] = "WAIT, RIGHT, OKAY, MIDDLE, BLANK, PRESS, READY, NOTHING, NO, WHAT, LEFT, UHHH, YES, FIRST"; //BLANK
            step2Answer[01] = "SURE, UH HUH, NEXT, WHAT?, YOUR, UR, YOU'RE, HOLD, LIKE, YOU, U, YOU ARE, UH UH, DONE"; //DONE
            step2Answer[02] = "LEFT, OKAY, YES, MIDDLE, NO, RIGHT, NOTHING, UHHH, WAIT, READY, BLANK, WHAT, PRESS, FIRST"; //FIRST
            step2Answer[03] = "YOU ARE, U, DONE, UH UH, YOU, UR, SURE, WHAT?, YOU'RE, NEXT, HOLD, UH HUH, YOUR, LIKE"; //HOLD
            step2Answer[04] = "RIGHT, LEFT, FIRST, NO, MIDDLE, YES, BLANK, WHAT, UHHH, WAIT, PRESS, READY, OKAY, NOTHING"; //LEFT
            step2Answer[05] = "YOU'RE, NEXT, U, UR, HOLD, DONE, UH UH, WHAT?, UH HUH, YOU, LIKE, SURE, YOU ARE, YOUR"; //LIKE
            step2Answer[06] = "BLANK, READY, OKAY, WHAT, NOTHING, PRESS, NO, WAIT, LEFT, MIDDLE, RIGHT, FIRST, UHHH, YES"; //MIDDLE
            step2Answer[07] = "WHAT?, UH HUH, UH UH, YOUR, HOLD, SURE, NEXT, LIKE, DONE, YOU ARE, UR, YOU'RE, U, YOU"; //NEXT
            step2Answer[08] = "BLANK, UHHH, WAIT, FIRST, WHAT, READY, RIGHT, YES, NOTHING, LEFT, PRESS, OKAY, NO, MIDDLE"; //NO
            step2Answer[09] = "UHHH, RIGHT, OKAY, MIDDLE, YES, BLANK, NO, PRESS, LEFT, WHAT, WAIT, FIRST, NOTHING, READY"; //NOTHING
            step2Answer[10] = "MIDDLE, NO, FIRST, YES, UHHH, NOTHING, WAIT, OKAY, LEFT, READY, BLANK, PRESS, WHAT, RIGHT"; //OKAY
            step2Answer[11] = "RIGHT, MIDDLE, YES, READY, PRESS, OKAY, NOTHING, UHHH, BLANK, LEFT, FIRST, WHAT, NO, WAIT"; //PRESS
            step2Answer[12] = "YES, OKAY, WHAT, MIDDLE, LEFT, PRESS, RIGHT, BLANK, READY, NO, FIRST, UHHH, NOTHING, WAIT"; //READY
            step2Answer[13] = "YES, NOTHING, READY, PRESS, NO, WAIT, WHAT, RIGHT, MIDDLE, LEFT, UHHH, BLANK, OKAY, FIRST"; //RIGHT
            step2Answer[14] = "YOU ARE, DONE, LIKE, YOU'RE, YOU, HOLD, UH HUH, UR, SURE, U, WHAT?, NEXT, YOUR, UH UH"; //SURE
            step2Answer[15] = "UH HUH, SURE, NEXT, WHAT?, YOU'RE, UR, UH UH, DONE, U, YOU, LIKE, HOLD, YOU ARE, YOUR"; //U
            step2Answer[16] = "UH HUH, YOUR, YOU ARE, YOU, DONE, HOLD, UH UH, NEXT, SURE, LIKE, YOU'RE, UR, U, WHAT?"; //UH HUH
            step2Answer[17] = "UR, U, YOU ARE, YOU'RE, NEXT, UH UH, DONE, YOU, UH HUH, LIKE, YOUR, SURE, HOLD, WHAT?"; //UH UH
            step2Answer[18] = "READY, NOTHING, LEFT, WHAT, OKAY, YES, RIGHT, NO, PRESS, BLANK, UHHH, MIDDLE, WAIT, FIRST"; //UHHH
            step2Answer[19] = "DONE, U, UR, UH HUH, WHAT?, SURE, YOUR, HOLD, YOU'RE, LIKE, NEXT, UH UH, YOU ARE, YOU"; //UR
            step2Answer[20] = "UHHH, NO, BLANK, OKAY, YES, LEFT, FIRST, PRESS, WHAT, WAIT, NOTHING, READY, RIGHT, MIDDLE"; //WAIT
            step2Answer[21] = "UHHH, WHAT, LEFT, NOTHING, READY, BLANK, MIDDLE, NO, OKAY, FIRST, WAIT, YES, PRESS, RIGHT"; //WHAT
            step2Answer[22] = "YOU, HOLD, YOU'RE, YOUR, U, DONE, UH UH, LIKE, YOU ARE, UH HUH, UR, NEXT, WHAT?, SURE"; //WHAT?
            step2Answer[23] = "OKAY, RIGHT, UHHH, MIDDLE, FIRST, WHAT, PRESS, READY, NOTHING, YES, LEFT, BLANK, NO, WAIT"; //YES
            step2Answer[24] = "SURE, YOU ARE, YOUR, YOU'RE, NEXT, UH HUH, UR, HOLD, WHAT?, YOU, UH UH, LIKE, DONE, U"; //YOU
            step2Answer[25] = "YOUR, NEXT, LIKE, UH HUH, WHAT?, DONE, UH UH, HOLD, YOU, U, YOU'RE, SURE, UR, YOU ARE"; //YOU ARE
            step2Answer[26] = "UH UH, YOU ARE, UH HUH, YOUR, NEXT, UR, SURE, U, YOU'RE, YOU, WHAT?, HOLD, LIKE, DONE"; //YOUR
            step2Answer[27] = "YOU, YOU'RE, UR, NEXT, UH UH, YOU ARE, U, YOUR, WHAT?, UH HUH, SURE, DONE, LIKE, HOLD"; //YOU'RE
        }

        private void CreateButtons()
        {
            //create buttons
            int i = 0;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (y == 4 && x == 0)
                    {
                        x = 1;
                    }
                    //step 1
                    step1Buttons[i] = new Button();
                    step1Buttons[i].Click += Step1Evaluation;
                    step1Buttons[i].Tag = i;
                    step1Buttons[i].Text = step1Labels[i];
                    step1Buttons[i].Size = buttonSize;
                    step1Buttons[i].Font = new System.Drawing.Font(step1Buttons[i].Font.FontFamily, 12F, FontStyle.Regular);
                    step1Buttons[i].TabStop = false;
                    groupStep1.Controls.Add(step1Buttons[i]);
                    step1Buttons[i].Location = new Point(startLocation.X + xSpacing * x, startLocation.Y + ySpacing * y);

                    //step 2
                    step2Buttons[i] = new Button();
                    step2Buttons[i].Click += Step2Evaluation;
                    step2Buttons[i].Tag = i;
                    step2Buttons[i].Text = step2Labels[i];
                    step2Buttons[i].Size = buttonSize;
                    step2Buttons[i].Font = new System.Drawing.Font(step1Buttons[i].Font.FontFamily, 12F, FontStyle.Regular);
                    step2Buttons[i].TabStop = false;
                    groupStep2.Controls.Add(step2Buttons[i]);
                    step2Buttons[i].Location = new Point(startLocation.X + xSpacing * x, startLocation.Y + ySpacing * y);

                    i++;

                    if (y == 4 && x == 4)
                    {
                        x = 6;
                    }
                }
            }
        }
        #endregion

        #region Evaluation
        private void Step1Evaluation(object sender, EventArgs e)
        {
            Button input = (Button)sender;

            //disable only the button pressed
            EnableStep1Buttons(true);
            input.Enabled = false;

            int index = (int)input.Tag;

            lblStep1Result.Visible = true;
            lblStep1Result.Text = step1Labels[index];
            picStep1Result.Image = imagePositions.Images[step1Answer[index]];

            EnableStep2Buttons(true);
        }

        private void Step2Evaluation(object sender, EventArgs e)
        {
            Button input = (Button)sender;

            //disable only the selected buttons
            EnableStep2Buttons(true);
            input.Enabled = false;
            ShowStep2Result(true);

            string[] seperator = { ", " };

            step2Result = step2Answer[(int)input.Tag].Replace(", ", ",").Split(',');
            step2CurrentView = 0;
            UpdateStep2Result();
            lblSelected.Text = "Selected Word: " + step2Labels[(int)input.Tag];
        }

        private void ShowStep2Result(bool visible)
        {
            lblCurrent.Visible = visible;
            lblNext.Visible = visible;
            lblPrevious.Visible = visible;
            lblInfoCurrent.Visible = visible;
            btnNext.Visible = visible;
            btnPrevious.Visible = visible;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (step2CurrentView > 0)
            {
                step2CurrentView--;
                UpdateStep2Result();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (step2CurrentView < step2Result.Length - 1)
            {
                step2CurrentView++;
                UpdateStep2Result();
            }
        }

        private void UpdateStep2Result()
        {
            if (step2CurrentView > 0)
            {
                lblPrevious.Text = step2Result[step2CurrentView - 1];
            }
            else
            {
                lblPrevious.Text = "";
            }

            lblCurrent.Text = step2Result[step2CurrentView];

            if (step2CurrentView < step2Result.Length - 1)
            {
                lblNext.Text = step2Result[step2CurrentView + 1];
            }
            else
            {
                lblNext.Text = "";
            }
        }
        #endregion

        #region Input Control
        private void EnableStep1Buttons(bool enable)
        {
            for (int i = 0; i < step1Buttons.Length; i++)
            {
                step1Buttons[i].Enabled = enable;
            }
        }

        private void EnableStep2Buttons(bool enable)
        {
            for (int i = 0; i < step2Buttons.Length; i++)
            {
                step2Buttons[i].Enabled = enable;
            }
        }
        #endregion

        #region Reset
        private void ResetModule()
        {
            lblStep1Result.Visible = false;
            EnableStep1Buttons(true);
            EnableStep2Buttons(false);
            picStep1Result.Image = null;
            lblCurrent.Text = "";
            lblPrevious.Text = "";
            lblNext.Text = "";
            lblSelected.Text = "Waiting for all input.";
            ShowStep2Result(false);
            step2CurrentView = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }
        #endregion
    }
}
