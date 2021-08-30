namespace Proiect
{
    partial class ProgrammerSolution
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
            this.SolTb = new System.Windows.Forms.TextBox();
            this.solutionButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyright1 = new Proiect.Copyright();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SolTb
            // 
            this.SolTb.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolTb.Location = new System.Drawing.Point(3, 3);
            this.SolTb.Multiline = true;
            this.SolTb.Name = "SolTb";
            this.SolTb.Size = new System.Drawing.Size(342, 357);
            this.SolTb.TabIndex = 0;
            // 
            // solutionButton
            // 
            this.solutionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.solutionButton.FlatAppearance.BorderSize = 0;
            this.solutionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solutionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionButton.ForeColor = System.Drawing.Color.Black;
            this.solutionButton.Location = new System.Drawing.Point(365, 405);
            this.solutionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.Size = new System.Drawing.Size(196, 63);
            this.solutionButton.TabIndex = 22;
            this.solutionButton.Text = "Save";
            this.solutionButton.UseVisualStyleBackColor = false;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(365, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Drag your screenshot here ";
            // 
            // copyright1
            // 
            this.copyright1.Location = new System.Drawing.Point(26, 477);
            this.copyright1.Name = "copyright1";
            this.copyright1.Size = new System.Drawing.Size(703, 46);
            this.copyright1.TabIndex = 26;
            // 
            // ProgrammerSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 535);
            this.Controls.Add(this.copyright1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.solutionButton);
            this.Controls.Add(this.SolTb);
            this.Name = "ProgrammerSolution";
            this.Text = "Solution";
            this.Load += new System.EventHandler(this.Solution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SolTb;
        private System.Windows.Forms.Button solutionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Copyright copyright1;
    }
}