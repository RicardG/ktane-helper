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
    public partial class WireSequence : Form
    {
        public WireSequence()
        {
            InitializeComponent();

            ResetModule();
            Evaluation();
        }

        #region Globals
        const int MAX_WIRES = 11;
        const int MAX_WIRES_PER_COLOUR = 9;

        //const int EMPTY = 0;
        const int A = 1;
        const int B = 2;
        const int C = 3;
        const int ALL = 4;

        const int RED = 1;
        const int BLUE = 2;
        const int BLACK = 3;

        const int NO_DATA = 0;

        int[,] REDDATA = new int[9, 2] { { C, C }, { B, B }, { A, A }, { A, C }, { B, B }, { A, C }, { ALL, ALL }, { A, B }, { B, B } };
        int[,] BLUEDATA = new int[9, 2] { { B, B }, { A, C }, { B, B }, { A, A }, { B, B }, { B, C }, { C, C }, { A, C }, { A, A } };
        int[,] BLACKDATA = new int[9, 2] { { ALL, ALL }, { A, C }, { B, B }, { A, C }, { B, B }, { B, C }, { A, B }, { C, C }, { C, C } };

        int wireCountRed = 0;
        int wireCountBlue = 0;
        int wireCountBlack = 0;

        int wireColour = NO_DATA;
        int wireLetter = NO_DATA;
        #endregion

        #region Initialisation
        private void Initialisation()
        {
            
        }
        #endregion

        #region Input
        private void btnRed_Click(object sender, EventArgs e)
        {
            wireColour = RED;
            resetColourInputButtonColours();
            btnRed.BackColor = Color.Red;
            Evaluation();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            
            wireColour = BLUE;
            resetColourInputButtonColours();
            btnBlue.BackColor = Color.Blue;
            btnBlue.ForeColor = Color.White;
            Evaluation();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            wireColour = BLACK;
            resetColourInputButtonColours();
            btnBlack.BackColor = Color.Black;
            btnBlack.ForeColor = Color.White;
            Evaluation();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            wireLetter = A;
            enableLetterInput(true);
            btnA.Enabled = false;
            Evaluation();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            wireLetter = B;
            enableLetterInput(true);
            btnB.Enabled = false;
            Evaluation();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            wireLetter = C;
            enableLetterInput(true);
            btnC.Enabled = false;
            Evaluation();
        }

        private void enableColourInput(bool enable)
        {
            btnRed.Enabled = enable;
            btnBlue.Enabled = enable;
            btnBlack.Enabled = enable;
        }

        private void enableLetterInput(bool enable)
        {
            btnA.Enabled = enable;
            btnB.Enabled = enable;
            btnC.Enabled = enable;
        }

        private void resetColourInputButtonColours()
        {
            btnRed.BackColor = default(Color);
            btnRed.UseVisualStyleBackColor = true;
            btnRed.ForeColor = default(Color);

            btnBlue.BackColor = default(Color);
            btnBlue.ForeColor = default(Color);
            btnBlue.UseVisualStyleBackColor = true;

            btnBlack.BackColor = default(Color);
            btnBlack.UseVisualStyleBackColor = true;
            btnBlack.ForeColor = default(Color);
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            groupWireInput.Text = "Wire Input - Wire " + (wireCountTotal() + 1).ToString();
            if (wireColour != NO_DATA && wireLetter != NO_DATA)
            {
                bool cut = false;
                //get current colour's wire number
                switch (wireColour)
                {
                    case RED:
                        if (REDDATA[wireCountRed, 0] == wireLetter || REDDATA[wireCountRed, 1] == wireLetter || REDDATA[wireCountRed,0] == ALL)
                        {
                            cut = true;
                        }
                        break;
                    case BLUE:
                        if (BLUEDATA[wireCountBlue, 0] == wireLetter || BLUEDATA[wireCountBlue, 1] == wireLetter || BLUEDATA[wireCountBlue, 0] == ALL)
                        {
                            cut = true;
                        }
                        break;
                    case BLACK:
                        if (BLACKDATA[wireCountBlack, 0] == wireLetter || BLACKDATA[wireCountBlack, 1] == wireLetter || BLACKDATA[wireCountBlack, 0] == ALL)
                        {
                            cut = true;
                        }
                        break;
                }

                if (cut)
                {
                    lblResult.Text = "Cut the wire.";
                }
                else
                {
                    lblResult.Text = "Do not cut the wire.";
                }

                if (wireCountTotal() < MAX_WIRES)
                {
                    btnNextWire.Enabled = true;
                }
            }
            else
            {
                lblResult.Text = "Waiting for all input.";
                btnNextWire.Enabled = false;
            }
        }

        private void btnNextWire_Click(object sender, EventArgs e)
        {
            //add onto wire count
            switch (wireColour)
            {
                case RED: wireCountRed++;
                    break;
                case BLUE: wireCountBlue++;
                    break;
                case BLACK: wireCountBlack++;
                    break;
            }

            //disable input for colours with maximum input
            if (wireCountRed >= MAX_WIRES_PER_COLOUR)
            {
                btnRed.Enabled = false;
            }
            if (wireCountBlue >= MAX_WIRES_PER_COLOUR)
            {
                btnBlue.Enabled = false;
            }
            if (wireCountBlack >= MAX_WIRES_PER_COLOUR)
            {
                btnBlack.Enabled = false;
            }

            //ADD PREV ENTRY INTO HISTORY
            string colourName = "";
            string letterName = "";
            switch (wireColour)
            {
                case RED: colourName = "Red";
                    break;
                case BLUE: colourName = "Blue";
                    break;
                case BLACK: colourName = "Black";
                    break;
            }

            switch (wireLetter)
            {
                case A: letterName = "A";
                    break;
                case B: letterName = "B";
                    break;
                case C: letterName = "C";
                    break;
            }

            listHistory.Items.Add("0" + wireCountTotal().ToString() + ") " + colourName + " -> " + letterName);

            //reset buttons
            resetColourInputButtonColours();
            enableLetterInput(true);

            wireColour = NO_DATA;
            wireLetter = NO_DATA;
            Evaluation();
            //btnNextWire.Enabled = false;
        }

        private int wireCountTotal()
        {
            return wireCountRed + wireCountBlue + wireCountBlack;
        }
        #endregion

        #region Reset
        private void ResetModule()
        {
            listHistory.Items.Clear();

            wireColour = NO_DATA;
            wireLetter = NO_DATA;

            wireCountRed = 0;
            wireCountBlue = 0;
            wireCountBlack = 0;

            enableColourInput(true);
            enableLetterInput(true);
            resetColourInputButtonColours();
            btnNextWire.Enabled = true;

            lblResult.Text = "Waiting for all input.";

            Evaluation();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }
        #endregion

        
    }
}
