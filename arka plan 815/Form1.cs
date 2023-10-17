using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arka_plan_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (rbRenk1.Checked == true)
            {
                this.BackColor = Color.Black;
                rbRenk1.ForeColor = Color.White;
                rbRenk2.ForeColor = Color.White;
            }
            if (rbRenk2.Checked == true)
            {
                this.BackColor = Color.White;
                rbRenk1.ForeColor = Color.Black;
                rbRenk2.ForeColor = Color.Black;
            }
        }
    }
}
