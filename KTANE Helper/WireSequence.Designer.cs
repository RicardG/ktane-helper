namespace KTANE_Helper
{
    partial class WireSequence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupWireInput = new System.Windows.Forms.GroupBox();
            this.groupLetterInput = new System.Windows.Forms.GroupBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.groupWireColour = new System.Windows.Forms.GroupBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.groupHistory = new System.Windows.Forms.GroupBox();
            this.btnNextWire = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupResult.SuspendLayout();
            this.groupWireInput.SuspendLayout();
            this.groupLetterInput.SuspendLayout();
            this.groupWireColour.SuspendLayout();
            this.groupHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblResult);
            this.groupResult.Location = new System.Drawing.Point(16, 435);
            this.groupResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupResult.Name = "groupResult";
            this.groupResult.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupResult.Size = new System.Drawing.Size(480, 96);
            this.groupResult.TabIndex = 7;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 31);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(335, 37);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Do Not Cut The Wire";
            // 
            // groupWireInput
            // 
            this.groupWireInput.Controls.Add(this.groupLetterInput);
            this.groupWireInput.Controls.Add(this.groupWireColour);
            this.groupWireInput.Location = new System.Drawing.Point(16, 15);
            this.groupWireInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupWireInput.Name = "groupWireInput";
            this.groupWireInput.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupWireInput.Size = new System.Drawing.Size(284, 408);
            this.groupWireInput.TabIndex = 6;
            this.groupWireInput.TabStop = false;
            this.groupWireInput.Text = "Wire Input";
            // 
            // groupLetterInput
            // 
            this.groupLetterInput.Controls.Add(this.btnC);
            this.groupLetterInput.Controls.Add(this.btnB);
            this.groupLetterInput.Controls.Add(this.btnA);
            this.groupLetterInput.Location = new System.Drawing.Point(148, 37);
            this.groupLetterInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupLetterInput.Name = "groupLetterInput";
            this.groupLetterInput.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupLetterInput.Size = new System.Drawing.Size(124, 360);
            this.groupLetterInput.TabIndex = 8;
            this.groupLetterInput.TabStop = false;
            this.groupLetterInput.Text = "Letter";
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(12, 252);
            this.btnC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(100, 96);
            this.btnC.TabIndex = 0;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(12, 144);
            this.btnB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(100, 96);
            this.btnB.TabIndex = 0;
            this.btnB.TabStop = false;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(12, 37);
            this.btnA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(100, 96);
            this.btnA.TabIndex = 0;
            this.btnA.TabStop = false;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // groupWireColour
            // 
            this.groupWireColour.Controls.Add(this.btnBlack);
            this.groupWireColour.Controls.Add(this.btnBlue);
            this.groupWireColour.Controls.Add(this.btnRed);
            this.groupWireColour.Location = new System.Drawing.Point(12, 37);
            this.groupWireColour.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupWireColour.Name = "groupWireColour";
            this.groupWireColour.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupWireColour.Size = new System.Drawing.Size(124, 360);
            this.groupWireColour.TabIndex = 8;
            this.groupWireColour.TabStop = false;
            this.groupWireColour.Text = "Colour";
            // 
            // btnBlack
            // 
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.Location = new System.Drawing.Point(12, 252);
            this.btnBlack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(100, 96);
            this.btnBlack.TabIndex = 0;
            this.btnBlack.TabStop = false;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBlue.Location = new System.Drawing.Point(12, 144);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(100, 96);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.TabStop = false;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(12, 37);
            this.btnRed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(100, 96);
            this.btnRed.TabIndex = 0;
            this.btnRed.TabStop = false;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 25;
            this.listHistory.Items.AddRange(new object[] {
            "01)  Black -> A"});
            this.listHistory.Location = new System.Drawing.Point(12, 37);
            this.listHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(160, 279);
            this.listHistory.TabIndex = 9;
            // 
            // groupHistory
            // 
            this.groupHistory.Controls.Add(this.listHistory);
            this.groupHistory.Location = new System.Drawing.Point(312, 15);
            this.groupHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupHistory.Name = "groupHistory";
            this.groupHistory.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupHistory.Size = new System.Drawing.Size(184, 327);
            this.groupHistory.TabIndex = 9;
            this.groupHistory.TabStop = false;
            this.groupHistory.Text = "Wire History";
            // 
            // btnNextWire
            // 
            this.btnNextWire.Location = new System.Drawing.Point(312, 354);
            this.btnNextWire.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNextWire.Name = "btnNextWire";
            this.btnNextWire.Size = new System.Drawing.Size(184, 69);
            this.btnNextWire.TabIndex = 8;
            this.btnNextWire.Text = "Next Wire";
            this.btnNextWire.UseVisualStyleBackColor = true;
            this.btnNextWire.Click += new System.EventHandler(this.btnNextWire_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 542);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(480, 44);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // WireSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 602);
            this.Controls.Add(this.groupHistory);
            this.Controls.Add(this.btnNextWire);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupWireInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "WireSequence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wire Sequence";
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.groupWireInput.ResumeLayout(false);
            this.groupLetterInput.ResumeLayout(false);
            this.groupWireColour.ResumeLayout(false);
            this.groupHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupWireInput;
        private System.Windows.Forms.GroupBox groupLetterInput;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.GroupBox groupWireColour;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.GroupBox groupHistory;
        private System.Windows.Forms.Button btnNextWire;
        private System.Windows.Forms.Button btnReset;
    }
}