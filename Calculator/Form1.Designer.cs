
namespace Calculator
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
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btTru = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSo1
            // 
            this.lbSo1.AutoSize = true;
            this.lbSo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSo1.Location = new System.Drawing.Point(123, 58);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(41, 21);
            this.lbSo1.TabIndex = 0;
            this.lbSo1.Text = "Số 1";
            // 
            // lbSo2
            // 
            this.lbSo2.AutoSize = true;
            this.lbSo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSo2.Location = new System.Drawing.Point(123, 107);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(41, 21);
            this.lbSo2.TabIndex = 1;
            this.lbSo2.Text = "Số 2";
            // 
            // lbKetqua
            // 
            this.lbKetqua.AutoSize = true;
            this.lbKetqua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKetqua.Location = new System.Drawing.Point(123, 157);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(62, 21);
            this.lbKetqua.TabIndex = 2;
            this.lbKetqua.Text = "Kết quả";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(216, 60);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(237, 23);
            this.txtSo1.TabIndex = 3;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(216, 109);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(237, 23);
            this.txtSo2.TabIndex = 4;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(216, 159);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(237, 23);
            this.txtKetqua.TabIndex = 5;
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTru.Location = new System.Drawing.Point(123, 297);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(136, 58);
            this.btTru.TabIndex = 6;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(318, 297);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(135, 58);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 413);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btCong;
    }
}

