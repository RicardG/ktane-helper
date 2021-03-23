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
    public partial class Simon_Says : Form
    {
        public Simon_Says()
        {
            InitializeComponent();

            //add button tags
            //strike input
            btn0Strike.Tag = 0;
            btn1Strike.Tag = 1;
            btn2Strike.Tag = 2;

            //vowel input
            btnNoVowel.Tag = 0;
            btnVowel.Tag = 1;

            //colour input
            btnBlue.Tag = blue;
            btnRed.Tag = red;
            btnYellow.Tag = yellow;
            btnGreen.Tag = green;

            //setup vowel logic
            logicVowel[red, 0] = blue;
            logicVowel[red, 1] = yellow;
            logicVowel[red, 2] = green;
            logicVowel[blue, 0] = red;
            logicVowel[blue, 1] = green;
            logicVowel[blue, 2] = red;
            logicVowel[green, 0] = yellow;
            logicVowel[green, 1] = blue;
            logicVowel[green, 2] = yellow;
            logicVowel[yellow, 0] = green;
            logicVowel[yellow, 1] = red;
            logicVowel[yellow, 2] = blue;

            //setup novowel logic
            logicNoVowel[red, 0] = blue;
            logicNoVowel[red, 1] = red;
            logicNoVowel[red, 2] = yellow;
            logicNoVowel[blue, 0] = yellow;
            logicNoVowel[blue, 1] = blue;
            logicNoVowel[blue, 2] = green;
            logicNoVowel[green, 0] = green;
            logicNoVowel[green, 1] = yellow;
            logicNoVowel[green, 2] = blue;
            logicNoVowel[yellow, 0] = red;
            logicNoVowel[yellow, 1] = green;
            logicNoVowel[yellow, 2] = red;

            //setup display picboxes
            resultDisplay[0] = picResult1;
            resultDisplay[1] = picResult2;
            resultDisplay[2] = picResult3;
            resultDisplay[3] = picResult4;
            resultDisplay[4] = picResult5;
            resultDisplay[5] = picResult6;
            resultDisplay[6] = picResult7;
            resultDisplay[7] = picResult8;

            ResetModule();
        }

        #region Globals
        PictureBox[] resultDisplay = new PictureBox[8];

        //colours RBGY
        const int blue = 0;
        const int red = 1;
        const int yellow = 2;
        const int green = 3;

        int strikes = -1;
        int vowel = -1;

        int[] inputColours = new int[8];
        int inputLength = 0;

        //logic tables (Colour,Strikes)
        int[,] logicVowel = new int[4, 3];
        int[,] logicNoVowel = new int[4, 3];
        #endregion

        #region Strikes
        /*
        private void btn0Strike_Click(object sender, EventArgs e)
        {
            strikes = 0;
            EnableStrikeInput(true);
            btn0Strike.Enabled = false;
        }

        private void btn1Strike_Click(object sender, EventArgs e)
        {
            strikes = 1;
            EnableStrikeInput(true);
            btn1Strike.Enabled = false;
        }

        private void btn2Strike_Click(object sender, EventArgs e)
        {
            strikes = 2;
            EnableStrikeInput(true);
            btn2Strike.Enabled = false;
        }
        */

        private void StrikeInput(object sender, EventArgs e)
        {
            Button input = (Button)sender;

            strikes = (int) input.Tag;
            EnableStrikeInput(true);
            input.Enabled = false;
            Evaluation();
        }

        private void EnableStrikeInput(bool enable)
        {
            btn0Strike.Enabled = enable;
            btn1Strike.Enabled = enable;
            btn2Strike.Enabled = enable;
        }
        #endregion

        #region Serial Vowel
        /*
        private void btnVowel_Click(object sender, EventArgs e)
        {
            vowel = 1;
            EnableVowelInput(true);
            btnVowel.Enabled = false;
        }

        private void btnNoVowel_Click(object sender, EventArgs e)
        {
            vowel = 0;
            EnableVowelInput(true);
            btnNoVowel.Enabled = false;
        }
        */

        private void VowelInput(object sender, EventArgs e)
        {
            Button input = (Button)sender;

            vowel = (int)input.Tag;
            EnableVowelInput(true);
            input.Enabled = false;
            Evaluation();
        }

        private void EnableVowelInput(bool enable)
        {
            btnVowel.Enabled = enable;
            btnNoVowel.Enabled = enable;
        }
        #endregion

        #region Colour Input
        /*
        private void btnBlue_Click(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {

        }

        private void btnYellow_Click(object sender, EventArgs e)
        {

        }
         */

        private void ColourInput(object sender, EventArgs e)
        {
            Button input = (Button)sender;

            if (inputLength < 8)
            {
                if (inputLength == 7) //last input
                    EnableColourInput(false);
                inputColours[inputLength] = (int)input.Tag;
                inputLength++;
                UpdateInputList();
                Evaluation();
            }
        }

        private void EnableColourInput(bool enable)
        {
            btnBlue.Enabled = enable;
            btnRed.Enabled = enable;
            btnYellow.Enabled = enable;
            btnGreen.Enabled = enable;
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            if (vowel != -1 && strikes != -1) //strikes and vowel has be inputted
            {
                groupColourInput.Visible = true;
                listInputColours.Visible = true;

                if (inputLength > 0) //a colour has been inputted
                {
                    lblWaiting.Visible = false;

                    for (int i = 0; i < inputColours.Length; i++)
                    {
                        if (inputColours[i] != -1)
                        {
                            if (vowel == 0) //no vowel
                            { //set result colour. get the colour of the output colour based on the input colour and strikes
                                resultDisplay[i].BackColor = GetColour(logicNoVowel[inputColours[i],strikes]);
                            }
                            else if (vowel == 1) //vowel
                            {//set result colour. get the colour of the output colour based on the input colour and strikes
                                resultDisplay[i].BackColor = GetColour(logicVowel[inputColours[i], strikes]);
                            }
                        }
                    }
                }
            }
        }

        private Color GetColour(int colour)
        {
            if (colour == blue)
                return Color.Blue;
            if (colour == red)
                return Color.Red;
            if (colour == yellow)
                return Color.Yellow;
            return Color.Green;
        }

        private String GetColourName(int colour)
        {
            if (colour == blue)
                return "Blue";
            if (colour == red)
                return "Red";
            if (colour == yellow)
                return "Yellow";
            return "Green";
        }

        private void UpdateInputList()
        {
            //reset list
            listInputColours.Items.Clear();
            listInputColours.Items.Add("___ Input ___");
            listInputColours.Items.Add("===========");

            for (int i = 0; i < inputColours.Length; i++)
            {
                if (inputColours[i] != -1) //there is actually valid data
                {
                    listInputColours.Items.Add((i+1) + ". " + GetColourName(inputColours[i]));
                }
            }
            if (inputLength == 8)
            {
                listInputColours.Items.Add("===========");
                listInputColours.Items.Add("_ Max Input _");
            }
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }

        private void ResetModule()
        {
            lblWaiting.Visible = true;
            groupColourInput.Visible = false;
            listInputColours.Visible = false;

            //clear colour input & result picboxes
            for (int i = 0; i < inputColours.Length; i++)
            {
                inputColours[i] = -1;
                resultDisplay[i].BackColor = SystemColors.Control;
            }

            //reset buttons
            EnableStrikeInput(true);
            EnableVowelInput(true);
            EnableColourInput(true);

            //reset variables
            strikes = -1;
            vowel = -1;
            inputLength = 0;

            //reset input list
            UpdateInputList();
        }
        #endregion

    }
}
