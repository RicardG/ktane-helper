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
    public partial class MorseCode : Form
    {
        public MorseCode()
        {
            InitializeComponent();
            Initialisation();
            ResetModule();
        }

        #region Globals
        const int ALPHA_LENGTH = 26;
        const int WORD_COUNT = 16;
        const int WORD = 0;
        const int FREQUENCY = 1;
        string[] morseCode;// = new string[ALPHA_LENGTH];
        string[] words;
        string[] frequencies;
        string rawInput;
        string rawText;
        string bestGuess;
        
        //string[,] possibleWords = new string[WORD_COUNT,2];
        #endregion

        #region Initialisation
        private void Initialisation()
        {
            morseCode = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            words = new string[] { "SHELL", "HALLS", "SLICK", "TRICK", "BOXES", "LEAKS", "STROBE", "BISTRO", "FLICK", "BOMBS", "BREAK", "BRICK", "STEAK", "STING", "VECTOR", "BEATS" };
            frequencies = new string[] { "3.505", "3.515", "3.522", "3.532", "3.535", "3.542", "3.545", "3.552", "3.555", "3.565", "3.572", "3.575", "3.582", "3.592", "3.595", "3.600" };

            //testing
            /*
            string temp = "";
            char curr = 'A';
            for (int i = 0; i < ALPHA_LENGTH; i++)
            {
                temp += curr + " = " + morseCode[i] + "\n";
                curr++;
            }
            MessageBox.Show(temp);
             * */
        }
        #endregion

        #region Input
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            InsertCharacter('\0');
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            InsertCharacter(' ');
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            InsertCharacter('-');
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            InsertCharacter('.');
        }

        private void InsertCharacter(char character)
        {
            if (character == '\0')
            {
                if (rawInput.Length > 0)
                {
                    rawInput = rawInput.Remove(rawInput.Length - 1, 1);
                }
            }
            else
            {
                rawInput += character;
            }
            Evaluation();
            UpdateDisplay();
        }
        #endregion

        #region Evaluation
        private void Evaluation()
        {
            rawText = "";
            string[] morseCodeWord = rawInput.Split(' ');
            int length = morseCodeWord.Length;
            for (int i = 0; i < length; i++)
            {
                rawText += MorseToChar(morseCodeWord[i]);
            }

            //determine closest matching word
            //check how many characters of each word match
            int[] correctLetters = new int[WORD_COUNT];
            for (int i = 0; i < WORD_COUNT; i++)
            {
                correctLetters[i] = 0;
            }

            //for each word, compare each letter
            for (int i = 0; i < WORD_COUNT; i++)
            {
                int wordLength = words[i].Length;
                for (int j = 0; j < wordLength && j < length; j++)
                {
                    if (words[i][j] == rawText[j])
                    {
                        correctLetters[i] += 1;
                    }
                    correctLetters[i] += 1; //this should prioritise longer words over shorter ones
                }
            }
            int maxPosition = 0;
            bool duplicate = false;
            //find maximum value
            for (int i = 1; i < WORD_COUNT; i++)
            {
                if (correctLetters[i] > correctLetters[maxPosition])
                {
                    maxPosition = i;
                    duplicate = false;
                }
                else if (correctLetters[i] == correctLetters[maxPosition])
                {
                    duplicate = true;
                }
            }

            if (duplicate == false)
            {
                bestGuess = words[maxPosition];
                lblResult.Text = "Respond with " + frequencies[maxPosition] + "MHz";
            }
            else
            {
                bestGuess = "???";
                lblResult.Text = "Waiting for all input.";
            }
        }

        private char MorseToChar(string morseLetter)
        {
            int i = 0;
            char result = '?';
            for (i = 0; i < ALPHA_LENGTH; i++) {
                if (morseLetter == morseCode[i])
                {
                    break;
                }
            }
            if (i != ALPHA_LENGTH)
            {
                result = (char)('A' + i);
            }
            return result;
        }

        private void UpdateDisplay()
        {
            txtRawInput.Text = "";

            //int i = 0;
            int length = rawInput.Length;
            if (length > 0)
            {
                for (int i = 0; i < length; i++ )
                {
                    if (rawInput[i] == ' ')
                    {
                        txtRawInput.Text += "|";
                    }
                    else
                    {
                        txtRawInput.Text += rawInput[i];
                    }
                }
            }

            txtRawText.Text = rawText;
            txtBestGuess.Text = bestGuess;
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }

        private void ResetModule()
        {
            rawInput = "";
            rawText = "";
            bestGuess = "";
            UpdateDisplay();
            Evaluation();
            lblResult.Text = "Waiting for all input.";
        }
        #endregion
    }
}
