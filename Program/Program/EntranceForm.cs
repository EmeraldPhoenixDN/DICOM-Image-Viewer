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
    public partial class EntranceForm : Form
    {
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainMenu frm = new MainMenu();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorReg frm = new DoctorReg();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
