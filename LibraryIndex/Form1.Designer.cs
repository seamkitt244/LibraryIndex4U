namespace LibraryIndex
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.referenceInput = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.binaryOutput = new System.Windows.Forms.Label();
            this.linearOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Index Book Finder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12.875F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the reference #:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // referenceInput
            // 
            this.referenceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.referenceInput.Location = new System.Drawing.Point(439, 128);
            this.referenceInput.Name = "referenceInput";
            this.referenceInput.Size = new System.Drawing.Size(146, 46);
            this.referenceInput.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(613, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Linear Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Binary search:";
            // 
            // binaryOutput
            // 
            this.binaryOutput.AutoSize = true;
            this.binaryOutput.BackColor = System.Drawing.Color.Transparent;
            this.binaryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.binaryOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.binaryOutput.Location = new System.Drawing.Point(262, 310);
            this.binaryOutput.Name = "binaryOutput";
            this.binaryOutput.Size = new System.Drawing.Size(168, 39);
            this.binaryOutput.TabIndex = 6;
            this.binaryOutput.Text = "binaryOut";
            // 
            // linearOutput
            // 
            this.linearOutput.AutoSize = true;
            this.linearOutput.BackColor = System.Drawing.Color.Transparent;
            this.linearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.linearOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linearOutput.Location = new System.Drawing.Point(262, 231);
            this.linearOutput.Name = "linearOutput";
            this.linearOutput.Size = new System.Drawing.Size(167, 39);
            this.linearOutput.TabIndex = 7;
            this.linearOutput.Text = "linear Out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 413);
            this.Controls.Add(this.linearOutput);
            this.Controls.Add(this.binaryOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.referenceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox referenceInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label binaryOutput;
        private System.Windows.Forms.Label linearOutput;
    }
}

