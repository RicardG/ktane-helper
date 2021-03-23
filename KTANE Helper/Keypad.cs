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
    public partial class Keypad : Form
    {
        public Keypad()
        {
            InitializeComponent();
            CreatePicBoxes();
            SetupPictureColumns();
        }

        #region Globals
        //globals
        PictureBox[] symbols = new PictureBox[27];
        PictureBox[] result = new PictureBox[4];

        Point initialLocation = new Point(6, 19);
        const int spacing = 70;
        Color selectColour = Color.Red;
        Color baseColour = SystemColors.Control;

        int[,] symbolList = new int[6, 7];
        List<int> selectedSymbols = new List<int>();

        int symbolColumn = -1;
        #endregion

        #region Initialisation
        private void CreatePicBoxes()
        {
            //create picboxes
            int i = 0;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (y == 4 && x < 2)
                    {
                        x = 2;
                    }
                    //set picbox properties
                    symbols[i] = new PictureBox();
                    symbols[i].SizeMode = PictureBoxSizeMode.Zoom;
                    symbols[i].Image = KeypadImages.Images[i];
                    symbols[i].BorderStyle = BorderStyle.FixedSingle;
                    symbols[i].Size = new Size(66, 66);
                    symbols[i].Click += SelectSymbol;
                    symbols[i].Tag = i;
                    groupSymbols.Controls.Add(symbols[i]);
                    symbols[i].Location = new Point(initialLocation.X + spacing * x, initialLocation.Y + spacing * y);
                    i++;

                    if (y == 4 && x >= 4)
                    {
                        x = 5;
                    }
                }
            }

            //add result picboxes
            result[0] = picResult1;
            result[1] = picResult2;
            result[2] = picResult3;
            result[3] = picResult4;
        }

        private void SetupPictureColumns()
        {
            //first column
            symbolList[0, 0] = 1; //balloon
            symbolList[0, 1] = 6; //'AT'
            symbolList[0, 2] = 8; //Lamda
            symbolList[0, 3] = 0; //lightning
            symbolList[0, 4] = 12; //alien
            symbolList[0, 5] = 7; //'h'
            symbolList[0, 6] = 2; //reverse c.

            //second column
            symbolList[1, 0] = 4; //euro
            symbolList[1, 1] = 1; //balloon
            symbolList[1, 2] = 2; //reverse c.
            symbolList[1, 3] = 9; //swirly
            symbolList[1, 4] = 3; //hollow star
            symbolList[1, 5] = 7; //'h'
            symbolList[1, 6] = 13; //upside down ?

            //third column
            symbolList[2, 0] = 16; //copyright
            symbolList[2, 1] = 15; //pumpkin
            symbolList[2, 2] = 9; //swirly
            symbolList[2, 3] = 14; //I 6legs
            symbolList[2, 4] = 10; //'R'
            symbolList[2, 5] = 8; //lambda
            symbolList[2, 6] = 3; //hollow star

            //fourth column
            symbolList[3, 0] = 21; //'6'
            symbolList[3, 1] = 18; //paragraph
            symbolList[3, 2] = 20; //bT
            symbolList[3, 3] = 12; //alien
            symbolList[3, 4] = 14; //I 6legs
            symbolList[3, 5] = 13; //upside down ?
            symbolList[3, 6] = 19; //smiley

            //fifth column
            symbolList[4, 0] = 22; //fork
            symbolList[4, 1] = 19; //smiley
            symbolList[4, 2] = 20; //bT
            symbolList[4, 3] = 24; //c.
            symbolList[4, 4] = 18; //paragraph
            symbolList[4, 5] = 25; //snake
            symbolList[4, 6] = 26; //filled star

            //sixth column
            symbolList[5, 0] = 21; //'6'
            symbolList[5, 1] = 4; //euro
            symbolList[5, 2] = 17; //dumbell
            symbolList[5, 3] = 5; //'ae'
            symbolList[5, 4] = 22; //fork
            symbolList[5, 5] = 11; //'N'
            symbolList[5, 6] = 23; //omega
        }
        #endregion

        #region Input
        private void SelectSymbol(object sender, EventArgs e)
        {
            PictureBox input = (PictureBox)sender;

            if (input.BackColor == baseColour) //not selected
            {
                if (selectedSymbols.Count() < 4) //if another symbol can be selected
                {
                    selectedSymbols.Add((int)input.Tag);
                    input.BackColor = selectColour;
                }
            }
            else if (input.BackColor == selectColour) //selected
            {
                selectedSymbols.Remove((int)input.Tag);
                input.BackColor = baseColour;
            }
            UpdateDisplay();
            Evaluation();
        }

        private void UpdateDisplay()
        {
            groupSymbols.Text = "Select Symbols - " + selectedSymbols.Count() + " out of 4"; //update selected counter

            if (selectedSymbols.Count() == 0)
            {
                DisplayPicBox(true);
            }
            else
            {
                List<int> checkList = new List<int>(); //copy selected list


                DisplayPicBox(false);
                for (int x = 0; x < symbolList.GetLength(0); x++) //find symbol lists with all selected symbols and display them
                {
                    checkList = CopyList(selectedSymbols); //re copy list
                    for (int y = 0; y < symbolList.GetLength(1); y++)
                    {
                        if (checkList.Contains(symbolList[x, y]))
                        {
                            checkList.Remove(symbolList[x, y]); //remove item as it exists

                            if (checkList.Count == 0) //if all items were found
                            {//show picboxes in symbol list
                                for (int i = 0; i < symbolList.GetLength(1); i++)
                                {
                                    symbols[symbolList[x, i]].Visible = true;
                                }

                                if (selectedSymbols.Count() == 4) //all symbols selected
                                {
                                    symbolColumn = x;
                                }
                            }
                        }
                    }
                }
            }
        }

        private List<int> CopyList(List<int> originalList)
        {
            List<int> copy = new List<int>();
            for (int i = 0; i < originalList.Count(); i++) //copy all elements from original to copy
            {
                copy.Add(originalList[i]);
            }

            return copy;
        }

        private void DisplayPicBox(bool visible)
        { //display or hide all
            for (int i = 0; i < symbols.Count(); i++)
            {
                symbols[i].Visible = visible;
            }
        }
        #endregion

        #region Reset
        private void ResetModule()
        {
            for (int i = 0; i < symbols.Count(); i++) //uncolour everything
            {
                symbols[i].BackColor = baseColour;
            }
            selectedSymbols.Clear();
            UpdateDisplay();
            ResetResultPic();

            symbolColumn = -1; //error checking
            lblWaiting.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }

        private void ResetResultPic()
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i].Image = null;
            }
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            if (selectedSymbols.Count() == 4) //all symbols selected
            {
                if (symbolColumn != -1)
                {
                    lblWaiting.Visible = false;
                    int symbolsAdded = 0;
                    for (int y = 0; y < symbolList.GetLength(1); y++)
                    {
                        if (selectedSymbols.Contains(symbolList[symbolColumn, y]))
                        {
                            result[symbolsAdded].Image = KeypadImages.Images[symbolList[symbolColumn, y]];
                            symbolsAdded++;
                        }
                    }
                }
            }
            else
            {
                ResetResultPic();
                lblWaiting.Visible = true;
            }
        }


        #endregion
    }
}
