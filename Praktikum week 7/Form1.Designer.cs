
namespace Praktikum_week_7
{
    partial class Form1
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
            this.lbl_MasukanKalimat = new System.Windows.Forms.Label();
            this.lbl_MasukanHuruf = new System.Windows.Forms.Label();
            this.lbl_Hasil = new System.Windows.Forms.Label();
            this.lbl_Menjadi = new System.Windows.Forms.Label();
            this.txtBox_InputanKalimat = new System.Windows.Forms.TextBox();
            this.txtBox_InputanHuruf = new System.Windows.Forms.TextBox();
            this.txtBoxMenjadiHuruf = new System.Windows.Forms.TextBox();
            this.btn_Konversi = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_MasukanKalimat
            // 
            this.lbl_MasukanKalimat.AutoSize = true;
            this.lbl_MasukanKalimat.Location = new System.Drawing.Point(22, 25);
            this.lbl_MasukanKalimat.Name = "lbl_MasukanKalimat";
            this.lbl_MasukanKalimat.Size = new System.Drawing.Size(130, 20);
            this.lbl_MasukanKalimat.TabIndex = 0;
            this.lbl_MasukanKalimat.Text = "Masukan Kalimat";
            // 
            // lbl_MasukanHuruf
            // 
            this.lbl_MasukanHuruf.AutoSize = true;
            this.lbl_MasukanHuruf.Location = new System.Drawing.Point(22, 70);
            this.lbl_MasukanHuruf.Name = "lbl_MasukanHuruf";
            this.lbl_MasukanHuruf.Size = new System.Drawing.Size(118, 20);
            this.lbl_MasukanHuruf.TabIndex = 1;
            this.lbl_MasukanHuruf.Text = "Masukan Huruf";
            // 
            // lbl_Hasil
            // 
            this.lbl_Hasil.AutoSize = true;
            this.lbl_Hasil.Location = new System.Drawing.Point(22, 207);
            this.lbl_Hasil.Name = "lbl_Hasil";
            this.lbl_Hasil.Size = new System.Drawing.Size(56, 20);
            this.lbl_Hasil.TabIndex = 2;
            this.lbl_Hasil.Text = "Hasil : ";
            // 
            // lbl_Menjadi
            // 
            this.lbl_Menjadi.AutoSize = true;
            this.lbl_Menjadi.Location = new System.Drawing.Point(357, 70);
            this.lbl_Menjadi.Name = "lbl_Menjadi";
            this.lbl_Menjadi.Size = new System.Drawing.Size(64, 20);
            this.lbl_Menjadi.TabIndex = 3;
            this.lbl_Menjadi.Text = "Menjadi";
            // 
            // txtBox_InputanKalimat
            // 
            this.txtBox_InputanKalimat.Location = new System.Drawing.Point(179, 19);
            this.txtBox_InputanKalimat.Name = "txtBox_InputanKalimat";
            this.txtBox_InputanKalimat.Size = new System.Drawing.Size(432, 26);
            this.txtBox_InputanKalimat.TabIndex = 4;
            // 
            // txtBox_InputanHuruf
            // 
            this.txtBox_InputanHuruf.Location = new System.Drawing.Point(179, 66);
            this.txtBox_InputanHuruf.Name = "txtBox_InputanHuruf";
            this.txtBox_InputanHuruf.Size = new System.Drawing.Size(158, 26);
            this.txtBox_InputanHuruf.TabIndex = 5;
            // 
            // txtBoxMenjadiHuruf
            // 
            this.txtBoxMenjadiHuruf.Location = new System.Drawing.Point(453, 66);
            this.txtBoxMenjadiHuruf.Name = "txtBoxMenjadiHuruf";
            this.txtBoxMenjadiHuruf.Size = new System.Drawing.Size(158, 26);
            this.txtBoxMenjadiHuruf.TabIndex = 6;
            // 
            // btn_Konversi
            // 
            this.btn_Konversi.Location = new System.Drawing.Point(179, 132);
            this.btn_Konversi.Name = "btn_Konversi";
            this.btn_Konversi.Size = new System.Drawing.Size(432, 36);
            this.btn_Konversi.TabIndex = 7;
            this.btn_Konversi.Text = "Konversi";
            this.btn_Konversi.UseVisualStyleBackColor = true;
            this.btn_Konversi.Click += new System.EventHandler(this.btn_Konversi_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(175, 207);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(0, 20);
            this.lbl_Output.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Konversi);
            this.Controls.Add(this.txtBoxMenjadiHuruf);
            this.Controls.Add(this.txtBox_InputanHuruf);
            this.Controls.Add(this.txtBox_InputanKalimat);
            this.Controls.Add(this.lbl_Menjadi);
            this.Controls.Add(this.lbl_Hasil);
            this.Controls.Add(this.lbl_MasukanHuruf);
            this.Controls.Add(this.lbl_MasukanKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MasukanKalimat;
        private System.Windows.Forms.Label lbl_MasukanHuruf;
        private System.Windows.Forms.Label lbl_Hasil;
        private System.Windows.Forms.Label lbl_Menjadi;
        private System.Windows.Forms.TextBox txtBox_InputanKalimat;
        private System.Windows.Forms.TextBox txtBox_InputanHuruf;
        private System.Windows.Forms.TextBox txtBoxMenjadiHuruf;
        private System.Windows.Forms.Button btn_Konversi;
        private System.Windows.Forms.Label lbl_Output;
    }
}

