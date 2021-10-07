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
    public partial class Form2 : Form
    {
        User user = new User("", "", "", "", 0);
        FormRegWD regWD = new FormRegWD(0, "", "", "", 0, 0, DateTime.Now);
        Payroll payroll = new Payroll(0, "", "", "", 0, 0, DateTime.Now);

        public Form2()
        {
            InitializeComponent();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPosition.SelectedIndex;

            if (index==0)
            {
                txtSalary.Text = 40000.ToString();
            }
            else if (index==1) 
            {
                txtSalary.Text = 50000.ToString();
            }
            else if (index == 2)
            {
                txtSalary.Text = 60000.ToString();
            }
            else if (index == 3)
            {
                txtSalary.Text = 65000.ToString();
            }
            else
            {
                txtSalary.Text = 70000.ToString();
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            resetVal();
                if (Validate())
                {
                    MessageBox.Show("Datos Correctos");
                }
            //Validate();

            try
            {                
                regWD.Id = Convert.ToInt32(txtID.Text);
                regWD.Fname = txtName.Text;
                regWD.Position = cmbPosition.Text;
                regWD.WkDays = Convert.ToInt32(txtDays.Text);
                regWD.DayValue = Convert.ToInt32(txtSalary.Text);
                regWD.Gender = rbtGenderF.Text;
                regWD.Gender = rbtGenderM.Text;
                MessageBox.Show("Registro guardado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Asegúrese de que los datos son correctos. \nE ingrese todos los campos.");                                
                //throw;
            }
            /*regWD.Id = Convert.ToInt32(txtID.Text);
            regWD.Fname = txtName.Text;
            regWD.Position = cmbPosition.Text;
            regWD.WkDays = Convert.ToInt32(txtDays.Text);
            regWD.DayValue = Convert.ToInt32(txtSalary.Text);
            regWD.Gender = rbtGenderF.Text;
            regWD.Gender = rbtGenderM.Text;
            MessageBox.Show("Registro guardado correctamente");*/
        }

        private void btCalcularSalary_Click(object sender, EventArgs e)
        {
            Form3 desprendibleP = new Form3();
            desprendibleP.Show();
            Hide();
                   

            //desprendibleP.txtDataTime.Text;
            desprendibleP.txtColaborador.Text = regWD.Fname;
            desprendibleP.txtCedula.Text = regWD.Id.ToString();
            desprendibleP.txtGender.Text = regWD.Gender;
            desprendibleP.txtPosition.Text = regWD.Position;
            desprendibleP.txtDValue.Text = regWD.DayValue.ToString("C");
            desprendibleP.txtDays.Text = regWD.WkDays.ToString();
            desprendibleP.txtDataTime.Text = DateTime.Now.ToLongDateString();

            desprendibleP.txtSalary.Text = payroll.CalSalary(regWD.WkDays, regWD.DayValue).ToString("C");
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Form2 Registro = new Form2();
            Registro.Show();
            Hide();
        }

        private bool Validate()
        {
            bool val = true;

            if (txtID.Text=="")
            {
                val = false;
                errorProvider1.SetError(txtID, "Ingresar documento. ");
            }
            if (txtName.Text == "")
            {
                val = false;
                errorProvider1.SetError(txtName, "Ingresar Nombre Completo. ");
            }
            if (cmbPosition.Text == "")
            {
                val = false;
                errorProvider1.SetError(cmbPosition, "Seleccionar cargo. ");
            }
            if (txtSalary.Text == "")
            {
                val = false;
                errorProvider1.SetError(txtSalary, "Seleccionar cargo y salario. ");
            }
            if (rbtGenderF.Text == "")
            {
                val = false;
                errorProvider1.SetError(rbtGenderF, "Selecciones Genero. ");
            }
            if (rbtGenderM.Text == "")
            {
                val = false;
                errorProvider1.SetError(rbtGenderM, "Selecciones Genero. ");
            }
            if (txtDays.Text == "")
            {
                val = false;
                errorProvider1.SetError(txtDays, "Digite Días laborados. ");
            }

            return val;
        }

        private void resetVal()
        {
            errorProvider1.SetError(txtID, "");
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(cmbPosition, "");
            errorProvider1.SetError(txtSalary, "");
            errorProvider1.SetError(rbtGenderF, "");
            errorProvider1.SetError(rbtGenderM, "");
            errorProvider1.SetError(txtDays, "");


        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtID.Text, out n))
            {
                errorProvider1.SetError(txtID, "Ingresar solo Numeros");
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }
        }

        private void txtDays_Validated(object sender, EventArgs e)
        {
            int m;
            if (!int.TryParse(txtDays.Text, out m))
            {
                errorProvider1.SetError(txtDays, "Ingresar solo Numeros");
            }
            else
            {
                errorProvider1.SetError(txtDays, "");
            }
        }
    }
}
