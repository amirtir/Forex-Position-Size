
namespace Position_Size
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValueofOnePip = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMargin = new System.Windows.Forms.Label();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStopLossPips = new System.Windows.Forms.TextBox();
            this.txtRiskRatio = new System.Windows.Forms.TextBox();
            this.txtAcountSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtValueofOnePip);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStopLossPips);
            this.groupBox1.Controls.Add(this.txtRiskRatio);
            this.groupBox1.Controls.Add(this.txtAcountSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(492, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "ارزش هر پیپ(دلار)";
            // 
            // txtValueofOnePip
            // 
            this.txtValueofOnePip.Location = new System.Drawing.Point(325, 39);
            this.txtValueofOnePip.Name = "txtValueofOnePip";
            this.txtValueofOnePip.Size = new System.Drawing.Size(138, 23);
            this.txtValueofOnePip.TabIndex = 23;
            this.txtValueofOnePip.Text = "10";
            this.txtValueofOnePip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblMargin);
            this.groupBox2.Controls.Add(this.lblPositionValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(18, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 204);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(122, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "میزان ریسک:";
            // 
            // lblMargin
            // 
            this.lblMargin.AutoSize = true;
            this.lblMargin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMargin.ForeColor = System.Drawing.Color.Red;
            this.lblMargin.Location = new System.Drawing.Point(51, 54);
            this.lblMargin.Name = "lblMargin";
            this.lblMargin.Size = new System.Drawing.Size(25, 30);
            this.lblMargin.TabIndex = 11;
            this.lblMargin.Text = "0";
            this.lblMargin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.AutoSize = true;
            this.lblPositionValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPositionValue.ForeColor = System.Drawing.Color.Red;
            this.lblPositionValue.Location = new System.Drawing.Point(49, 149);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(25, 30);
            this.lblPositionValue.TabIndex = 10;
            this.lblPositionValue.Text = "0";
            this.lblPositionValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(65, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "حجم معامله مناسب:";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(18, 32);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(241, 40);
            this.btnResult.TabIndex = 21;
            this.btnResult.Text = "محاسبه";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(539, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "حد ضرر(پیپ)";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(498, 90);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(167, 30);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "اندازه حساب(دلار)";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(480, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "میزان ریسک(درصد)";
            // 
            // txtStopLossPips
            // 
            this.txtStopLossPips.Location = new System.Drawing.Point(323, 219);
            this.txtStopLossPips.Name = "txtStopLossPips";
            this.txtStopLossPips.Size = new System.Drawing.Size(138, 23);
            this.txtStopLossPips.TabIndex = 15;
            this.txtStopLossPips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRiskRatio
            // 
            this.txtRiskRatio.Location = new System.Drawing.Point(323, 157);
            this.txtRiskRatio.Name = "txtRiskRatio";
            this.txtRiskRatio.Size = new System.Drawing.Size(138, 23);
            this.txtRiskRatio.TabIndex = 14;
            this.txtRiskRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAcountSize
            // 
            this.txtAcountSize.Location = new System.Drawing.Point(323, 97);
            this.txtAcountSize.Name = "txtAcountSize";
            this.txtAcountSize.Size = new System.Drawing.Size(138, 23);
            this.txtAcountSize.TabIndex = 13;
            this.txtAcountSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(507, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "این برنامه توسط amirtir33@gmail.com  جهت مدیریت بهتر سرمایه در معاملات توسعه داده" +
    " شده است.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 340);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "محاسبه گر میزان ریسک و حجم معامله";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStopLossPips;
        private System.Windows.Forms.TextBox txtRiskRatio;
        private System.Windows.Forms.TextBox txtAcountSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValueofOnePip;
    }
}

