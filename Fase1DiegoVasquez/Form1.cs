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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btEntry_Click(object sender, EventArgs e)        
        {
                bool errorlogin = false;

                foreach (char caracter in txtLogin.Text)
                {
                    if (char.IsLetter(caracter))
                    {
                        errorlogin = true;
                        break;
                    }
                }

                if (errorlogin)
                {
                    errorProvider1.SetError(txtLogin, "No se admiten Letras ");
                }
                else
                {
                    errorProvider1.Clear();
                }
            


            if (txtLogin.Text == "123")
            {                
                Form2 Registro = new Form2();
                Registro.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                txtLogin.Clear();
            }
        }

        private void btEntry_TextChanged(object sender, EventArgs e)
        {
            bool errorlogin = false;

            foreach (char caracter in txtLogin.Text)
            {
                if (char.IsLetter(caracter))
                {
                    errorlogin = true;
                    break;
                }
            }

            if (errorlogin)
            {
                errorProvider1.SetError(txtLogin, "No se admiten Letras ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
