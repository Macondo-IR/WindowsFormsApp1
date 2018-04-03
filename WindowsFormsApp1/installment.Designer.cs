namespace WindowsFormsApp1
{
    partial class installment
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numInstallmentcount = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.txtAmountPerInstallment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoanReceiptDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInstallmentcount)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "ایجاد اقساط";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "پاک کردن";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numInstallmentcount
            // 
            this.numInstallmentcount.Location = new System.Drawing.Point(252, 211);
            this.numInstallmentcount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numInstallmentcount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numInstallmentcount.Name = "numInstallmentcount";
            this.numInstallmentcount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numInstallmentcount.Size = new System.Drawing.Size(41, 20);
            this.numInstallmentcount.TabIndex = 24;
            this.numInstallmentcount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numInstallmentcount.ValueChanged += new System.EventHandler(this.numInstallmentcount_ValueChanged);
            this.numInstallmentcount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numInstallmentcount_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(203, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 23;
            // 
            // txtFamily
            // 
            this.txtFamily.Enabled = false;
            this.txtFamily.Location = new System.Drawing.Point(203, 70);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(100, 20);
            this.txtFamily.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "تعداد اقساط";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "نام خانوادگی";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "بررسی ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "کد پرسنل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "مبلغ وام دریافتی";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "شناسه وام دریافتی";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Enabled = false;
            this.txtLoanAmount.Location = new System.Drawing.Point(182, 172);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLoanAmount.TabIndex = 33;
            // 
            // txtLoanId
            // 
            this.txtLoanId.Enabled = false;
            this.txtLoanId.Location = new System.Drawing.Point(182, 114);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.Size = new System.Drawing.Size(100, 20);
            this.txtLoanId.TabIndex = 34;
            // 
            // txtAmountPerInstallment
            // 
            this.txtAmountPerInstallment.Enabled = false;
            this.txtAmountPerInstallment.Location = new System.Drawing.Point(12, 218);
            this.txtAmountPerInstallment.Name = "txtAmountPerInstallment";
            this.txtAmountPerInstallment.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPerInstallment.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "مبلغ هر قسط";
            // 
            // txtLoanReceiptDate
            // 
            this.txtLoanReceiptDate.Enabled = false;
            this.txtLoanReceiptDate.Location = new System.Drawing.Point(182, 146);
            this.txtLoanReceiptDate.Name = "txtLoanReceiptDate";
            this.txtLoanReceiptDate.Size = new System.Drawing.Size(100, 20);
            this.txtLoanReceiptDate.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "تاریخ دریافت وام";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "حذف دفترچه اقساط";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // installment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtLoanReceiptDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmountPerInstallment);
            this.Controls.Add(this.txtLoanId);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numInstallmentcount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "installment";
            this.Text = "installment";
            ((System.ComponentModel.ISupportInitialize)(this.numInstallmentcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numInstallmentcount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.TextBox txtAmountPerInstallment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoanReceiptDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}