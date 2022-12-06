using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_app
{
    public partial class OperatorKal : Form
    {
        public delegate void PenghubungProses(int operasi, int a, int b, int hasil);
        public event PenghubungProses OnGoing;

        public OperatorKal()
        {
            InitializeComponent();
            txt_operasi.SelectedIndex = 0;
        }

        private void button_proses_Click(object sender, EventArgs e)
        {
            string operasi = txt_operasi.SelectedItem.ToString();
            int a = Convert.ToInt32(txt_nilaia.Text);   //casting
            int b = Convert.ToInt32(txt_nilaib.Text);   //casting
            int hasil;


            switch (txt_operasi.SelectedIndex)
            {
                case 0: // penjumlahan
                    hasil = a + b;
                    break;
                case 1: // pengurangan
                    hasil = a - b;
                    break;
                case 2: // perkalian
                    hasil = a * b;
                    break;
                case 3: // pembagian
                    hasil = a / b;
                    break;
                default: // default
                    hasil = 0;
                    break;
            }
            this.OnGoing(txt_operasi.SelectedIndex, a, b, hasil);
        }
    }
}
