namespace BaiTap_Nhom
{
    partial class frmGiaiPT
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
            this.radioBtn_PT2 = new System.Windows.Forms.RadioButton();
            this.radioBtn_PT1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_PT2);
            this.groupBox1.Controls.Add(this.radioBtn_PT1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mời bạn chọn";
            // 
            // radioBtn_PT2
            // 
            this.radioBtn_PT2.AutoSize = true;
            this.radioBtn_PT2.Location = new System.Drawing.Point(51, 58);
            this.radioBtn_PT2.Name = "radioBtn_PT2";
            this.radioBtn_PT2.Size = new System.Drawing.Size(233, 17);
            this.radioBtn_PT2.TabIndex = 1;
            this.radioBtn_PT2.TabStop = true;
            this.radioBtn_PT2.Text = "Giải Phương Trình Bậc 2: aX^2 + bX + c = 0";
            this.radioBtn_PT2.UseVisualStyleBackColor = true;
            this.radioBtn_PT2.CheckedChanged += new System.EventHandler(this.radioBtn_PT2_CheckedChanged);
            // 
            // radioBtn_PT1
            // 
            this.radioBtn_PT1.AutoSize = true;
            this.radioBtn_PT1.Location = new System.Drawing.Point(51, 35);
            this.radioBtn_PT1.Name = "radioBtn_PT1";
            this.radioBtn_PT1.Size = new System.Drawing.Size(196, 17);
            this.radioBtn_PT1.TabIndex = 0;
            this.radioBtn_PT1.TabStop = true;
            this.radioBtn_PT1.Text = "Giải Phương Trình Bậc 1: aX + b = 0";
            this.radioBtn_PT1.UseVisualStyleBackColor = true;
            this.radioBtn_PT1.CheckedChanged += new System.EventHandler(this.radioBtn_PT1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập c:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(63, 198);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(233, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(63, 224);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(233, 20);
            this.txtB.TabIndex = 2;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(63, 250);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(233, 20);
            this.txtC.TabIndex = 3;         
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(302, 195);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(68, 24);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Giải";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(302, 221);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 24);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(302, 247);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(68, 24);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(63, 290);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(307, 20);
            this.txtResult.TabIndex = 7;
            // 
            // frmGiaiPT
            // 
            this.AcceptButton = this.btnSolve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiaiPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải PT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_PT2;
        private System.Windows.Forms.RadioButton radioBtn_PT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
    }
}