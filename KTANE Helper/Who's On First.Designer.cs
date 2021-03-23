namespace KTANE_Helper
{
    partial class Who_s_On_First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Who_s_On_First));
            this.groupStep1 = new System.Windows.Forms.GroupBox();
            this.groupStep2 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStep1Result = new System.Windows.Forms.Label();
            this.picStep1Result = new System.Windows.Forms.PictureBox();
            this.imagePositions = new System.Windows.Forms.ImageList(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblInfoCurrent = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStep1Result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupStep1
            // 
            this.groupStep1.Location = new System.Drawing.Point(12, 12);
            this.groupStep1.Name = "groupStep1";
            this.groupStep1.Size = new System.Drawing.Size(642, 249);
            this.groupStep1.TabIndex = 0;
            this.groupStep1.TabStop = false;
            this.groupStep1.Text = "Step 1 - Label On Screen";
            // 
            // groupStep2
            // 
            this.groupStep2.Location = new System.Drawing.Point(12, 267);
            this.groupStep2.Name = "groupStep2";
            this.groupStep2.Size = new System.Drawing.Size(642, 249);
            this.groupStep2.TabIndex = 0;
            this.groupStep2.TabStop = false;
            this.groupStep2.Text = "Step 2 - Labels On Buttons";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStep1Result);
            this.groupBox2.Controls.Add(this.picStep1Result);
            this.groupBox2.Location = new System.Drawing.Point(660, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // lblStep1Result
            // 
            this.lblStep1Result.BackColor = System.Drawing.Color.Black;
            this.lblStep1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1Result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStep1Result.Location = new System.Drawing.Point(6, 16);
            this.lblStep1Result.Name = "lblStep1Result";
            this.lblStep1Result.Size = new System.Drawing.Size(89, 26);
            this.lblStep1Result.TabIndex = 1;
            this.lblStep1Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picStep1Result
            // 
            this.picStep1Result.Location = new System.Drawing.Point(6, 42);
            this.picStep1Result.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.picStep1Result.Name = "picStep1Result";
            this.picStep1Result.Size = new System.Drawing.Size(89, 70);
            this.picStep1Result.TabIndex = 0;
            this.picStep1Result.TabStop = false;
            // 
            // imagePositions
            // 
            this.imagePositions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagePositions.ImageStream")));
            this.imagePositions.TransparentColor = System.Drawing.Color.Transparent;
            this.imagePositions.Images.SetKeyName(0, "0. top left.png");
            this.imagePositions.Images.SetKeyName(1, "1. top right.png");
            this.imagePositions.Images.SetKeyName(2, "2. middle left.png");
            this.imagePositions.Images.SetKeyName(3, "3. middle right.png");
            this.imagePositions.Images.SetKeyName(4, "4. bottom left.png");
            this.imagePositions.Images.SetKeyName(5, "5. bottom right.png");
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 531);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(897, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelected);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.lblInfoCurrent);
            this.groupBox1.Controls.Add(this.lblNext);
            this.groupBox1.Controls.Add(this.lblCurrent);
            this.groupBox1.Controls.Add(this.lblPrevious);
            this.groupBox1.Location = new System.Drawing.Point(660, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(6, 16);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(169, 20);
            this.lblSelected.TabIndex = 2;
            this.lblSelected.Text = "Waiting for all input.";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(168, 77);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(6, 77);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 25);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<- Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblInfoCurrent
            // 
            this.lblInfoCurrent.Location = new System.Drawing.Point(87, 77);
            this.lblInfoCurrent.Name = "lblInfoCurrent";
            this.lblInfoCurrent.Size = new System.Drawing.Size(75, 25);
            this.lblInfoCurrent.TabIndex = 0;
            this.lblInfoCurrent.Text = "Current";
            this.lblInfoCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            this.lblNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(168, 49);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(75, 25);
            this.lblNext.TabIndex = 0;
            this.lblNext.Text = "Nothing";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrent
            // 
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(87, 49);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(75, 25);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "NOTHING";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrevious
            // 
            this.lblPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(6, 49);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(75, 25);
            this.lblPrevious.TabIndex = 0;
            this.lblPrevious.Text = "NOTHING";
            this.lblPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Who_s_On_First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupStep2);
            this.Controls.Add(this.groupStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Who_s_On_First";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Who\'s On First";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStep1Result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStep1;
        private System.Windows.Forms.GroupBox groupStep2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStep1Result;
        private System.Windows.Forms.PictureBox picStep1Result;
        private System.Windows.Forms.ImageList imagePositions;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblInfoCurrent;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblPrevious;
    }
}