namespace KTANE_Helper
{
    partial class The_Button
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
            this.btnDetonate = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.GroupBox();
            this.btnPress = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.groupColour = new System.Windows.Forms.GroupBox();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.groupBatteries = new System.Windows.Forms.GroupBox();
            this.btnBatMore = new System.Windows.Forms.Button();
            this.btnBatLess = new System.Windows.Forms.Button();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupLabel.SuspendLayout();
            this.groupColour.SuspendLayout();
            this.groupBatteries.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetonate
            // 
            this.btnDetonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetonate.Location = new System.Drawing.Point(112, 19);
            this.btnDetonate.Name = "btnDetonate";
            this.btnDetonate.Size = new System.Drawing.Size(100, 50);
            this.btnDetonate.TabIndex = 0;
            this.btnDetonate.TabStop = false;
            this.btnDetonate.Tag = "1";
            this.btnDetonate.Text = "Detonate";
            this.btnDetonate.UseVisualStyleBackColor = true;
            this.btnDetonate.Click += new System.EventHandler(this.LabelInput);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(6, 19);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 50);
            this.btnRed.TabIndex = 1;
            this.btnRed.TabStop = false;
            this.btnRed.Tag = "0";
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.ColourInput);
            // 
            // groupLabel
            // 
            this.groupLabel.Controls.Add(this.btnPress);
            this.groupLabel.Controls.Add(this.btnHold);
            this.groupLabel.Controls.Add(this.btnAbort);
            this.groupLabel.Controls.Add(this.btnDetonate);
            this.groupLabel.Location = new System.Drawing.Point(12, 12);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(218, 131);
            this.groupLabel.TabIndex = 2;
            this.groupLabel.TabStop = false;
            this.groupLabel.Text = "Button Label";
            // 
            // btnPress
            // 
            this.btnPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPress.Location = new System.Drawing.Point(112, 75);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(100, 50);
            this.btnPress.TabIndex = 0;
            this.btnPress.TabStop = false;
            this.btnPress.Tag = "3";
            this.btnPress.Text = "Press";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.LabelInput);
            // 
            // btnHold
            // 
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Location = new System.Drawing.Point(6, 75);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(100, 50);
            this.btnHold.TabIndex = 0;
            this.btnHold.TabStop = false;
            this.btnHold.Tag = "2";
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.LabelInput);
            // 
            // btnAbort
            // 
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.Location = new System.Drawing.Point(6, 19);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(100, 50);
            this.btnAbort.TabIndex = 0;
            this.btnAbort.TabStop = false;
            this.btnAbort.Tag = "0";
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.LabelInput);
            // 
            // groupColour
            // 
            this.groupColour.Controls.Add(this.btnWhite);
            this.groupColour.Controls.Add(this.btnYellow);
            this.groupColour.Controls.Add(this.btnBlue);
            this.groupColour.Controls.Add(this.btnRed);
            this.groupColour.Location = new System.Drawing.Point(236, 12);
            this.groupColour.Name = "groupColour";
            this.groupColour.Size = new System.Drawing.Size(168, 131);
            this.groupColour.TabIndex = 2;
            this.groupColour.TabStop = false;
            this.groupColour.Text = "Button Colour";
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.Location = new System.Drawing.Point(87, 75);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 50);
            this.btnWhite.TabIndex = 1;
            this.btnWhite.TabStop = false;
            this.btnWhite.Tag = "3";
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.ColourInput);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.Location = new System.Drawing.Point(6, 75);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 50);
            this.btnYellow.TabIndex = 1;
            this.btnYellow.TabStop = false;
            this.btnYellow.Tag = "2";
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.ColourInput);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlue.Location = new System.Drawing.Point(87, 19);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 50);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.TabStop = false;
            this.btnBlue.Tag = "1";
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.ColourInput);
            // 
            // groupBatteries
            // 
            this.groupBatteries.Controls.Add(this.btnBatLess);
            this.groupBatteries.Controls.Add(this.btnBatMore);
            this.groupBatteries.Location = new System.Drawing.Point(236, 12);
            this.groupBatteries.Name = "groupBatteries";
            this.groupBatteries.Size = new System.Drawing.Size(168, 131);
            this.groupBatteries.TabIndex = 6;
            this.groupBatteries.TabStop = false;
            this.groupBatteries.Text = "Batteries";
            // 
            // btnBatMore
            // 
            this.btnBatMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatMore.Location = new System.Drawing.Point(87, 19);
            this.btnBatMore.Name = "btnBatMore";
            this.btnBatMore.Size = new System.Drawing.Size(75, 106);
            this.btnBatMore.TabIndex = 5;
            this.btnBatMore.TabStop = false;
            this.btnBatMore.Text = "2+ Batteries";
            this.btnBatMore.UseVisualStyleBackColor = true;
            this.btnBatMore.Click += new System.EventHandler(this.btnBatMore_Click);
            // 
            // btnBatLess
            // 
            this.btnBatLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatLess.Location = new System.Drawing.Point(6, 19);
            this.btnBatLess.Name = "btnBatLess";
            this.btnBatLess.Size = new System.Drawing.Size(75, 106);
            this.btnBatLess.TabIndex = 5;
            this.btnBatLess.TabStop = false;
            this.btnBatLess.Text = "<2 Batteries";
            this.btnBatLess.UseVisualStyleBackColor = true;
            this.btnBatLess.Click += new System.EventHandler(this.btnBatLess_Click);
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblResult);
            this.groupResult.Location = new System.Drawing.Point(12, 149);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(392, 70);
            this.groupResult.TabIndex = 3;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(6, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(169, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Waiting for all input.";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(392, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // The_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 260);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupBatteries);
            this.Controls.Add(this.groupColour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "The_Button";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "The Button";
            this.groupLabel.ResumeLayout(false);
            this.groupColour.ResumeLayout(false);
            this.groupBatteries.ResumeLayout(false);
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetonate;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.GroupBox groupLabel;
        private System.Windows.Forms.GroupBox groupColour;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBatLess;
        private System.Windows.Forms.GroupBox groupBatteries;
        private System.Windows.Forms.Button btnBatMore;
    }
}