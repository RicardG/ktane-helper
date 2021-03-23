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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            Initialisation();
            Reset();
        }

        #region Globals
        //constants
        const int NO_DATA = -1;
        const int NUM_COLS = 5;
        const int CHARS_PER_COL = 6;
        const int NUM_WORDS = 35;
        string[] PASSWORDS = Properties.Resources.Passwords.Split(' ');
        //globals vars
        TextBox[] InputBox = new TextBox[5];
        #endregion

        #region Initialasation
        private void Initialisation()
        {
            InputBox[0] = txtCol1;
            InputBox[1] = txtCol2;
            InputBox[2] = txtCol3;
            InputBox[3] = txtCol4;
            InputBox[4] = txtCol5;
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            bool valid = true;
            int invalidCol = NO_DATA;
            int validcols = 0;

            //check columns only have characters in them
            for (int i = 0; i < NUM_COLS; i++)
            {
                int length = InputBox[i].Text.Length;
                for (int j = 0; j < length; j++)
                {
                    if (InputBox[i].Text[j] < 'A' || InputBox[i].Text[j] > 'Z')
                    {
                        //invalid character
                        valid = false;
                        invalidCol = i + 1;
                        break;
                    }
                }
                if (!valid)
                {
                    break;
                }
            }

            if (!valid)
            {
                lblResult.Text = "Column " + invalidCol + " is invalid.\n(Only letters allowed)";
            }
            else
            {

                //check columns with text in them
                for (int i = 0; i < NUM_COLS; i++)
                {
                    if (InputBox[i].Text.Length < CHARS_PER_COL && InputBox[i].Text.Length != 0)
                    {
                        //a column is incomplete
                        valid = false;
                        invalidCol = i + 1;
                        break;
                    }
                    else if (InputBox[i].Text.Length != 0)
                    {
                        validcols++;
                    }
                }

                if (!valid)
                {
                    lblResult.Text = "Column " + invalidCol + " is incomplete.\n(Must contain 6 chars)";
                }
                else if (validcols == 0)
                {
                    lblResult.Text = "Waiting for input";
                }
                else
                {
                    //process an answer
                    int[] wordScore = new int[NUM_WORDS];

                    //score each word
                    for (int word = 0; word < NUM_WORDS; word++) //for each word
                    {
                        for (int col = 0; col < NUM_COLS; col++) //for each column
                        {
                            if (InputBox[col].Text.Length == CHARS_PER_COL)
                            for (int let = 0; let < CHARS_PER_COL; let++) //for each letter in the column
                            {
                                if (PASSWORDS[word].ToUpper()[col] == InputBox[col].Text.ToUpper()[let])
                                {
                                    wordScore[word]++;
                                }
                            }
                        }
                    }

                    //find word with largest score
                    int bestWord = 0;
                    int wordCount = 0;
                    for (int i = 0; i < NUM_WORDS; i++)
                    {
                        if (wordScore[i] > wordScore[bestWord])
                        {
                            bestWord = i;
                            wordCount = 1;
                        }
                        else if (wordScore[i] == wordScore[bestWord])
                        {
                            wordCount++;
                        }
                    }

                    if (wordCount == 1)
                    {
                        lblResult.Text = "The word is " + PASSWORDS[bestWord].ToUpper();
                    }
                    else
                    {
                        lblResult.Text = "More data required\nPossible words: " + wordCount;
                    }
                }
            }
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            Evaluation();
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int i = 0; i < NUM_COLS; i++)
            {
                InputBox[i].Text = "";
            }
            Evaluation();
        }
        #endregion
    }
}
