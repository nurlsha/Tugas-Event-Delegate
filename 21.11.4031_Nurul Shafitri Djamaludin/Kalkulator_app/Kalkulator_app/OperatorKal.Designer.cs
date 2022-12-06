namespace Kalkulator_app
{
    partial class OperatorKal
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
            this.button_proses = new System.Windows.Forms.Button();
            this.txt_nilaia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_operasi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nilaib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_proses
            // 
            this.button_proses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_proses.Location = new System.Drawing.Point(90, 105);
            this.button_proses.Name = "button_proses";
            this.button_proses.Size = new System.Drawing.Size(75, 23);
            this.button_proses.TabIndex = 0;
            this.button_proses.Text = "Proses";
            this.button_proses.UseVisualStyleBackColor = true;
            this.button_proses.Click += new System.EventHandler(this.button_proses_Click);
            // 
            // txt_nilaia
            // 
            this.txt_nilaia.Location = new System.Drawing.Point(90, 49);
            this.txt_nilaia.Name = "txt_nilaia";
            this.txt_nilaia.Size = new System.Drawing.Size(121, 20);
            this.txt_nilaia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operasi";
            // 
            // txt_operasi
            // 
            this.txt_operasi.FormattingEnabled = true;
            this.txt_operasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.txt_operasi.Location = new System.Drawing.Point(90, 22);
            this.txt_operasi.Name = "txt_operasi";
            this.txt_operasi.Size = new System.Drawing.Size(121, 21);
            this.txt_operasi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nilai B";
            // 
            // txt_nilaib
            // 
            this.txt_nilaib.Location = new System.Drawing.Point(90, 79);
            this.txt_nilaib.Name = "txt_nilaib";
            this.txt_nilaib.Size = new System.Drawing.Size(121, 20);
            this.txt_nilaib.TabIndex = 6;
            // 
            // OperatorKal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 153);
            this.Controls.Add(this.txt_nilaib);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_operasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nilaia);
            this.Controls.Add(this.button_proses);
            this.Name = "OperatorKal";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_proses;
        private System.Windows.Forms.TextBox txt_nilaia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_operasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nilaib;
    }
}