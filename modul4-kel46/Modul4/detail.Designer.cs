namespace Modul4
{
    partial class detail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tutup = new System.Windows.Forms.Button();
            this.btn_editdetail = new System.Windows.Forms.Button();
            this.btn_hapusdetail = new System.Windows.Forms.Button();
            this.plat_box = new System.Windows.Forms.TextBox();
            this.jenis_box = new System.Windows.Forms.TextBox();
            this.merk_box = new System.Windows.Forms.TextBox();
            this.tahun_box = new System.Windows.Forms.TextBox();
            this.harga_box = new System.Windows.Forms.TextBox();
            this.lain_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETAIL MOBIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Plat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Mobil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Merk Mobil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tahun Buat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga Sewa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lain-lain";
            // 
            // tutup
            // 
            this.tutup.BackColor = System.Drawing.Color.Crimson;
            this.tutup.FlatAppearance.BorderSize = 0;
            this.tutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tutup.Location = new System.Drawing.Point(43, 375);
            this.tutup.Margin = new System.Windows.Forms.Padding(4);
            this.tutup.Name = "tutup";
            this.tutup.Size = new System.Drawing.Size(100, 37);
            this.tutup.TabIndex = 13;
            this.tutup.Text = "tutup";
            this.tutup.UseVisualStyleBackColor = false;
            this.tutup.Click += new System.EventHandler(this.tutup_Click);
            // 
            // btn_editdetail
            // 
            this.btn_editdetail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_editdetail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editdetail.FlatAppearance.BorderSize = 0;
            this.btn_editdetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editdetail.Location = new System.Drawing.Point(224, 375);
            this.btn_editdetail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editdetail.Name = "btn_editdetail";
            this.btn_editdetail.Size = new System.Drawing.Size(100, 37);
            this.btn_editdetail.TabIndex = 14;
            this.btn_editdetail.Text = "edit";
            this.btn_editdetail.UseVisualStyleBackColor = false;
            this.btn_editdetail.Click += new System.EventHandler(this.btn_editdetail_Click);
            // 
            // btn_hapusdetail
            // 
            this.btn_hapusdetail.FlatAppearance.BorderSize = 0;
            this.btn_hapusdetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapusdetail.Location = new System.Drawing.Point(402, 375);
            this.btn_hapusdetail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hapusdetail.Name = "btn_hapusdetail";
            this.btn_hapusdetail.Size = new System.Drawing.Size(100, 37);
            this.btn_hapusdetail.TabIndex = 15;
            this.btn_hapusdetail.Text = "hapus";
            this.btn_hapusdetail.UseVisualStyleBackColor = true;
            this.btn_hapusdetail.Click += new System.EventHandler(this.btn_hapusdetail_Click);
            // 
            // plat_box
            // 
            this.plat_box.Location = new System.Drawing.Point(199, 106);
            this.plat_box.Name = "plat_box";
            this.plat_box.Size = new System.Drawing.Size(211, 22);
            this.plat_box.TabIndex = 16;
            // 
            // jenis_box
            // 
            this.jenis_box.Location = new System.Drawing.Point(199, 143);
            this.jenis_box.Name = "jenis_box";
            this.jenis_box.Size = new System.Drawing.Size(211, 22);
            this.jenis_box.TabIndex = 17;
            // 
            // merk_box
            // 
            this.merk_box.Location = new System.Drawing.Point(199, 183);
            this.merk_box.Name = "merk_box";
            this.merk_box.Size = new System.Drawing.Size(211, 22);
            this.merk_box.TabIndex = 18;
            // 
            // tahun_box
            // 
            this.tahun_box.Location = new System.Drawing.Point(199, 224);
            this.tahun_box.Name = "tahun_box";
            this.tahun_box.Size = new System.Drawing.Size(211, 22);
            this.tahun_box.TabIndex = 19;
            // 
            // harga_box
            // 
            this.harga_box.Location = new System.Drawing.Point(199, 265);
            this.harga_box.Name = "harga_box";
            this.harga_box.Size = new System.Drawing.Size(211, 22);
            this.harga_box.TabIndex = 20;
            // 
            // lain_box
            // 
            this.lain_box.Location = new System.Drawing.Point(199, 306);
            this.lain_box.Name = "lain_box";
            this.lain_box.Size = new System.Drawing.Size(211, 22);
            this.lain_box.TabIndex = 21;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 444);
            this.Controls.Add(this.lain_box);
            this.Controls.Add(this.harga_box);
            this.Controls.Add(this.tahun_box);
            this.Controls.Add(this.merk_box);
            this.Controls.Add(this.jenis_box);
            this.Controls.Add(this.plat_box);
            this.Controls.Add(this.btn_hapusdetail);
            this.Controls.Add(this.btn_editdetail);
            this.Controls.Add(this.tutup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "detail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelompok 46";
            this.Load += new System.EventHandler(this.detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tutup;
        private System.Windows.Forms.Button btn_editdetail;
        private System.Windows.Forms.Button btn_hapusdetail;
        private System.Windows.Forms.TextBox plat_box;
        private System.Windows.Forms.TextBox jenis_box;
        private System.Windows.Forms.TextBox merk_box;
        private System.Windows.Forms.TextBox tahun_box;
        private System.Windows.Forms.TextBox harga_box;
        private System.Windows.Forms.TextBox lain_box;
    }
}