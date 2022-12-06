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
    public partial class Outputkal : Form
    {
        private IList<Kalkulator> listofCalc = new List<Kalkulator>();
        private void AnakCalc_OnCreate(Kalkulator Kal)
        {
            listofCalc.Add(Kal);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(Kal.Operasi);
            item.SubItems.Add(Kal.NilaiA);
            item.SubItems.Add(Kal.NilaiB);
            list_Output.Items.Add(item);
        }
        public Outputkal()
        {
            InitializeComponent();
           
        }
        private void tampilan(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            list_Output.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }

        private void buttonhitung_Click(object sender, EventArgs e)
        {
            OperatorKal hitung = new OperatorKal();
            hitung.OnGoing += tampilan;
            hitung.ShowDialog();
        }
    }
}
