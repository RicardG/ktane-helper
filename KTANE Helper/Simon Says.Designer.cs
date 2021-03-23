namespace KTANE_Helper
{
    partial class Simon_Says
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
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.groupColourInput = new System.Windows.Forms.GroupBox();
            this.groupStrike = new System.Windows.Forms.GroupBox();
            this.btn2Strike = new System.Windows.Forms.Button();
            this.btn1Strike = new System.Windows.Forms.Button();
            this.btn0Strike = new System.Windows.Forms.Button();
            this.groupSerial = new System.Windows.Forms.GroupBox();
            this.btnVowel = new System.Windows.Forms.Button();
            this.btnNoVowel = new System.Windows.Forms.Button();
            this.listInputColours = new System.Windows.Forms.ListBox();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picResult8 = new System.Windows.Forms.PictureBox();
            this.picResult7 = new System.Windows.Forms.PictureBox();
            this.picResult6 = new System.Windows.Forms.PictureBox();
            this.picResult5 = new System.Windows.Forms.PictureBox();
            this.picResult4 = new System.Windows.Forms.PictureBox();
            this.picResult3 = new System.Windows.Forms.PictureBox();
            this.picResult2 = new System.Windows.Forms.PictureBox();
            this.picResult1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupColourInput.SuspendLayout();
            this.groupStrike.SuspendLayout();
            this.groupSerial.SuspendLayout();
            this.groupResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlue.Location = new System.Drawing.Point(71, 19);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(65, 65);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.TabStop = false;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.ColourInput);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(6, 84);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(65, 65);
            this.btnRed.TabIndex = 0;
            this.btnRed.TabStop = false;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.ColourInput);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.Location = new System.Drawing.Point(71, 149);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(65, 65);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.TabStop = false;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.ColourInput);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.Location = new System.Drawing.Point(136, 84);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(65, 65);
            this.btnYellow.TabIndex = 0;
            this.btnYellow.TabStop = false;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.ColourInput);
            // 
            // groupColourInput
            // 
            this.groupColourInput.Controls.Add(this.btnGreen);
            this.groupColourInput.Controls.Add(this.btnBlue);
            this.groupColourInput.Controls.Add(this.btnYellow);
            this.groupColourInput.Controls.Add(this.btnRed);
            this.groupColourInput.Location = new System.Drawing.Point(12, 93);
            this.groupColourInput.Name = "groupColourInput";
            this.groupColourInput.Size = new System.Drawing.Size(207, 220);
            this.groupColourInput.TabIndex = 1;
            this.groupColourInput.TabStop = false;
            this.groupColourInput.Text = "Colour Input";
            // 
            // groupStrike
            // 
            this.groupStrike.Controls.Add(this.btn2Strike);
            this.groupStrike.Controls.Add(this.btn1Strike);
            this.groupStrike.Controls.Add(this.btn0Strike);
            this.groupStrike.Location = new System.Drawing.Point(12, 12);
            this.groupStrike.Name = "groupStrike";
            this.groupStrike.Size = new System.Drawing.Size(174, 75);
            this.groupStrike.TabIndex = 3;
            this.groupStrike.TabStop = false;
            this.groupStrike.Text = "Strikes";
            // 
            // btn2Strike
            // 
            this.btn2Strike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Strike.Location = new System.Drawing.Point(118, 19);
            this.btn2Strike.Name = "btn2Strike";
            this.btn2Strike.Size = new System.Drawing.Size(50, 50);
            this.btn2Strike.TabIndex = 0;
            this.btn2Strike.TabStop = false;
            this.btn2Strike.Text = "2";
            this.btn2Strike.UseVisualStyleBackColor = true;
            this.btn2Strike.Click += new System.EventHandler(this.StrikeInput);
            // 
            // btn1Strike
            // 
            this.btn1Strike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Strike.Location = new System.Drawing.Point(62, 19);
            this.btn1Strike.Name = "btn1Strike";
            this.btn1Strike.Size = new System.Drawing.Size(50, 50);
            this.btn1Strike.TabIndex = 0;
            this.btn1Strike.TabStop = false;
            this.btn1Strike.Text = "1";
            this.btn1Strike.UseVisualStyleBackColor = true;
            this.btn1Strike.Click += new System.EventHandler(this.StrikeInput);
            // 
            // btn0Strike
            // 
            this.btn0Strike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0Strike.Location = new System.Drawing.Point(6, 19);
            this.btn0Strike.Name = "btn0Strike";
            this.btn0Strike.Size = new System.Drawing.Size(50, 50);
            this.btn0Strike.TabIndex = 0;
            this.btn0Strike.TabStop = false;
            this.btn0Strike.Text = "0";
            this.btn0Strike.UseVisualStyleBackColor = true;
            this.btn0Strike.Click += new System.EventHandler(this.StrikeInput);
            // 
            // groupSerial
            // 
            this.groupSerial.Controls.Add(this.btnVowel);
            this.groupSerial.Controls.Add(this.btnNoVowel);
            this.groupSerial.Location = new System.Drawing.Point(192, 12);
            this.groupSerial.Name = "groupSerial";
            this.groupSerial.Size = new System.Drawing.Size(118, 75);
            this.groupSerial.TabIndex = 4;
            this.groupSerial.TabStop = false;
            this.groupSerial.Text = "Serial Number";
            // 
            // btnVowel
            // 
            this.btnVowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVowel.Location = new System.Drawing.Point(6, 19);
            this.btnVowel.Name = "btnVowel";
            this.btnVowel.Size = new System.Drawing.Size(50, 50);
            this.btnVowel.TabIndex = 0;
            this.btnVowel.TabStop = false;
            this.btnVowel.Text = "Vowel";
            this.btnVowel.UseVisualStyleBackColor = true;
            this.btnVowel.Click += new System.EventHandler(this.VowelInput);
            // 
            // btnNoVowel
            // 
            this.btnNoVowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoVowel.Location = new System.Drawing.Point(62, 19);
            this.btnNoVowel.Name = "btnNoVowel";
            this.btnNoVowel.Size = new System.Drawing.Size(50, 50);
            this.btnNoVowel.TabIndex = 0;
            this.btnNoVowel.TabStop = false;
            this.btnNoVowel.Text = "No Vowel";
            this.btnNoVowel.UseVisualStyleBackColor = true;
            this.btnNoVowel.Click += new System.EventHandler(this.VowelInput);
            // 
            // listInputColours
            // 
            this.listInputColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInputColours.FormattingEnabled = true;
            this.listInputColours.ItemHeight = 16;
            this.listInputColours.Items.AddRange(new object[] {
            "___ Input ___",
            "==========="});
            this.listInputColours.Location = new System.Drawing.Point(225, 100);
            this.listInputColours.Name = "listInputColours";
            this.listInputColours.Size = new System.Drawing.Size(85, 212);
            this.listInputColours.TabIndex = 2;
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblWaiting);
            this.groupResult.Controls.Add(this.label8);
            this.groupResult.Controls.Add(this.label7);
            this.groupResult.Controls.Add(this.label6);
            this.groupResult.Controls.Add(this.label5);
            this.groupResult.Controls.Add(this.label4);
            this.groupResult.Controls.Add(this.label3);
            this.groupResult.Controls.Add(this.label2);
            this.groupResult.Controls.Add(this.label1);
            this.groupResult.Controls.Add(this.picResult8);
            this.groupResult.Controls.Add(this.picResult7);
            this.groupResult.Controls.Add(this.picResult6);
            this.groupResult.Controls.Add(this.picResult5);
            this.groupResult.Controls.Add(this.picResult4);
            this.groupResult.Controls.Add(this.picResult3);
            this.groupResult.Controls.Add(this.picResult2);
            this.groupResult.Controls.Add(this.picResult1);
            this.groupResult.Location = new System.Drawing.Point(12, 319);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(298, 78);
            this.groupResult.TabIndex = 5;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // lblWaiting
            // 
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.Location = new System.Drawing.Point(6, 16);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(286, 59);
            this.lblWaiting.TabIndex = 1;
            this.lblWaiting.Text = "Waiting for all input.";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picResult8
            // 
            this.picResult8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult8.Location = new System.Drawing.Point(258, 19);
            this.picResult8.Name = "picResult8";
            this.picResult8.Size = new System.Drawing.Size(30, 30);
            this.picResult8.TabIndex = 0;
            this.picResult8.TabStop = false;
            // 
            // picResult7
            // 
            this.picResult7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult7.Location = new System.Drawing.Point(222, 19);
            this.picResult7.Name = "picResult7";
            this.picResult7.Size = new System.Drawing.Size(30, 30);
            this.picResult7.TabIndex = 0;
            this.picResult7.TabStop = false;
            // 
            // picResult6
            // 
            this.picResult6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult6.Location = new System.Drawing.Point(186, 19);
            this.picResult6.Name = "picResult6";
            this.picResult6.Size = new System.Drawing.Size(30, 30);
            this.picResult6.TabIndex = 0;
            this.picResult6.TabStop = false;
            // 
            // picResult5
            // 
            this.picResult5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult5.Location = new System.Drawing.Point(150, 19);
            this.picResult5.Name = "picResult5";
            this.picResult5.Size = new System.Drawing.Size(30, 30);
            this.picResult5.TabIndex = 0;
            this.picResult5.TabStop = false;
            // 
            // picResult4
            // 
            this.picResult4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult4.Location = new System.Drawing.Point(114, 19);
            this.picResult4.Name = "picResult4";
            this.picResult4.Size = new System.Drawing.Size(30, 30);
            this.picResult4.TabIndex = 0;
            this.picResult4.TabStop = false;
            // 
            // picResult3
            // 
            this.picResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult3.Location = new System.Drawing.Point(78, 19);
            this.picResult3.Name = "picResult3";
            this.picResult3.Size = new System.Drawing.Size(30, 30);
            this.picResult3.TabIndex = 0;
            this.picResult3.TabStop = false;
            // 
            // picResult2
            // 
            this.picResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult2.Location = new System.Drawing.Point(42, 19);
            this.picResult2.Name = "picResult2";
            this.picResult2.Size = new System.Drawing.Size(30, 30);
            this.picResult2.TabIndex = 0;
            this.picResult2.TabStop = false;
            // 
            // picResult1
            // 
            this.picResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult1.Location = new System.Drawing.Point(6, 19);
            this.picResult1.Name = "picResult1";
            this.picResult1.Size = new System.Drawing.Size(30, 30);
            this.picResult1.TabIndex = 0;
            this.picResult1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(298, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Simon_Says
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 438);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupSerial);
            this.Controls.Add(this.groupStrike);
            this.Controls.Add(this.listInputColours);
            this.Controls.Add(this.groupColourInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Simon_Says";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simon Says";
            this.groupColourInput.ResumeLayout(false);
            this.groupStrike.ResumeLayout(false);
            this.groupSerial.ResumeLayout(false);
            this.groupResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.GroupBox groupColourInput;
        private System.Windows.Forms.GroupBox groupStrike;
        private System.Windows.Forms.Button btn2Strike;
        private System.Windows.Forms.Button btn1Strike;
        private System.Windows.Forms.Button btn0Strike;
        private System.Windows.Forms.GroupBox groupSerial;
        private System.Windows.Forms.Button btnVowel;
        private System.Windows.Forms.Button btnNoVowel;
        private System.Windows.Forms.ListBox listInputColours;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picResult8;
        private System.Windows.Forms.PictureBox picResult7;
        private System.Windows.Forms.PictureBox picResult6;
        private System.Windows.Forms.PictureBox picResult5;
        private System.Windows.Forms.PictureBox picResult4;
        private System.Windows.Forms.PictureBox picResult3;
        private System.Windows.Forms.PictureBox picResult2;
        private System.Windows.Forms.PictureBox picResult1;
    }
}