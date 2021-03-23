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
    public partial class ComplexWires : Form
    {
        public ComplexWires()
        {
            InitializeComponent();
            Initialisation();
            ResetModule();
        }

        #region Globals
        const int NUM_WIRES = 6;
        const int NUM_WIRE_PROPERTIES = 4;

        const int CUT = 0;
        const int NO_CUT = 1;
        const int SERIAL = 2;
        const int PARALLEL = 3;
        const int BATTERY = 4;

        const int LED = 0;
        const int RED = 1;
        const int BLUE = 2;
        const int STAR = 3;

        const int NOT_SET = 0;
        const int TRUE = 1;
        const int FALSE = 2;

        Color LED_COLOUR = Color.Yellow;
        Color RED_COLOUR = Color.Red;
        Color BLUE_COLOUR = Color.Blue;
        Color STAR_COLOUR = Color.Lime;

        Point BTN_START_LOC = new Point(6, 19);
        int BTN_INCREMENT_Y = 56;
        bool[] LED_DATA = new bool[16] { false, false, false, false, false, true, true, true, false, false, true, true, false, true, true, true };
        bool[] RED_DATA = new bool[16] { false, true, true, true, true, true, true, true, false, false, false, false, false, false, false, true };
        bool[] BLUE_DATA = new bool[16] { false, false, true, false, true, false, false, true, true, true, true, true, false, false, false, true };
        bool[] STAR_DATA = new bool[16] { false, false, false, true, true, false, true, false, false, true, false, true, true, true, false, true };

        bool[][] data;
        int[] dataResult;


        int serial = NOT_SET;
        int parallel = NOT_SET;
        int battery = NOT_SET;

        bool[,] wireInput;
        int[] wireResult;

        GroupBox[] inputGroups;
        Label[] resultLabels;
        Button[,] inputButtons = new Button[NUM_WIRES,NUM_WIRE_PROPERTIES];
        #endregion

        #region Initialisation
        public void Initialisation()
        {
            //set up data
            data = new bool[NUM_WIRE_PROPERTIES][] { LED_DATA, RED_DATA, BLUE_DATA, STAR_DATA };
            dataResult = new int[16] { CUT, SERIAL, SERIAL, CUT, PARALLEL, BATTERY, BATTERY, SERIAL, SERIAL, NO_CUT, PARALLEL, PARALLEL, CUT, BATTERY, NO_CUT, NO_CUT };
            wireInput = new bool[NUM_WIRES, NUM_WIRE_PROPERTIES];
            wireResult = new int[NUM_WIRES];

            //place designer elements in arrays
            //input groups
            inputGroups = new GroupBox[NUM_WIRES] { groupWire1, groupWire2, groupWire3, groupWire4, groupWire5, groupWire6 };
            resultLabels = new Label[NUM_WIRES] { lblResultWire1, lblResultWire2, lblResultWire3, lblResultWire4, lblResultWire5, lblResultWire6 };

            //create buttons for LED, Red, Blue and Star
            Font buttonFont = new Font("Microsoft Sans Serif", 12);
            Size buttonSize = new Size(50, 50);
            for (int y = 0; y < NUM_WIRE_PROPERTIES; y++)
            {
                for (int x = 0; x < NUM_WIRES; x++)
                {
                    inputButtons[x, y] = new Button();
                    inputButtons[x, y].Size = buttonSize;
                    inputButtons[x, y].Font = buttonFont;
                    inputButtons[x, y].Tag = x;
                    inputButtons[x, y].TabStop = false;
                    switch (y)
                    {
                        case LED: inputButtons[x, y].Text = "LED";
                            inputButtons[x, y].Click += InputLED;
                            break;

                        case RED: inputButtons[x, y].Text = "R";
                            inputButtons[x, y].Click += InputRed;
                            break;

                        case BLUE: inputButtons[x, y].Text = "B";
                            inputButtons[x, y].Click += InputBlue;
                            break;

                        case STAR: inputButtons[x, y].Text = "Star";
                            inputButtons[x, y].Click += InputStar;
                            break;
                    }

                    inputButtons[x, y].Location = new Point(BTN_START_LOC.X, BTN_START_LOC.Y + BTN_INCREMENT_Y * y);
                    inputGroups[x].Controls.Add(inputButtons[x, y]);
                }
            }
        }
        #endregion

        #region Wire Input
        private void InputLED(object sender, EventArgs e)
        {
            Button input = (Button)sender;
            int wireNum = (int)input.Tag;
            wireInput[wireNum, LED] = !wireInput[wireNum, LED];
            Evaluation();
            UpdateDisplay();
        }

        private void InputRed(object sender, EventArgs e)
        {
            Button input = (Button)sender;
            int wireNum = (int)input.Tag;
            wireInput[wireNum, RED] = !wireInput[wireNum, RED];
            Evaluation();
            UpdateDisplay();
        }

        private void InputBlue(object sender, EventArgs e)
        {
            Button input = (Button)sender;
            int wireNum = (int)input.Tag;
            wireInput[wireNum, BLUE] = !wireInput[wireNum, BLUE];
            Evaluation();
            UpdateDisplay();
        }

        private void InputStar(object sender, EventArgs e)
        {
            Button input = (Button)sender;
            int wireNum = (int)input.Tag;
            wireInput[wireNum, STAR] = !wireInput[wireNum, STAR];
            Evaluation();
            UpdateDisplay();
        }
        #endregion

        #region Info Panel
        private void btnSerialOdd_Click(object sender, EventArgs e)
        {
            serial = FALSE;
            btnSerialOdd.Enabled = false;
            btnSerialEven.Enabled = true;
            Evaluation();
            UpdateDisplay();
        }

        private void btnSerialEven_Click(object sender, EventArgs e)
        {
            serial = TRUE;
            btnSerialOdd.Enabled = true;
            btnSerialEven.Enabled = false;
            Evaluation();
            UpdateDisplay();
        }

        private void btnParallelFalse_Click(object sender, EventArgs e)
        {
            parallel = FALSE;
            btnParallelFalse.Enabled = false;
            btnParallelTrue.Enabled = true;
            Evaluation();
            UpdateDisplay();
        }

        private void btnParallelTrue_Click(object sender, EventArgs e)
        {
            parallel = TRUE;
            btnParallelFalse.Enabled = true;
            btnParallelTrue.Enabled = false;
            Evaluation();
            UpdateDisplay();
        }

        private void btnBatteriesLess_Click(object sender, EventArgs e)
        {
            battery = FALSE;
            btnBatteriesLess.Enabled = false;
            btnBatteriesMore.Enabled = true;
            Evaluation();
            UpdateDisplay();
        }

        private void btnBatteriesMore_Click(object sender, EventArgs e)
        {
            battery = TRUE;
            btnBatteriesLess.Enabled = true;
            btnBatteriesMore.Enabled = false;
            Evaluation();
            UpdateDisplay();
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            //perform magic
            
            //hide all info panels
            ShowInfoPanel(SERIAL, false);
            ShowInfoPanel(PARALLEL, false);
            ShowInfoPanel(BATTERY, false);
            //check each wire
            for (int wire = 0; wire < NUM_WIRES; wire++)
            {
                //check each property combination
                for (int i = 0; i < 16; i++)
                {
                    int sameProperties = 0;
                    for (int prop = 0; prop < NUM_WIRE_PROPERTIES; prop++)
                    {
                        if (wireInput[wire, prop] == data[prop][i])
                        {
                            sameProperties++;
                        }
                    }

                    if (sameProperties == NUM_WIRE_PROPERTIES)
                    {
                        //then this is the wire result we are looking for
                        wireResult[wire] = dataResult[i];

                        //desicions based on supplied data
                        
                        //serial
                        if (wireResult[wire] == SERIAL)
                        {
                            ShowInfoPanel(SERIAL, true);
                            if (serial == TRUE)
                            {
                                wireResult[wire] = CUT;
                            }
                            else if (serial == FALSE)
                            {
                                wireResult[wire] = NO_CUT;
                            }
                        }
                        //parallel
                        else if (wireResult[wire] == PARALLEL)
                        {
                            ShowInfoPanel(PARALLEL, true);
                            if (parallel == TRUE)
                            {
                                wireResult[wire] = CUT;
                            }
                            else if (parallel == FALSE)
                            {
                                wireResult[wire] = NO_CUT;
                            }
                        }
                        //battery
                        else if (wireResult[wire] == BATTERY)
                        {
                            ShowInfoPanel(BATTERY, true);
                            if (battery == TRUE)
                            {
                                wireResult[wire] = CUT;
                            }
                            else if (battery == FALSE)
                            {
                                wireResult[wire] = NO_CUT;
                            }
                        }

                        i = 16;
                    }
                }
            }
        }

        private void UpdateDisplay()
        {
            //set button colours
            for (int wire = 0; wire < NUM_WIRES; wire++ )
            {
                for (int prop = 0; prop < NUM_WIRE_PROPERTIES; prop++)
                {
                    if (wireInput[wire, prop])
                    {
                        //then the property has been selected, colour the button.
                        switch (prop) {
                            case LED: inputButtons[wire, prop].BackColor = LED_COLOUR;
                                break;
                            case RED: inputButtons[wire, prop].BackColor = RED_COLOUR;
                                break;
                            case BLUE: inputButtons[wire, prop].BackColor = BLUE_COLOUR;
                                inputButtons[wire, prop].ForeColor = Color.White;
                                break;
                            case STAR: inputButtons[wire, prop].BackColor = STAR_COLOUR;
                                break;
                        }
                    }
                    else
                    {
                        inputButtons[wire, prop].BackColor = default(Color);
                        inputButtons[wire, prop].UseVisualStyleBackColor = true;
                        inputButtons[wire, prop].ForeColor = default(Color);
                    }
                }
            }

            //update results display
            lblResult.Text = "";
            for (int wire = 0; wire < NUM_WIRES; wire++)
            {
                switch (wireResult[wire]) {
                    case CUT: resultLabels[wire].Text = "C";
                        break;
                    case NO_CUT: resultLabels[wire].Text = "D";
                        break;
                    case SERIAL: resultLabels[wire].Text = "S";
                        lblResult.Text = "*Check the last digit of the serial number";
                        ShowInfoPanel(SERIAL, true);
                        break;
                    case PARALLEL: resultLabels[wire].Text = "P";
                        lblResult.Text = "*Check for a parallel port";
                        ShowInfoPanel(PARALLEL, true);
                        break;
                    case BATTERY: resultLabels[wire].Text = "B";
                        lblResult.Text = "*Check the amount of batteries on the bomb";
                        ShowInfoPanel(BATTERY, true);
                        break;

                }
            }
        }

        private void ShowInfoPanel(int section, bool visible)
        {
            switch (section)
            {
                case SERIAL: groupSerial.Visible = visible;
                    break;
                case PARALLEL: groupParallel.Visible = visible;
                    break;
                case BATTERY: groupBatteries.Visible = visible;
                    break;
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
            serial = NOT_SET;
            parallel = NOT_SET;
            battery = NOT_SET;

            //initialise wire input to false
            for (int x = 0; x < NUM_WIRES; x++)
            {
                for (int y = 0; y < NUM_WIRE_PROPERTIES; y++)
                {
                    wireInput[x, y] = false;
                }
                wireResult[x] = CUT;
            }

            Evaluation();
            UpdateDisplay();
            EnableInfoPanelButtons(true);
            ShowInfoPanel(SERIAL, false);
            ShowInfoPanel(PARALLEL, false);
            ShowInfoPanel(BATTERY, false);
            
        }

        private void EnableInfoPanelButtons(bool enable)
        {
            btnSerialEven.Enabled = enable;
            btnSerialOdd.Enabled = enable;
            btnParallelFalse.Enabled = enable;
            btnParallelTrue.Enabled = enable;
            btnBatteriesLess.Enabled = enable;
            btnBatteriesMore.Enabled = enable;
        }
        #endregion

    }
}
