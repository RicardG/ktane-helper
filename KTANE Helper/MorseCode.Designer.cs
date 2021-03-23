namespace KTANE_Helper
{
    partial class MorseCode
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
            this.btnReset = new System.Windows.Forms.Button();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.txtRawText = new System.Windows.Forms.TextBox();
            this.txtBestGuess = new System.Windows.Forms.TextBox();
            this.txtRawInput = new System.Windows.Forms.TextBox();
            this.groupRawInput = new System.Windows.Forms.GroupBox();
            this.groupRawText = new System.Windows.Forms.GroupBox();
            this.groupBestGuess = new System.Windows.Forms.GroupBox();
            this.groupInput.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.groupRawInput.SuspendLayout();
            this.groupRawText.SuspendLayout();
            this.groupBestGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 507);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(482, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.btnBackspace);
            this.groupInput.Controls.Add(this.btnDot);
            this.groupInput.Controls.Add(this.btnSpace);
            this.groupInput.Controls.Add(this.btnDash);
            this.groupInput.Location = new System.Drawing.Point(15, 15);
            this.groupInput.Margin = new System.Windows.Forms.Padding(6);
            this.groupInput.Name = "groupInput";
            this.groupInput.Padding = new System.Windows.Forms.Padding(6);
            this.groupInput.Size = new System.Drawing.Size(482, 138);
            this.groupInput.TabIndex = 7;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input";
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.lblResult);
            this.groupResult.Location = new System.Drawing.Point(15, 399);
            this.groupResult.Margin = new System.Windows.Forms.Padding(6);
            this.groupResult.Name = "groupResult";
            this.groupResult.Padding = new System.Windows.Forms.Padding(6);
            this.groupResult.Size = new System.Drawing.Size(482, 96);
            this.groupResult.TabIndex = 8;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 30);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(396, 37);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Respond with 3.565 MHz";
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(12, 36);
            this.btnDot.Margin = new System.Windows.Forms.Padding(6);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(100, 96);
            this.btnDot.TabIndex = 10;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnDash
            // 
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(124, 36);
            this.btnDash.Margin = new System.Windows.Forms.Padding(6);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(100, 96);
            this.btnDash.TabIndex = 10;
            this.btnDash.TabStop = false;
            this.btnDash.Text = "-";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(258, 36);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(6);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(100, 96);
            this.btnSpace.TabIndex = 10;
            this.btnSpace.TabStop = false;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(370, 36);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(100, 96);
            this.btnBackspace.TabIndex = 10;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.Text = "<==Bksp";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // txtRawText
            // 
            this.txtRawText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRawText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawText.Location = new System.Drawing.Point(12, 36);
            this.txtRawText.Margin = new System.Windows.Forms.Padding(6);
            this.txtRawText.Name = "txtRawText";
            this.txtRawText.ReadOnly = true;
            this.txtRawText.Size = new System.Drawing.Size(208, 56);
            this.txtRawText.TabIndex = 10;
            this.txtRawText.Text = "RawText";
            // 
            // txtBestGuess
            // 
            this.txtBestGuess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBestGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestGuess.Location = new System.Drawing.Point(12, 36);
            this.txtBestGuess.Margin = new System.Windows.Forms.Padding(6);
            this.txtBestGuess.Name = "txtBestGuess";
            this.txtBestGuess.ReadOnly = true;
            this.txtBestGuess.Size = new System.Drawing.Size(208, 56);
            this.txtBestGuess.TabIndex = 10;
            this.txtBestGuess.Text = "BestGuess";
            // 
            // txtRawInput
            // 
            this.txtRawInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRawInput.Font = new System.Drawing.Font("Lucida Fax", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawInput.Location = new System.Drawing.Point(12, 36);
            this.txtRawInput.Margin = new System.Windows.Forms.Padding(6);
            this.txtRawInput.Name = "txtRawInput";
            this.txtRawInput.ReadOnly = true;
            this.txtRawInput.Size = new System.Drawing.Size(458, 58);
            this.txtRawInput.TabIndex = 10;
            this.txtRawInput.Text = "---. ---. ---. ---. ---. ---..";
            // 
            // groupRawInput
            // 
            this.groupRawInput.Controls.Add(this.txtRawInput);
            this.groupRawInput.Location = new System.Drawing.Point(15, 165);
            this.groupRawInput.Margin = new System.Windows.Forms.Padding(6);
            this.groupRawInput.Name = "groupRawInput";
            this.groupRawInput.Padding = new System.Windows.Forms.Padding(6);
            this.groupRawInput.Size = new System.Drawing.Size(482, 106);
            this.groupRawInput.TabIndex = 11;
            this.groupRawInput.TabStop = false;
            this.groupRawInput.Text = "Raw Input";
            // 
            // groupRawText
            // 
            this.groupRawText.Controls.Add(this.txtRawText);
            this.groupRawText.Location = new System.Drawing.Point(15, 283);
            this.groupRawText.Margin = new System.Windows.Forms.Padding(6);
            this.groupRawText.Name = "groupRawText";
            this.groupRawText.Padding = new System.Windows.Forms.Padding(6);
            this.groupRawText.Size = new System.Drawing.Size(232, 104);
            this.groupRawText.TabIndex = 12;
            this.groupRawText.TabStop = false;
            this.groupRawText.Text = "Raw Text";
            // 
            // groupBestGuess
            // 
            this.groupBestGuess.Controls.Add(this.txtBestGuess);
            this.groupBestGuess.Location = new System.Drawing.Point(265, 283);
            this.groupBestGuess.Margin = new System.Windows.Forms.Padding(6);
            this.groupBestGuess.Name = "groupBestGuess";
            this.groupBestGuess.Padding = new System.Windows.Forms.Padding(6);
            this.groupBestGuess.Size = new System.Drawing.Size(232, 104);
            this.groupBestGuess.TabIndex = 12;
            this.groupBestGuess.TabStop = false;
            this.groupBestGuess.Text = "Best Guess";
            // 
            // MorseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 566);
            this.Controls.Add(this.groupBestGuess);
            this.Controls.Add(this.groupRawText);
            this.Controls.Add(this.groupRawInput);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MorseCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Morse Code";
            this.groupInput.ResumeLayout(false);
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.groupRawInput.ResumeLayout(false);
            this.groupRawInput.PerformLayout();
            this.groupRawText.ResumeLayout(false);
            this.groupRawText.PerformLayout();
            this.groupBestGuess.ResumeLayout(false);
            this.groupBestGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.TextBox txtRawText;
        private System.Windows.Forms.TextBox txtBestGuess;
        private System.Windows.Forms.TextBox txtRawInput;
        private System.Windows.Forms.GroupBox groupRawInput;
        private System.Windows.Forms.GroupBox groupRawText;
        private System.Windows.Forms.GroupBox groupBestGuess;
    }
}