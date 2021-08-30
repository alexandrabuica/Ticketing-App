namespace Proiect
{
    partial class UserSolution
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbsolutions = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyright1 = new Proiect.Copyright();
            this.solutionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Visual suggestion";
            // 
            // tbsolutions
            // 
            this.tbsolutions.BackColor = System.Drawing.Color.White;
            this.tbsolutions.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsolutions.Location = new System.Drawing.Point(12, 12);
            this.tbsolutions.Multiline = true;
            this.tbsolutions.Name = "tbsolutions";
            this.tbsolutions.ReadOnly = true;
            this.tbsolutions.Size = new System.Drawing.Size(359, 373);
            this.tbsolutions.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(394, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // copyright1
            // 
            this.copyright1.Location = new System.Drawing.Point(12, 477);
            this.copyright1.Name = "copyright1";
            this.copyright1.Size = new System.Drawing.Size(703, 46);
            this.copyright1.TabIndex = 29;
            // 
            // solutionButton
            // 
            this.solutionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.solutionButton.FlatAppearance.BorderSize = 0;
            this.solutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solutionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionButton.ForeColor = System.Drawing.Color.Black;
            this.solutionButton.Location = new System.Drawing.Point(394, 409);
            this.solutionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.Size = new System.Drawing.Size(196, 63);
            this.solutionButton.TabIndex = 30;
            this.solutionButton.Text = "OK";
            this.solutionButton.UseVisualStyleBackColor = false;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // UserSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 535);
            this.Controls.Add(this.solutionButton);
            this.Controls.Add(this.copyright1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbsolutions);
            this.Name = "UserSolution";
            this.Text = "UserSolution";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbsolutions;
        private Copyright copyright1;
        private System.Windows.Forms.Button solutionButton;
    }
}