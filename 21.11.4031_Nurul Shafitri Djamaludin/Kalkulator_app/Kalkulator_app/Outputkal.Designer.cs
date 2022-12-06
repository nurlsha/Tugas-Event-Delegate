namespace Kalkulator_app
{
    partial class Outputkal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonhitung = new System.Windows.Forms.Button();
            this.list_Output = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonhitung);
            this.groupBox1.Controls.Add(this.list_Output);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Hasil]";
            // 
            // buttonhitung
            // 
            this.buttonhitung.Location = new System.Drawing.Point(6, 215);
            this.buttonhitung.Name = "buttonhitung";
            this.buttonhitung.Size = new System.Drawing.Size(362, 23);
            this.buttonhitung.TabIndex = 1;
            this.buttonhitung.Text = "Hitung";
            this.buttonhitung.UseVisualStyleBackColor = true;
            this.buttonhitung.Click += new System.EventHandler(this.buttonhitung_Click);
            // 
            // list_Output
            // 
            this.list_Output.FormattingEnabled = true;
            this.list_Output.Location = new System.Drawing.Point(6, 22);
            this.list_Output.Name = "list_Output";
            this.list_Output.Size = new System.Drawing.Size(362, 186);
            this.list_Output.TabIndex = 0;
            // 
            // Outputkal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "Outputkal";
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonhitung;
        private System.Windows.Forms.ListBox list_Output;
    }
}

