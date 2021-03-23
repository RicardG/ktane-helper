namespace KTANE_Helper
{
    partial class Keypad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keypad));
            this.groupSymbols = new System.Windows.Forms.GroupBox();
            this.KeypadImages = new System.Windows.Forms.ImageList(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.picResult1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.picResult2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picResult3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picResult4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.groupResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSymbols
            // 
            this.groupSymbols.Location = new System.Drawing.Point(12, 12);
            this.groupSymbols.Name = "groupSymbols";
            this.groupSymbols.Size = new System.Drawing.Size(426, 369);
            this.groupSymbols.TabIndex = 0;
            this.groupSymbols.TabStop = false;
            this.groupSymbols.Text = "Select Symbols - 0 out of 4";
            // 
            // KeypadImages
            // 
            this.KeypadImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("KeypadImages.ImageStream")));
            this.KeypadImages.TransparentColor = System.Drawing.Color.Transparent;
            this.KeypadImages.Images.SetKeyName(0, "00-squigglyn.png");
            this.KeypadImages.Images.SetKeyName(1, "01-balloon.png");
            this.KeypadImages.Images.SetKeyName(2, "02-leftc.png");
            this.KeypadImages.Images.SetKeyName(3, "03-hollowstar.png");
            this.KeypadImages.Images.SetKeyName(4, "04-euro.png");
            this.KeypadImages.Images.SetKeyName(5, "05-ae.png");
            this.KeypadImages.Images.SetKeyName(6, "06-at.png");
            this.KeypadImages.Images.SetKeyName(7, "07-hookn.png");
            this.KeypadImages.Images.SetKeyName(8, "08-upsidedowny.png");
            this.KeypadImages.Images.SetKeyName(9, "09-cursive.png");
            this.KeypadImages.Images.SetKeyName(10, "10-meltedthree.png");
            this.KeypadImages.Images.SetKeyName(11, "11-nwithhat.png");
            this.KeypadImages.Images.SetKeyName(12, "12-squidknife.png");
            this.KeypadImages.Images.SetKeyName(13, "13-questionmark.png");
            this.KeypadImages.Images.SetKeyName(14, "14-doublek.png");
            this.KeypadImages.Images.SetKeyName(15, "15-pumpkin.png");
            this.KeypadImages.Images.SetKeyName(16, "16-copyright.png");
            this.KeypadImages.Images.SetKeyName(17, "17-tracks.png");
            this.KeypadImages.Images.SetKeyName(18, "18-paragraph.png");
            this.KeypadImages.Images.SetKeyName(19, "19-smileyface.png");
            this.KeypadImages.Images.SetKeyName(20, "20-bt.png");
            this.KeypadImages.Images.SetKeyName(21, "21-six.png");
            this.KeypadImages.Images.SetKeyName(22, "22-pitchfork.png");
            this.KeypadImages.Images.SetKeyName(23, "23-omega.png");
            this.KeypadImages.Images.SetKeyName(24, "24-rightc.png");
            this.KeypadImages.Images.SetKeyName(25, "25-dragon.png");
            this.KeypadImages.Images.SetKeyName(26, "26-filledstar.png");
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 484);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(426, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblWaiting);
            this.groupResult.Controls.Add(this.label3);
            this.groupResult.Controls.Add(this.picResult4);
            this.groupResult.Controls.Add(this.label2);
            this.groupResult.Controls.Add(this.picResult3);
            this.groupResult.Controls.Add(this.label1);
            this.groupResult.Controls.Add(this.picResult2);
            this.groupResult.Controls.Add(this.lbl1);
            this.groupResult.Controls.Add(this.picResult1);
            this.groupResult.Location = new System.Drawing.Point(12, 387);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(426, 91);
            this.groupResult.TabIndex = 2;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // picResult1
            // 
            this.picResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult1.Location = new System.Drawing.Point(39, 19);
            this.picResult1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picResult1.Name = "picResult1";
            this.picResult1.Size = new System.Drawing.Size(66, 66);
            this.picResult1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult1.TabIndex = 0;
            this.picResult1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(3, 19);
            this.lbl1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 66);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "1st";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picResult2
            // 
            this.picResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult2.Location = new System.Drawing.Point(144, 19);
            this.picResult2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picResult2.Name = "picResult2";
            this.picResult2.Size = new System.Drawing.Size(66, 66);
            this.picResult2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult2.TabIndex = 0;
            this.picResult2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "2nd";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picResult3
            // 
            this.picResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult3.Location = new System.Drawing.Point(249, 19);
            this.picResult3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picResult3.Name = "picResult3";
            this.picResult3.Size = new System.Drawing.Size(66, 66);
            this.picResult3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult3.TabIndex = 0;
            this.picResult3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 66);
            this.label2.TabIndex = 1;
            this.label2.Text = "3rd";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picResult4
            // 
            this.picResult4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult4.Location = new System.Drawing.Point(354, 19);
            this.picResult4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picResult4.Name = "picResult4";
            this.picResult4.Size = new System.Drawing.Size(66, 66);
            this.picResult4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult4.TabIndex = 0;
            this.picResult4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 66);
            this.label3.TabIndex = 1;
            this.label3.Text = "4th";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.Location = new System.Drawing.Point(6, 16);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(414, 72);
            this.lblWaiting.TabIndex = 0;
            this.lblWaiting.Text = "Waiting for all input.";
            // 
            // Keypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 519);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupSymbols);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Keypad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keypad";
            this.groupResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSymbols;
        private System.Windows.Forms.ImageList KeypadImages;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox picResult1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picResult4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picResult3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picResult2;
        private System.Windows.Forms.Label lblWaiting;
    }
}