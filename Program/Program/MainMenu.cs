using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog1 = new PrintDialog();
            // printDialog1.Document = PrintDocument;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientList frm = new PatientList();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgInfo frm = new ProgInfo();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Ви дійсно хочете вийти?",
                                             "Вихід з програми",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Close(); }
            else
            { return; }
        }
    }
}
