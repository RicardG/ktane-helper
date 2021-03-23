namespace KTANE_Helper
{
    partial class Maze
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
            this.picMaze = new System.Windows.Forms.PictureBox();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupTasks = new System.Windows.Forms.GroupBox();
            this.groupStep2 = new System.Windows.Forms.GroupBox();
            this.lblStep2Valid = new System.Windows.Forms.Label();
            this.lblStep2Selected = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStep2Confirm = new System.Windows.Forms.Button();
            this.groupStep1 = new System.Windows.Forms.GroupBox();
            this.lblStep1Valid = new System.Windows.Forms.Label();
            this.lblStep1Selected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStep1Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            this.groupInput.SuspendLayout();
            this.groupTasks.SuspendLayout();
            this.groupStep2.SuspendLayout();
            this.groupStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMaze
            // 
            this.picMaze.Location = new System.Drawing.Point(6, 19);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(606, 606);
            this.picMaze.TabIndex = 0;
            this.picMaze.TabStop = false;
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.picMaze);
            this.groupInput.Location = new System.Drawing.Point(12, 12);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(618, 631);
            this.groupInput.TabIndex = 1;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 649);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(618, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupTasks
            // 
            this.groupTasks.Controls.Add(this.groupStep2);
            this.groupTasks.Controls.Add(this.groupStep1);
            this.groupTasks.Location = new System.Drawing.Point(636, 12);
            this.groupTasks.Name = "groupTasks";
            this.groupTasks.Size = new System.Drawing.Size(150, 449);
            this.groupTasks.TabIndex = 7;
            this.groupTasks.TabStop = false;
            this.groupTasks.Text = "Info Panel";
            // 
            // groupStep2
            // 
            this.groupStep2.Controls.Add(this.lblStep2Valid);
            this.groupStep2.Controls.Add(this.lblStep2Selected);
            this.groupStep2.Controls.Add(this.label6);
            this.groupStep2.Controls.Add(this.btnStep2Confirm);
            this.groupStep2.Location = new System.Drawing.Point(6, 210);
            this.groupStep2.Name = "groupStep2";
            this.groupStep2.Size = new System.Drawing.Size(138, 233);
            this.groupStep2.TabIndex = 1;
            this.groupStep2.TabStop = false;
            this.groupStep2.Text = "Step 2";
            // 
            // lblStep2Valid
            // 
            this.lblStep2Valid.Location = new System.Drawing.Point(6, 197);
            this.lblStep2Valid.Margin = new System.Windows.Forms.Padding(3);
            this.lblStep2Valid.Name = "lblStep2Valid";
            this.lblStep2Valid.Size = new System.Drawing.Size(126, 31);
            this.lblStep2Valid.TabIndex = 7;
            this.lblStep2Valid.Text = "* You need to place a\r\n   start or end marker";
            // 
            // lblStep2Selected
            // 
            this.lblStep2Selected.AutoSize = true;
            this.lblStep2Selected.Location = new System.Drawing.Point(6, 149);
            this.lblStep2Selected.Margin = new System.Windows.Forms.Padding(3);
            this.lblStep2Selected.Name = "lblStep2Selected";
            this.lblStep2Selected.Size = new System.Drawing.Size(102, 13);
            this.lblStep2Selected.TabIndex = 7;
            this.lblStep2Selected.Text = "Selected: Start, End";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 121);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select the start and end points of the maze.\r\n\r\nTo place markers:\r\nLeft Click: St" +
    "art Marker\r\nRight Click: End Marker\r\n\r\nClick confirm when finished selecting.";
            // 
            // btnStep2Confirm
            // 
            this.btnStep2Confirm.Location = new System.Drawing.Point(6, 168);
            this.btnStep2Confirm.Name = "btnStep2Confirm";
            this.btnStep2Confirm.Size = new System.Drawing.Size(126, 23);
            this.btnStep2Confirm.TabIndex = 6;
            this.btnStep2Confirm.Text = "Confirm";
            this.btnStep2Confirm.UseVisualStyleBackColor = true;
            this.btnStep2Confirm.Click += new System.EventHandler(this.btnStep2Confirm_Click);
            // 
            // groupStep1
            // 
            this.groupStep1.Controls.Add(this.lblStep1Valid);
            this.groupStep1.Controls.Add(this.lblStep1Selected);
            this.groupStep1.Controls.Add(this.label1);
            this.groupStep1.Controls.Add(this.btnStep1Confirm);
            this.groupStep1.Location = new System.Drawing.Point(6, 19);
            this.groupStep1.Name = "groupStep1";
            this.groupStep1.Size = new System.Drawing.Size(138, 185);
            this.groupStep1.TabIndex = 1;
            this.groupStep1.TabStop = false;
            this.groupStep1.Text = "Step 1";
            // 
            // lblStep1Valid
            // 
            this.lblStep1Valid.AutoSize = true;
            this.lblStep1Valid.Location = new System.Drawing.Point(6, 161);
            this.lblStep1Valid.Margin = new System.Windows.Forms.Padding(3);
            this.lblStep1Valid.Name = "lblStep1Valid";
            this.lblStep1Valid.Size = new System.Drawing.Size(124, 13);
            this.lblStep1Valid.TabIndex = 7;
            this.lblStep1Valid.Text = "* This is not a valid maze";
            // 
            // lblStep1Selected
            // 
            this.lblStep1Selected.AutoSize = true;
            this.lblStep1Selected.Location = new System.Drawing.Point(6, 113);
            this.lblStep1Selected.Margin = new System.Windows.Forms.Padding(3);
            this.lblStep1Selected.Name = "lblStep1Selected";
            this.lblStep1Selected.Size = new System.Drawing.Size(104, 13);
            this.lblStep1Selected.TabIndex = 7;
            this.lblStep1Selected.Text = "Points Selected: 2/2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the two points with circles around them on the maze.\r\n\r\nClick confirm when" +
    " finished selecting.";
            // 
            // btnStep1Confirm
            // 
            this.btnStep1Confirm.Location = new System.Drawing.Point(6, 132);
            this.btnStep1Confirm.Name = "btnStep1Confirm";
            this.btnStep1Confirm.Size = new System.Drawing.Size(126, 23);
            this.btnStep1Confirm.TabIndex = 6;
            this.btnStep1Confirm.Text = "Confirm";
            this.btnStep1Confirm.UseVisualStyleBackColor = true;
            this.btnStep1Confirm.Click += new System.EventHandler(this.btnStep1Confirm_Click);
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 684);
            this.Controls.Add(this.groupTasks);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maze";
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            this.groupInput.ResumeLayout(false);
            this.groupTasks.ResumeLayout(false);
            this.groupStep2.ResumeLayout(false);
            this.groupStep2.PerformLayout();
            this.groupStep1.ResumeLayout(false);
            this.groupStep1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupTasks;
        private System.Windows.Forms.GroupBox groupStep1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupStep2;
        private System.Windows.Forms.Label lblStep2Valid;
        private System.Windows.Forms.Label lblStep2Selected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStep2Confirm;
        private System.Windows.Forms.Label lblStep1Valid;
        private System.Windows.Forms.Label lblStep1Selected;
        private System.Windows.Forms.Button btnStep1Confirm;
    }
}