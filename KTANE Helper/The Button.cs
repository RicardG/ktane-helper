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
    public partial class The_Button : Form
    {
        public The_Button()
        {
            InitializeComponent();
            ResetModule();
        }

        #region Globals
        //constants
        //label
        const int abort = 0;
        const int detonate = 1;
        const int hold = 2;
        const int press = 3;

        //colour
        const int red = 0;
        const int blue = 1;
        const int yellow = 2;
        const int white = 3;

        //globals
        int label = -1;
        int colour = -1;
        //bool batMore = false;
        #endregion

        #region Input
        private void LabelInput(object sender, EventArgs e)
        {//get sender
            Button input = (Button)sender;
            label = int.Parse((string)input.Tag);

            //enable buttons
            EnableLabelInput(true);
            input.Enabled = false;

            groupBatteries.Visible = false;
            groupColour.Visible = false;

            if (label == detonate) //detonate & 2+ batteries
            {
                groupBatteries.Visible = true;
                btnBatLess.Enabled = true;
                btnBatMore.Enabled = true;
            }
            else if (label == hold)
            {
                groupColour.Visible = true;
                EnableColourInput(true);
                colour = -1;
            }
            Evaluation();
        }

        private void ColourInput(object sender, EventArgs e)
        {//get sender
            Button input = (Button)sender;
            colour = int.Parse((string)input.Tag);

            //enable buttons
            EnableColourInput(true);
            input.Enabled = false;

            Evaluation();
        }

        private void btnBatLess_Click(object sender, EventArgs e)
        {
            //batMore = false;
            btnBatLess.Enabled = false;
            btnBatMore.Enabled = true;
            Evaluation();
        }

        private void btnBatMore_Click(object sender, EventArgs e)
        {
            //batMore = true;
            btnBatLess.Enabled = true;
            btnBatMore.Enabled = false;
            Evaluation();
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            //MessageBox.Show("LOL, U IS WINNER");

            if ((label == detonate && !btnBatMore.Enabled) || (label == hold && colour == red)) //detonate & 2+ batteries || hold & red
                lblResult.Text = "Press and immediately release the button.";
            else if ((label == detonate && btnBatMore.Enabled && btnBatLess.Enabled) || (label == hold && colour == -1) || label == -1) //no label was pressed or only hold or detonate was pressed
                lblResult.Text = "Waiting for all input.";
            else //everything else
                lblResult.Text = "Hold the button and look at the coloured strip.\nBlue = 4, Yellow = 5, Other = 1.";

        }
        #endregion

        #region Reset Commands
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }

        private void ResetModule()
        {
            groupBatteries.Visible = false;
            groupColour.Visible = false;

            EnableLabelInput(true);
            EnableColourInput(true);
            EnableBatteryInput(true);

            label = -1;
            colour = -1;

            lblResult.Text = "Waiting for all input.";
        }

        private void EnableLabelInput(bool enable)
        {
            btnAbort.Enabled = enable;
            btnDetonate.Enabled = enable;
            btnHold.Enabled = enable;
            btnPress.Enabled = enable;
        }

        private void EnableColourInput(bool enable)
        {
            btnRed.Enabled = enable;
            btnBlue.Enabled = enable;
            btnYellow.Enabled = enable;
            btnWhite.Enabled = enable;
        }

        private void EnableBatteryInput(bool enable)
        {
            btnBatMore.Enabled = enable;
            btnBatLess.Enabled = enable;
        }
        #endregion
    }
}
