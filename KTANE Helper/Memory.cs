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
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();

            //set button tags
            btnDisplay1.Tag = btnExtra1.Tag = 1;
            btnDisplay2.Tag = btnExtra2.Tag = 2;
            btnDisplay3.Tag = btnExtra3.Tag = 3;
            btnDisplay4.Tag = btnExtra4.Tag = 4;

            ResetModule();
        }

        #region Globals
        int[] position = new int[NUM_STAGES];
        int[] label = new int[NUM_STAGES];
        int currentStage = 0;
        bool extraInfoPos = false; //true = pos, false = label

        const int NO_DATA = -1;
        const int NUM_STAGES = 5;
        #endregion

        #region Input
        private void DisplayNumberInput(object sender, EventArgs e)
        {
            Button input = (Button)sender;
            EnableDisplayInputButtons(true);
            input.Enabled = false;
            EnableExtraInputButtons(true);
            DisplayNumEvaluation((int)input.Tag);
            //you may only progress to the next stage if a display number has been inputted
            if (currentStage != NUM_STAGES - 1)
            {
                btnNextStage.Enabled = true;
            }
        }

        private void ExtraInput(object sender, EventArgs e)
        {
            Button input = (Button)sender;
            EnableExtraInputButtons(true);
            input.Enabled = false;
            ExtraInfoEvaluation((int)input.Tag);
        }
        
        private void EnableDisplayInputButtons(bool enable)
        {
            btnDisplay1.Enabled = enable;
            btnDisplay2.Enabled = enable;
            btnDisplay3.Enabled = enable;
            btnDisplay4.Enabled = enable;
        }

        private void EnableExtraInputButtons(bool enable)
        {
            btnExtra1.Enabled = enable;
            btnExtra2.Enabled = enable;
            btnExtra3.Enabled = enable;
            btnExtra4.Enabled = enable;
        }

        private void btnNextStage_Click(object sender, EventArgs e)
        {
            EnableDisplayInputButtons(true);
            EnableExtraInputButtons(false);
            currentStage++;
            //disable progressing to the next stage when the last stage is reached
            if (currentStage == NUM_STAGES - 1)
            {
                btnNextStage.Enabled = false;
            }
            btnNextStage.Enabled = false;
            UpdateInputLists();
            lblResult.Text = "Waiting for all input.";
            groupDisplayInput.Text = "Display Number - Stage " + (currentStage + 1).ToString();
            groupExtra.Text = "Extra Information (Optional)";
        }
        #endregion

        #region Evaluation
        private void DisplayNumEvaluation(int displayNum)
        {
            //reset current stage data
            position[currentStage] = NO_DATA;
            label[currentStage] = NO_DATA;
            bool positionUpdate = false;
            bool labelUpdate = false;
            int stageRelation = NO_DATA;

            switch (currentStage)
            {
                case 0:
                    switch (displayNum)
                    {
                        case 1:
                            position[currentStage] = 2;
                            positionUpdate = true;
                            break;

                        case 2:
                            position[currentStage] = 2;
                            positionUpdate = true;
                            break;

                        case 3:
                            position[currentStage] = 3;
                            positionUpdate = true;
                            break;

                        case 4:
                            position[currentStage] = 4;
                            positionUpdate = true;
                            break;
                    }
                    break;

                case 1:
                    switch (displayNum)
                    {
                        case 1:
                            label[currentStage] = 4;
                            labelUpdate = true;
                            break;

                        case 2:
                            position[currentStage] = position[0];
                            positionUpdate = true;
                            stageRelation = 1;
                            break;

                        case 3:
                            position[currentStage] = 1;
                            positionUpdate = true;
                            break;

                        case 4:
                            position[currentStage] = position[0];
                            positionUpdate = true;
                            stageRelation = 1;
                            break;
                    }
                    break;

                case 2:
                    switch (displayNum)
                    {
                        case 1:
                            label[currentStage] = label[1];
                            labelUpdate = true;
                            stageRelation = 2;
                            break;

                        case 2:
                            label[currentStage] = label[0];
                            labelUpdate = true;
                            stageRelation = 1;
                            break;

                        case 3:
                            position[currentStage] = 3;
                            positionUpdate = true;
                            break;

                        case 4:
                            label[currentStage] = 4;
                            labelUpdate = true;
                            break;
                    }
                    break;

                case 3:
                    switch (displayNum)
                    {
                        case 1:
                            position[currentStage] = position[0];
                            positionUpdate = true;
                            stageRelation = 1;
                            break;

                        case 2:
                            position[currentStage] = 1;
                            positionUpdate = true;
                            break;

                        case 3:
                            position[currentStage] = position[1];
                            positionUpdate = true;
                            stageRelation = 2;
                            break;

                        case 4:
                            position[currentStage] = position[0];
                            positionUpdate = true;
                            stageRelation = 1;
                            break;
                    }
                    break;

                case 4:
                    switch (displayNum)
                    {
                        case 1:
                            label[currentStage] = label[0];
                            labelUpdate = true;
                            stageRelation = 1;
                            break;

                        case 2:
                            label[currentStage] = label[1];
                            labelUpdate = true;
                            stageRelation = 2;
                            break;

                        case 3:
                            label[currentStage] = label[3];
                            labelUpdate = true;
                            stageRelation = 4;
                            break;

                        case 4:
                            label[currentStage] = label[2];
                            labelUpdate = true;
                            stageRelation = 3;
                            break;
                    }
                    break;
            }

            UpdateInputLists();

            //display result
            lblResult.Text = "Stage: " + (currentStage + 1).ToString() + "     Display Num: " + displayNum.ToString() + "\n";
            if (positionUpdate)
            {
                if (position[currentStage] != NO_DATA)
                {
                    lblResult.Text += "Press the button in position " + position[currentStage].ToString();
                }
                else
                {
                    lblResult.Text += "Press the button in position ???";
                }
            }
            else if (labelUpdate)
            {
                if (label[currentStage] != NO_DATA)
                {
                    lblResult.Text += "Press the button labeled \" " + label[currentStage].ToString() + " \"";
                }
                else
                {
                    lblResult.Text += "Press the button labeled ???";
                }
            }

            //if the data was based on data from another stage
            if (stageRelation != NO_DATA)
            {
                lblResult.Text += "\n(Same as in stage " + stageRelation.ToString() + ")";
            }

            //ask the user for extra information
            if (positionUpdate)
            { //extra needs to be label
                extraInfoPos = false;
                groupExtra.Text = "Extra Info - Button Label   (Optional)";
            }
            else if (labelUpdate)
            { //extra needs to be position
                extraInfoPos = true;
                groupExtra.Text = "Extra Info - Button Position   (Optional)";
            }
        }

        private void ExtraInfoEvaluation(int extraNum)
        {
            if (extraInfoPos)
            { //extra info is about the position of the button
                position[currentStage] = extraNum;
            }
            else
            {//extra info is about the label
                label[currentStage] = extraNum;
            }

            UpdateInputLists();
        }

        private void UpdateInputLists()
        {
            listStage.Items.Clear();
            listPosition.Items.Clear();
            listLabel.Items.Clear();

            //create list headings
            //list stage
            listStage.Items.Add("Stage #");
            listStage.Items.Add("=======");
            //list position
            listPosition.Items.Add("Pos");
            listPosition.Items.Add("=====");
            //list button labels
            listLabel.Items.Add("Label");
            listLabel.Items.Add("=====");

            //populate lists
            for (int i = 0; i < NUM_STAGES && i < currentStage + 1; i++)
            {
                listStage.Items.Add("Stage " + (i+1).ToString());
                if (position[i] == NO_DATA)
                {
                    listPosition.Items.Add("  -  ");
                }
                else
                {
                    listPosition.Items.Add(position[i].ToString());
                }
                if (label[i] == NO_DATA)
                {
                    listLabel.Items.Add("  -  ");
                }
                else
                {
                    listLabel.Items.Add(label[i].ToString());
                }
            }
        }
        #endregion

        #region Reset
        private void ResetModule()
        {
            EnableDisplayInputButtons(true);
            EnableExtraInputButtons(false);

            //clear data
            for (int i = 0; i < NUM_STAGES; i++)
            {
                position[i] = NO_DATA;
                label[i] = NO_DATA;
            }

            currentStage = 0;
            UpdateInputLists();

            btnNextStage.Enabled = false;

            lblResult.Text = "Waiting for all input.";
            groupDisplayInput.Text = "Display Number - Stage " + (currentStage + 1).ToString();
            groupExtra.Text = "Extra Information (Optional)";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModule();
        }
        #endregion
    }
}
