namespace BaiTap_Nhom
{
    partial class Mang
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.txt_Xuat = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Giam = new System.Windows.Forms.RadioButton();
            this.rbtn_Tang = new System.Windows.Forms.RadioButton();
            this.btn_ThucHien = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SumOdd = new System.Windows.Forms.TextBox();
            this.txt_SumEven = new System.Windows.Forms.TextBox();
            this.txt_Sum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_MinMax = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Max = new System.Windows.Forms.TextBox();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng Một Chiều";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xuất mảng:";
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Location = new System.Drawing.Point(96, 81);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(274, 20);
            this.txt_Nhap.TabIndex = 2;
            // 
            // txt_Xuat
            // 
            this.txt_Xuat.Location = new System.Drawing.Point(96, 105);
            this.txt_Xuat.Name = "txt_Xuat";
            this.txt_Xuat.Size = new System.Drawing.Size(274, 20);
            this.txt_Xuat.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(384, 80);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(80, 20);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(384, 105);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(80, 20);
            this.btn_Quit.TabIndex = 3;
            this.btn_Quit.Text = "Thoát";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Giam);
            this.groupBox1.Controls.Add(this.rbtn_Tang);
            this.groupBox1.Location = new System.Drawing.Point(113, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp Xếp";
            // 
            // rbtn_Giam
            // 
            this.rbtn_Giam.AutoSize = true;
            this.rbtn_Giam.Location = new System.Drawing.Point(193, 17);
            this.rbtn_Giam.Name = "rbtn_Giam";
            this.rbtn_Giam.Size = new System.Drawing.Size(110, 17);
            this.rbtn_Giam.TabIndex = 0;
            this.rbtn_Giam.TabStop = true;
            this.rbtn_Giam.Text = "Sắp xếp giảm dần";
            this.rbtn_Giam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Tang
            // 
            this.rbtn_Tang.AutoSize = true;
            this.rbtn_Tang.Location = new System.Drawing.Point(48, 19);
            this.rbtn_Tang.Name = "rbtn_Tang";
            this.rbtn_Tang.Size = new System.Drawing.Size(109, 17);
            this.rbtn_Tang.TabIndex = 0;
            this.rbtn_Tang.TabStop = true;
            this.rbtn_Tang.Text = "Sắp xếp tăng dần";
            this.rbtn_Tang.UseVisualStyleBackColor = true;
            // 
            // btn_ThucHien
            // 
            this.btn_ThucHien.Location = new System.Drawing.Point(17, 157);
            this.btn_ThucHien.Name = "btn_ThucHien";
            this.btn_ThucHien.Size = new System.Drawing.Size(80, 34);
            this.btn_ThucHien.TabIndex = 3;
            this.btn_ThucHien.Text = "Thực Hiện";
            this.btn_ThucHien.UseVisualStyleBackColor = true;
            this.btn_ThucHien.Click += new System.EventHandler(this.btn_ThucHien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_SumOdd);
            this.groupBox2.Controls.Add(this.txt_SumEven);
            this.groupBox2.Controls.Add(this.txt_Sum);
            this.groupBox2.Location = new System.Drawing.Point(17, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng";
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(56, 113);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(88, 20);
            this.btn_Sum.TabIndex = 3;
            this.btn_Sum.Text = "Tổng";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng lẻ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng chẵn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng mảng:";
            // 
            // txt_SumOdd
            // 
            this.txt_SumOdd.Location = new System.Drawing.Point(78, 75);
            this.txt_SumOdd.Name = "txt_SumOdd";
            this.txt_SumOdd.Size = new System.Drawing.Size(98, 20);
            this.txt_SumOdd.TabIndex = 2;
            // 
            // txt_SumEven
            // 
            this.txt_SumEven.Location = new System.Drawing.Point(78, 49);
            this.txt_SumEven.Name = "txt_SumEven";
            this.txt_SumEven.Size = new System.Drawing.Size(98, 20);
            this.txt_SumEven.TabIndex = 2;
            // 
            // txt_Sum
            // 
            this.txt_Sum.Location = new System.Drawing.Point(78, 23);
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.Size = new System.Drawing.Size(98, 20);
            this.txt_Sum.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_MinMax);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_Max);
            this.groupBox3.Controls.Add(this.txt_Min);
            this.groupBox3.Location = new System.Drawing.Point(257, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 130);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Max - Min";
            // 
            // btn_MinMax
            // 
            this.btn_MinMax.Location = new System.Drawing.Point(63, 84);
            this.btn_MinMax.Name = "btn_MinMax";
            this.btn_MinMax.Size = new System.Drawing.Size(84, 25);
            this.btn_MinMax.TabIndex = 3;
            this.btn_MinMax.Text = "Tìm";
            this.btn_MinMax.UseVisualStyleBackColor = true;
            this.btn_MinMax.Click += new System.EventHandler(this.btn_MinMax_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giá trị lớn nhất:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá trị nhỏ nhất:";
            // 
            // txt_Max
            // 
            this.txt_Max.Location = new System.Drawing.Point(93, 20);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.Size = new System.Drawing.Size(86, 20);
            this.txt_Max.TabIndex = 2;
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(93, 46);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Size = new System.Drawing.Size(86, 20);
            this.txt_Min.TabIndex = 2;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(12, 80);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(79, 26);
            this.btn_Nhap.TabIndex = 6;
            this.btn_Nhap.Text = "Nhập mảng";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // Mang
            // 
            this.AcceptButton = this.btn_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 371);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ThucHien);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_Xuat);
            this.Controls.Add(this.txt_Nhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính toán trên Mảng";
            this.Load += new System.EventHandler(this.Mang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nhap;
        private System.Windows.Forms.TextBox txt_Xuat;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_Giam;
        private System.Windows.Forms.RadioButton rbtn_Tang;
        private System.Windows.Forms.Button btn_ThucHien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SumOdd;
        private System.Windows.Forms.TextBox txt_SumEven;
        private System.Windows.Forms.TextBox txt_Sum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Max;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_MinMax;
    }
}