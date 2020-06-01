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
    public partial class DoctorReg : Form
    {
        public DoctorReg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntranceForm frm = new EntranceForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
