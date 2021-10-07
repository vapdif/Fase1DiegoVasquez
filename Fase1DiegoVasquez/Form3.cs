using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1DiegoVasquez
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form2 Registro = new Form2();
            Registro.Show();
            Hide();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDataTime_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
