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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            Simple_Wires formname = new Simple_Wires();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            The_Button formname = new The_Button();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnKeypad_Click(object sender, EventArgs e)
        {
            Keypad formname = new Keypad();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnSimonSays_Click(object sender, EventArgs e)
        {
            Simon_Says formname = new Simon_Says();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnWhosOnFirst_Click(object sender, EventArgs e)
        {
            Who_s_On_First formname = new Who_s_On_First();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            Memory formname = new Memory();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnMorseCode_Click(object sender, EventArgs e)
        {
            MorseCode formname = new MorseCode();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnComplexWires_Click(object sender, EventArgs e)
        {
            ComplexWires formname = new ComplexWires();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnWireSequence_Click(object sender, EventArgs e)
        {
            WireSequence formname = new WireSequence();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnMaze_Click(object sender, EventArgs e)
        {
            Maze formname = new Maze();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password formname = new Password();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }

        private void btnKnob_Click(object sender, EventArgs e)
        {
            The_Knob formname = new The_Knob();
            formname.StartPosition = FormStartPosition.Manual;
            formname.Location = new Point(this.Location.X + (this.Width - formname.Width) / 2, this.Location.Y + (this.Height - formname.Height) / 2);
            formname.Show();
        }
    }
}
