namespace KTANE_Helper
{
    partial class Password
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
            this.btnReset = new System.Windows.Forms.Button();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCol5 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCol4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCol3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCol2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCol1 = new System.Windows.Forms.TextBox();
            this.groupResult.SuspendLayout();
            this.groupInput.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblResult);
            this.groupResult.Location = new System.Drawing.Point(12, 208);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(221, 64);
            this.groupResult.TabIndex = 10;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(6, 16);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(209, 40);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Respond with 3.565 MHz\r\nLine 2";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 278);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(221, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.groupBox6);
            this.groupInput.Controls.Add(this.groupBox5);
            this.groupInput.Controls.Add(this.groupBox4);
            this.groupInput.Controls.Add(this.groupBox3);
            this.groupInput.Controls.Add(this.groupBox2);
            this.groupInput.Location = new System.Drawing.Point(12, 12);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(221, 190);
            this.groupInput.TabIndex = 10;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Tumbler Input";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCol5);
            this.groupBox6.Location = new System.Drawing.Point(178, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(37, 165);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "(5)";
            // 
            // txtCol5
            // 
            this.txtCol5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCol5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol5.Location = new System.Drawing.Point(6, 19);
            this.txtCol5.MaxLength = 6;
            this.txtCol5.Multiline = true;
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(25, 140);
            this.txtCol5.TabIndex = 5;
            this.txtCol5.Text = "ABCDEF";
            this.txtCol5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCol5.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCol4);
            this.groupBox5.Location = new System.Drawing.Point(135, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(37, 165);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "(4)";
            // 
            // txtCol4
            // 
            this.txtCol4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCol4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol4.Location = new System.Drawing.Point(6, 19);
            this.txtCol4.MaxLength = 6;
            this.txtCol4.Multiline = true;
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(25, 140);
            this.txtCol4.TabIndex = 4;
            this.txtCol4.Text = "ABCDEF";
            this.txtCol4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCol4.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCol3);
            this.groupBox4.Location = new System.Drawing.Point(92, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(37, 165);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "(3)";
            // 
            // txtCol3
            // 
            this.txtCol3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCol3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol3.Location = new System.Drawing.Point(6, 19);
            this.txtCol3.MaxLength = 6;
            this.txtCol3.Multiline = true;
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(25, 140);
            this.txtCol3.TabIndex = 3;
            this.txtCol3.Text = "ABCDEF";
            this.txtCol3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCol3.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCol2);
            this.groupBox3.Location = new System.Drawing.Point(49, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(37, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(2)";
            // 
            // txtCol2
            // 
            this.txtCol2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCol2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol2.Location = new System.Drawing.Point(6, 19);
            this.txtCol2.MaxLength = 6;
            this.txtCol2.Multiline = true;
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(25, 140);
            this.txtCol2.TabIndex = 2;
            this.txtCol2.Text = "ABCDEF";
            this.txtCol2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCol2.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCol1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(37, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(1)";
            // 
            // txtCol1
            // 
            this.txtCol1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCol1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCol1.Location = new System.Drawing.Point(6, 19);
            this.txtCol1.MaxLength = 6;
            this.txtCol1.Multiline = true;
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(25, 140);
            this.txtCol1.TabIndex = 100;
            this.txtCol1.Text = "ABCDEF";
            this.txtCol1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCol1.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 313);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Password";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password";
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.groupInput.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.TextBox txtCol1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtCol5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCol4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCol3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCol2;
    }
}