
namespace QuanLyMyPham
{
    partial class in_hoadon
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
            this.label_iD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ngaythang = new System.Windows.Forms.Label();
            this.label_tongtien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_chitietsanpham = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_iD
            // 
            this.label_iD.AutoSize = true;
            this.label_iD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iD.Location = new System.Drawing.Point(356, 9);
            this.label_iD.Name = "label_iD";
            this.label_iD.Size = new System.Drawing.Size(42, 31);
            this.label_iD.TabIndex = 1;
            this.label_iD.Text = "ID";
            this.label_iD.Click += new System.EventHandler(this.label_iD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_ngaythang
            // 
            this.label_ngaythang.AutoSize = true;
            this.label_ngaythang.Location = new System.Drawing.Point(92, 62);
            this.label_ngaythang.Name = "label_ngaythang";
            this.label_ngaythang.Size = new System.Drawing.Size(91, 20);
            this.label_ngaythang.TabIndex = 3;
            this.label_ngaythang.Text = "dd-MM-yyyy";
            this.label_ngaythang.Click += new System.EventHandler(this.label_ngaythang_Click);
            // 
            // label_tongtien
            // 
            this.label_tongtien.AutoSize = true;
            this.label_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tongtien.Location = new System.Drawing.Point(245, 525);
            this.label_tongtien.Name = "label_tongtien";
            this.label_tongtien.Size = new System.Drawing.Size(58, 31);
            this.label_tongtien.TabIndex = 6;
            this.label_tongtien.Text = "tiền";
            this.label_tongtien.Click += new System.EventHandler(this.label_tongtien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 525);
            this.label4.Margin = new System.Windows.Forms.Padding(100, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng tiền : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chi tiết sản phẩm : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_chitietsanpham
            // 
            this.txt_chitietsanpham.AutoSize = true;
            this.txt_chitietsanpham.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_chitietsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chitietsanpham.Location = new System.Drawing.Point(12, 190);
            this.txt_chitietsanpham.Name = "txt_chitietsanpham";
            this.txt_chitietsanpham.Size = new System.Drawing.Size(0, 13);
            this.txt_chitietsanpham.TabIndex = 9;
            this.txt_chitietsanpham.Click += new System.EventHandler(this.txt_chitietsanpham_Click);
            // 
            // in_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 573);
            this.Controls.Add(this.txt_chitietsanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_tongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ngaythang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_iD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "in_hoadon";
            this.Text = "in_hoadon";
            this.Load += new System.EventHandler(this.in_hoadon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_iD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ngaythang;
        private System.Windows.Forms.Label label_tongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_chitietsanpham;
    }
}