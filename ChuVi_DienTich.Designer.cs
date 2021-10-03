namespace BaiTap_Nhom
{
    partial class frmChuVi_DienTich
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_HT = new System.Windows.Forms.RadioButton();
            this.rbtn_HV = new System.Windows.Forms.RadioButton();
            this.rbtn_HTG = new System.Windows.Forms.RadioButton();
            this.rbtn_HCN = new System.Windows.Forms.RadioButton();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.grbox_HCN = new System.Windows.Forms.GroupBox();
            this.txtHCN_DT = new System.Windows.Forms.TextBox();
            this.txtHCN_CV = new System.Windows.Forms.TextBox();
            this.txtHCN_Rong = new System.Windows.Forms.TextBox();
            this.txtHCN_Dai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbox_HTG = new System.Windows.Forms.GroupBox();
            this.txtHTG_DT = new System.Windows.Forms.TextBox();
            this.txtHTG_CV = new System.Windows.Forms.TextBox();
            this.txtHTG_c = new System.Windows.Forms.TextBox();
            this.txtHTG_b = new System.Windows.Forms.TextBox();
            this.txtHTG_a = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHT_CV = new System.Windows.Forms.TextBox();
            this.txtHT_DT = new System.Windows.Forms.TextBox();
            this.grbox_HV = new System.Windows.Forms.GroupBox();
            this.txtHV_DT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHV_canh = new System.Windows.Forms.TextBox();
            this.txtHV_CV = new System.Windows.Forms.TextBox();
            this.grbox_HT = new System.Windows.Forms.GroupBox();
            this.txtHT_r = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbox_HCN.SuspendLayout();
            this.grbox_HTG.SuspendLayout();
            this.grbox_HV.SuspendLayout();
            this.grbox_HT.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(59, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Chu Vi và Diện Tích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_HT);
            this.groupBox1.Controls.Add(this.rbtn_HV);
            this.groupBox1.Controls.Add(this.rbtn_HTG);
            this.groupBox1.Controls.Add(this.rbtn_HCN);
            this.groupBox1.Location = new System.Drawing.Point(25, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // rbtn_HT
            // 
            this.rbtn_HT.AutoSize = true;
            this.rbtn_HT.Location = new System.Drawing.Point(148, 64);
            this.rbtn_HT.Name = "rbtn_HT";
            this.rbtn_HT.Size = new System.Drawing.Size(68, 17);
            this.rbtn_HT.TabIndex = 3;
            this.rbtn_HT.TabStop = true;
            this.rbtn_HT.Text = "Hình tròn";
            this.rbtn_HT.UseVisualStyleBackColor = true;
            this.rbtn_HT.CheckedChanged += new System.EventHandler(this.rbtn_HT_CheckedChanged);
            // 
            // rbtn_HV
            // 
            this.rbtn_HV.AutoSize = true;
            this.rbtn_HV.Location = new System.Drawing.Point(148, 30);
            this.rbtn_HV.Name = "rbtn_HV";
            this.rbtn_HV.Size = new System.Drawing.Size(80, 17);
            this.rbtn_HV.TabIndex = 1;
            this.rbtn_HV.TabStop = true;
            this.rbtn_HV.Text = "Hình vuông";
            this.rbtn_HV.UseVisualStyleBackColor = true;
            this.rbtn_HV.CheckedChanged += new System.EventHandler(this.rbtn_HV_CheckedChanged);
            // 
            // rbtn_HTG
            // 
            this.rbtn_HTG.AutoSize = true;
            this.rbtn_HTG.Location = new System.Drawing.Point(23, 64);
            this.rbtn_HTG.Name = "rbtn_HTG";
            this.rbtn_HTG.Size = new System.Drawing.Size(90, 17);
            this.rbtn_HTG.TabIndex = 2;
            this.rbtn_HTG.TabStop = true;
            this.rbtn_HTG.Text = "Hình tam giác";
            this.rbtn_HTG.UseVisualStyleBackColor = true;
            this.rbtn_HTG.CheckedChanged += new System.EventHandler(this.rbtn_HTG_CheckedChanged);
            // 
            // rbtn_HCN
            // 
            this.rbtn_HCN.AutoSize = true;
            this.rbtn_HCN.Location = new System.Drawing.Point(23, 30);
            this.rbtn_HCN.Name = "rbtn_HCN";
            this.rbtn_HCN.Size = new System.Drawing.Size(92, 17);
            this.rbtn_HCN.TabIndex = 0;
            this.rbtn_HCN.TabStop = true;
            this.rbtn_HCN.Text = "Hình chữ nhật";
            this.rbtn_HCN.UseVisualStyleBackColor = true;
            this.rbtn_HCN.CheckedChanged += new System.EventHandler(this.rbtn_HCN_CheckedChanged);
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(366, 73);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(110, 28);
            this.btn_Done.TabIndex = 6;
            this.btn_Done.Text = "Thực hiện";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(366, 113);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 28);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Làm lại";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(366, 155);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(110, 28);
            this.btn_Quit.TabIndex = 8;
            this.btn_Quit.Text = "Thoát";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // grbox_HCN
            // 
            this.grbox_HCN.Controls.Add(this.txtHCN_DT);
            this.grbox_HCN.Controls.Add(this.txtHCN_CV);
            this.grbox_HCN.Controls.Add(this.txtHCN_Rong);
            this.grbox_HCN.Controls.Add(this.txtHCN_Dai);
            this.grbox_HCN.Controls.Add(this.label5);
            this.grbox_HCN.Controls.Add(this.label4);
            this.grbox_HCN.Controls.Add(this.label3);
            this.grbox_HCN.Controls.Add(this.label2);
            this.grbox_HCN.Location = new System.Drawing.Point(25, 204);
            this.grbox_HCN.Name = "grbox_HCN";
            this.grbox_HCN.Size = new System.Drawing.Size(226, 128);
            this.grbox_HCN.TabIndex = 1;
            this.grbox_HCN.TabStop = false;
            this.grbox_HCN.Text = "Hình chữ nhật";
            // 
            // txtHCN_DT
            // 
            this.txtHCN_DT.Location = new System.Drawing.Point(78, 107);
            this.txtHCN_DT.Name = "txtHCN_DT";
            this.txtHCN_DT.Size = new System.Drawing.Size(130, 20);
            this.txtHCN_DT.TabIndex = 3;
            // 
            // txtHCN_CV
            // 
            this.txtHCN_CV.Location = new System.Drawing.Point(78, 81);
            this.txtHCN_CV.Name = "txtHCN_CV";
            this.txtHCN_CV.Size = new System.Drawing.Size(130, 20);
            this.txtHCN_CV.TabIndex = 2;
            // 
            // txtHCN_Rong
            // 
            this.txtHCN_Rong.Location = new System.Drawing.Point(78, 55);
            this.txtHCN_Rong.Name = "txtHCN_Rong";
            this.txtHCN_Rong.Size = new System.Drawing.Size(130, 20);
            this.txtHCN_Rong.TabIndex = 1;
            // 
            // txtHCN_Dai
            // 
            this.txtHCN_Dai.Location = new System.Drawing.Point(78, 29);
            this.txtHCN_Dai.Name = "txtHCN_Dai";
            this.txtHCN_Dai.Size = new System.Drawing.Size(130, 20);
            this.txtHCN_Dai.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Diện tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chu vi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chiều dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chiều rộng";
            // 
            // grbox_HTG
            // 
            this.grbox_HTG.Controls.Add(this.txtHTG_DT);
            this.grbox_HTG.Controls.Add(this.txtHTG_CV);
            this.grbox_HTG.Controls.Add(this.txtHTG_c);
            this.grbox_HTG.Controls.Add(this.txtHTG_b);
            this.grbox_HTG.Controls.Add(this.txtHTG_a);
            this.grbox_HTG.Controls.Add(this.label10);
            this.grbox_HTG.Controls.Add(this.label6);
            this.grbox_HTG.Controls.Add(this.label7);
            this.grbox_HTG.Controls.Add(this.label8);
            this.grbox_HTG.Controls.Add(this.label9);
            this.grbox_HTG.Location = new System.Drawing.Point(288, 208);
            this.grbox_HTG.Name = "grbox_HTG";
            this.grbox_HTG.Size = new System.Drawing.Size(226, 158);
            this.grbox_HTG.TabIndex = 2;
            this.grbox_HTG.TabStop = false;
            this.grbox_HTG.Text = "Hình tam giác";
            // 
            // txtHTG_DT
            // 
            this.txtHTG_DT.Location = new System.Drawing.Point(78, 130);
            this.txtHTG_DT.Name = "txtHTG_DT";
            this.txtHTG_DT.Size = new System.Drawing.Size(130, 20);
            this.txtHTG_DT.TabIndex = 4;
            // 
            // txtHTG_CV
            // 
            this.txtHTG_CV.Location = new System.Drawing.Point(78, 104);
            this.txtHTG_CV.Name = "txtHTG_CV";
            this.txtHTG_CV.Size = new System.Drawing.Size(130, 20);
            this.txtHTG_CV.TabIndex = 3;
            // 
            // txtHTG_c
            // 
            this.txtHTG_c.Location = new System.Drawing.Point(78, 78);
            this.txtHTG_c.Name = "txtHTG_c";
            this.txtHTG_c.Size = new System.Drawing.Size(130, 20);
            this.txtHTG_c.TabIndex = 2;
            // 
            // txtHTG_b
            // 
            this.txtHTG_b.Location = new System.Drawing.Point(78, 52);
            this.txtHTG_b.Name = "txtHTG_b";
            this.txtHTG_b.Size = new System.Drawing.Size(130, 20);
            this.txtHTG_b.TabIndex = 1;
            // 
            // txtHTG_a
            // 
            this.txtHTG_a.Location = new System.Drawing.Point(78, 26);
            this.txtHTG_a.Name = "txtHTG_a";
            this.txtHTG_a.Size = new System.Drawing.Size(130, 20);
            this.txtHTG_a.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Diện tích";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chu vi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cạnh c";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cạnh a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cạnh b";
            // 
            // txtHT_CV
            // 
            this.txtHT_CV.Location = new System.Drawing.Point(78, 52);
            this.txtHT_CV.Name = "txtHT_CV";
            this.txtHT_CV.Size = new System.Drawing.Size(130, 20);
            this.txtHT_CV.TabIndex = 1;
            // 
            // txtHT_DT
            // 
            this.txtHT_DT.Location = new System.Drawing.Point(78, 78);
            this.txtHT_DT.Name = "txtHT_DT";
            this.txtHT_DT.Size = new System.Drawing.Size(130, 20);
            this.txtHT_DT.TabIndex = 2;
            // 
            // grbox_HV
            // 
            this.grbox_HV.Controls.Add(this.txtHV_DT);
            this.grbox_HV.Controls.Add(this.label12);
            this.grbox_HV.Controls.Add(this.label13);
            this.grbox_HV.Controls.Add(this.label14);
            this.grbox_HV.Controls.Add(this.txtHV_canh);
            this.grbox_HV.Controls.Add(this.txtHV_CV);
            this.grbox_HV.Location = new System.Drawing.Point(288, 372);
            this.grbox_HV.Name = "grbox_HV";
            this.grbox_HV.Size = new System.Drawing.Size(226, 107);
            this.grbox_HV.TabIndex = 4;
            this.grbox_HV.TabStop = false;
            this.grbox_HV.Text = "Hình vuông";
            // 
            // txtHV_DT
            // 
            this.txtHV_DT.Location = new System.Drawing.Point(78, 71);
            this.txtHV_DT.Name = "txtHV_DT";
            this.txtHV_DT.Size = new System.Drawing.Size(130, 20);
            this.txtHV_DT.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Diện tích";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cạnh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Chu vi";
            // 
            // txtHV_canh
            // 
            this.txtHV_canh.Location = new System.Drawing.Point(78, 19);
            this.txtHV_canh.Name = "txtHV_canh";
            this.txtHV_canh.Size = new System.Drawing.Size(130, 20);
            this.txtHV_canh.TabIndex = 0;
            // 
            // txtHV_CV
            // 
            this.txtHV_CV.Location = new System.Drawing.Point(78, 45);
            this.txtHV_CV.Name = "txtHV_CV";
            this.txtHV_CV.Size = new System.Drawing.Size(130, 20);
            this.txtHV_CV.TabIndex = 1;
            // 
            // grbox_HT
            // 
            this.grbox_HT.Controls.Add(this.txtHT_DT);
            this.grbox_HT.Controls.Add(this.txtHT_r);
            this.grbox_HT.Controls.Add(this.txtHT_CV);
            this.grbox_HT.Controls.Add(this.label11);
            this.grbox_HT.Controls.Add(this.label15);
            this.grbox_HT.Controls.Add(this.label16);
            this.grbox_HT.Location = new System.Drawing.Point(25, 350);
            this.grbox_HT.Name = "grbox_HT";
            this.grbox_HT.Size = new System.Drawing.Size(226, 113);
            this.grbox_HT.TabIndex = 3;
            this.grbox_HT.TabStop = false;
            this.grbox_HT.Text = "Hình tròn";
            // 
            // txtHT_r
            // 
            this.txtHT_r.Location = new System.Drawing.Point(78, 26);
            this.txtHT_r.Name = "txtHT_r";
            this.txtHT_r.Size = new System.Drawing.Size(130, 20);
            this.txtHT_r.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Diện tích";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Bán kính";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Chu vi";
            // 
            // frmChuVi_DienTich
            // 
            this.AcceptButton = this.btn_Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 491);
            this.Controls.Add(this.grbox_HTG);
            this.Controls.Add(this.grbox_HT);
            this.Controls.Add(this.grbox_HV);
            this.Controls.Add(this.grbox_HCN);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChuVi_DienTich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Chu Vi và Diện Tích";
            this.Load += new System.EventHandler(this.frmChuVi_DienTich_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbox_HCN.ResumeLayout(false);
            this.grbox_HCN.PerformLayout();
            this.grbox_HTG.ResumeLayout(false);
            this.grbox_HTG.PerformLayout();
            this.grbox_HV.ResumeLayout(false);
            this.grbox_HV.PerformLayout();
            this.grbox_HT.ResumeLayout(false);
            this.grbox_HT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_HT;
        private System.Windows.Forms.RadioButton rbtn_HV;
        private System.Windows.Forms.RadioButton rbtn_HTG;
        private System.Windows.Forms.RadioButton rbtn_HCN;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.GroupBox grbox_HCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHCN_DT;
        private System.Windows.Forms.TextBox txtHCN_CV;
        private System.Windows.Forms.TextBox txtHCN_Rong;
        private System.Windows.Forms.TextBox txtHCN_Dai;
        private System.Windows.Forms.GroupBox grbox_HTG;
        private System.Windows.Forms.TextBox txtHT_DT;
        private System.Windows.Forms.TextBox txtHT_CV;
        private System.Windows.Forms.TextBox txtHTG_c;
        private System.Windows.Forms.TextBox txtHTG_b;
        private System.Windows.Forms.TextBox txtHTG_a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbox_HV;
        private System.Windows.Forms.TextBox txtHV_DT;
        private System.Windows.Forms.TextBox txtHV_CV;
        private System.Windows.Forms.TextBox txtHV_canh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grbox_HT;
        private System.Windows.Forms.TextBox txtHTG_DT;
        private System.Windows.Forms.TextBox txtHTG_CV;
        private System.Windows.Forms.TextBox txtHT_r;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}