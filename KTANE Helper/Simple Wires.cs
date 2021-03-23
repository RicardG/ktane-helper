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
    public partial class Simple_Wires : Form
    {
        public Simple_Wires()
        {
            InitializeComponent();

            ResetModule();
        }

        #region Globals
        //global variables
        int wireNumber = 0;
        int wiresColoured = 0;
        bool serialOdd = false;
        int[] wireColour = new int[6];

        //colour constants
        const int white = 0;
        const int black = 1;
        const int red = 2;
        const int blue = 3;
        const int yellow = 4;
        #endregion

        #region Input
        #region Number of Wires Input
        private void btn3Wires_Click(object sender, EventArgs e)
        {
            SelectNumberWires(3);
        }

        private void btn4Wires_Click(object sender, EventArgs e)
        {
            SelectNumberWires(4);
        }

        private void btn5Wires_Click(object sender, EventArgs e)
        {
            SelectNumberWires(5);
        }

        private void btn6Wires_Click(object sender, EventArgs e)
        {
            SelectNumberWires(6);
        }

        private void SelectNumberWires(int wires)
        {
            //show relevant wire colour strips
            if (wires < 6)
            {
                picWire6.Visible = false;
                lblWire6.Visible = false;

                if (wires < 5)
                {
                    picWire5.Visible = false;
                    lblWire5.Visible = false;

                    if (wires < 4)
                    {
                        picWire4.Visible = false;
                        lblWire4.Visible = false;
                    }
                }
            }

            //show other group boxes
            groupWireInput.Visible = true;
            groupWires.Visible = true;

            wireNumber = wires;

            EnableNumberWireInput(false);
        }

        private void EnableNumberWireInput(bool enable)
        {
            btn3Wires.Enabled = enable;
            btn4Wires.Enabled = enable;
            btn5Wires.Enabled = enable;
            btn6Wires.Enabled = enable;
        }
        #endregion

        #region Serial Input
        private void btnSerialOdd_Click(object sender, EventArgs e)
        {
            serialOdd = true;
            btnSerialEven.Enabled = true;
            btnSerialOdd.Enabled = false;
            Evaluation();
        }

        private void btnSerialEven_Click(object sender, EventArgs e)
        {
            serialOdd = false;
            btnSerialEven.Enabled = false;
            btnSerialOdd.Enabled = true;
            Evaluation();
        }
        #endregion

        #region Wire Colours Input
        private void btnWhite_Click(object sender, EventArgs e)
        {
            AddWireColour(white);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            AddWireColour(black);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            AddWireColour(red);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            AddWireColour(blue);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            AddWireColour(yellow);
        }

        private void DisplayWireColours()
        {
            picWire1.BackColor = DetermineColour(wireColour[0]);
            picWire2.BackColor = DetermineColour(wireColour[1]);
            picWire3.BackColor = DetermineColour(wireColour[2]);
            picWire4.BackColor = DetermineColour(wireColour[3]);
            picWire5.BackColor = DetermineColour(wireColour[4]);
            picWire6.BackColor = DetermineColour(wireColour[5]);
        }

        private Color DetermineColour(int colour)
        {
            switch (colour)
            {
                case white: return Color.White;
                //break;
                case black: return Color.Black;
                //break;
                case red: return Color.Red;
                //break;
                case blue: return Color.Blue;
                //break;
                case yellow: return Color.Yellow;
                //break;
                default: return SystemColors.Control;
            }
        }

        private void AddWireColour(int colour)
        {//add new wire colour
            wireColour[wiresColoured] = colour;
            wiresColoured++;
            DisplayWireColours();

            if (wireNumber == 4 && WireCount(red) > 1) //serial required
            {
                groupSerial.Visible = true;
            }

            if (wiresColoured >= wireNumber)//all wires coloured
            {
                //show serial group box
                if (wireNumber == 6 && WireCount(yellow) == 0) //serial number is required
                {
                    groupSerial.Visible = true;
                }
                else if (wireNumber == 5 && ColourPosition(5) == black) //serial number required
                {
                    groupSerial.Visible = true;
                }

                //evaluation
                EnableColourInput(false);
                Evaluation();
            }            
        }

        private void EnableColourInput(bool enable)
        {
            btnWhite.Enabled = enable;
            btnBlack.Enabled = enable;
            btnRed.Enabled = enable;
            btnBlue.Enabled = enable;
            btnYellow.Enabled = enable;
        }
        #endregion
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }

        private void ResetModule()
        {
            //hide group boxes
            groupSerial.Visible = false;
            groupWires.Visible = false;
            groupWireInput.Visible = false;

            //result text
            lblResult.Text = "Waiting for all input.";

            //wire display
            picWire6.Visible = true;
            lblWire6.Visible = true;
            picWire5.Visible = true;
            lblWire5.Visible = true;
            picWire4.Visible = true;
            lblWire4.Visible = true;

            //Serial Number Buttons
            btnSerialEven.Enabled = true;
            btnSerialOdd.Enabled = true;

            //reset globals
            wiresColoured = 0;
            wireNumber = 0;
            serialOdd = false;

            //wire colours
            for (int i = 0; i < wireColour.Count(); i++)
            {
                wireColour[i] = -1;
            }
            DisplayWireColours();
            EnableColourInput(true);

            //number of wires
            EnableNumberWireInput(true);
        }
        #endregion

        #region Evaluation Commands
        private void Evaluation()
        {
            //if (wiresColoured == wireNumber && (!btnSerialOdd.Enabled || !btnSerialEven.Enabled || wireNumber == 3)) 
            if (wiresColoured == wireNumber && (!groupSerial.Visible || !btnSerialOdd.Enabled || !btnSerialEven.Enabled)) //if everything was completed
            {
                int cutPos = -1;
                //MessageBox.Show("LOL, U IS WINNER");

                //determine position of wire to cut
                switch (wireNumber)
                {
                    case 3:
                        {
                            if (WireCount(red) == 0) //no red
                                cutPos = 2;
                            else if (ColourPosition(3) == white) //last is white
                                cutPos = 3;
                            else if (WireCount(blue) > 1) //2+ blue
                            {
                                if (ColourPosition(3) == blue) //last (3) blue wire
                                    cutPos = 3;
                                else
                                    cutPos = 2;
                            }
                            else //otherwise
                                cutPos = 3;
                        }
                        break;
                    case 4:
                        {
                            if (WireCount(red) > 1 && serialOdd) //2+ red & serial is odd
                            {
                                if (ColourPosition(4) == red) //last (4) red wire
                                    cutPos = 4;
                                else if (ColourPosition(3) == red) //last (3) red wire
                                    cutPos = 3;
                                else
                                    cutPos = 2;
                            }
                            else if (ColourPosition(4) == yellow && WireCount(red) == 0) //last yellow & no red
                                cutPos = 1;
                            else if (WireCount(blue) == 1) //one blue
                                cutPos = 1;
                            else if (WireCount(yellow) > 1) //2+ yellow
                                cutPos = 4;
                            else //otherwise
                                cutPos = 2;
                        }
                        break;
                    case 5:
                        {
                            if (ColourPosition(5) == black && serialOdd) //last black & serial is odd
                                cutPos = 4;
                            else if (WireCount(red) == 1 && WireCount(yellow) > 1) //1 red & 2+ yellow
                                cutPos = 1;
                            else if (WireCount(black) == 0) //no black
                                cutPos = 2;
                            else //otherwise
                                cutPos = 1;
                        }
                        break;
                    case 6:
                        {
                            if (WireCount(yellow) == 0 && serialOdd) //no yellow & serial is odd
                                cutPos = 3;
                            else if (WireCount(yellow) == 1 && WireCount(white) > 1) //1 yellow & 2+ white
                                cutPos = 4;
                            else if (WireCount(red) == 0) //no red
                                cutPos = 6;
                            else //otherwise
                                cutPos = 4;
                        }
                        break;
                }

                if (cutPos == -1) //error handling
                    lblResult.Text = "ERROR";
                else if (!groupSerial.Visible)
                    lblResult.Text = "Cut the " + PositionToText(cutPos) + " wire.";
                else if (!serialOdd) //serial is even
                    lblResult.Text = "Cut the " + PositionToText(cutPos) + " wire. (Serial Digit is Even)";
                else //serial is odd
                    lblResult.Text = "Cut the " + PositionToText(cutPos) + " wire. (Serial Digit is Odd)";
            }
        }

        private int WireCount(int colour)
        {
            int totalWireCount = 0;
            for (int i = 0; i < wireNumber; i++)
            {
                if (wireColour[i] == colour)
                {
                    totalWireCount++;
                }
            }
            return totalWireCount;
        }

        private int ColourPosition(int position)
        {
            return wireColour[position - 1];
        }

        private string PositionToText(int position)
        {
            switch (position)
            {
                case 1: return "1st";
                case 2: return "2nd";
                case 3: return "3rd";
                case 4: return "4th";
                case 5: return "5th";
                case 6: return "6th";
                default: return "ERROR";
            }
        }
        #endregion
    }
}
