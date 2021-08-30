namespace Proiect
{
    partial class Pricings
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
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rb24 = new System.Windows.Forms.RadioButton();
            this.rbwh = new System.Windows.Forms.RadioButton();
            this.rbonline = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.copyright1 = new Proiect.Copyright();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPackage
            // 
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Items.AddRange(new object[] {
            "Free",
            "Standard",
            "Premium"});
            this.cbPackage.Location = new System.Drawing.Point(94, 322);
            this.cbPackage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(121, 24);
            this.cbPackage.TabIndex = 0;
            this.cbPackage.SelectedIndexChanged += new System.EventHandler(this.cbPackage_SelectedIndexChanged);
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.cbPay.Location = new System.Drawing.Point(92, 423);
            this.cbPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 24);
            this.cbPay.TabIndex = 1;
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Package";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of system users";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(265, 184);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Bug tracking\r\nImport users (CSV & Jira)\r\nUser Management\r\nInteractive feeds & cha" +
    "t\r\nStorage\r\nBug Reports\r\nBug status & workflow";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(92, 537);
            this.hScrollBar1.Maximum = 20;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(143, 21);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(262, 536);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(71, 22);
            this.tbNumber.TabIndex = 7;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Support";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "What we offer";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calculate your own price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(796, 536);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(81, 22);
            this.tbPrice.TabIndex = 12;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(551, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb24
            // 
            this.rb24.AutoSize = true;
            this.rb24.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb24.Location = new System.Drawing.Point(551, 262);
            this.rb24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb24.Name = "rb24";
            this.rb24.Size = new System.Drawing.Size(65, 25);
            this.rb24.TabIndex = 14;
            this.rb24.TabStop = true;
            this.rb24.Text = "24/7";
            this.rb24.UseVisualStyleBackColor = true;
            this.rb24.CheckedChanged += new System.EventHandler(this.rb24_CheckedChanged);
            // 
            // rbwh
            // 
            this.rbwh.AutoSize = true;
            this.rbwh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbwh.Location = new System.Drawing.Point(551, 299);
            this.rbwh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbwh.Name = "rbwh";
            this.rbwh.Size = new System.Drawing.Size(145, 25);
            this.rbwh.TabIndex = 15;
            this.rbwh.TabStop = true;
            this.rbwh.Text = "Working hours";
            this.rbwh.UseVisualStyleBackColor = true;
            this.rbwh.CheckedChanged += new System.EventHandler(this.rbwh_CheckedChanged);
            // 
            // rbonline
            // 
            this.rbonline.AutoSize = true;
            this.rbonline.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbonline.Location = new System.Drawing.Point(551, 335);
            this.rbonline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbonline.Name = "rbonline";
            this.rbonline.Size = new System.Drawing.Size(83, 25);
            this.rbonline.TabIndex = 16;
            this.rbonline.TabStop = true;
            this.rbonline.Text = "Online";
            this.rbonline.UseVisualStyleBackColor = true;
            this.rbonline.CheckedChanged += new System.EventHandler(this.rbonline_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // copyright1
            // 
            this.copyright1.Location = new System.Drawing.Point(94, 576);
            this.copyright1.Name = "copyright1";
            this.copyright1.Size = new System.Drawing.Size(703, 46);
            this.copyright1.TabIndex = 17;
            // 
            // Pricings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 634);
            this.Controls.Add(this.copyright1);
            this.Controls.Add(this.rbonline);
            this.Controls.Add(this.rbwh);
            this.Controls.Add(this.rb24);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.cbPackage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pricings";
            this.Text = "Pricings";
            this.Load += new System.EventHandler(this.Pricings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb24;
        private System.Windows.Forms.RadioButton rbwh;
        private System.Windows.Forms.RadioButton rbonline;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Copyright copyright1;
    }
}