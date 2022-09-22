using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empleados Empleado=new Empleados(); 

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingreso el nombre"); txtNombre.Focus(); return;
            }

            errorProvider1.SetError(txtNombre, "");


            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingreso el DUI"); 
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");


            int ID; 
            if (!int.TryParse(txtID.Text, out ID))
            {
                errorProvider1.SetError(txtID, "No ingresó un ID válido"); txtNombre.Focus(); return;
            }
            errorProvider1.SetError(txtID, "");


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingresó el nombre");
                txtNombre.Focus(); 
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingresó el DUI"); 
                txtNombre.Focus(); 
                return;
            }

            errorProvider1.SetError(txtNombre, "");


            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "No ingresó el salario de forma correcta"); txtSalario.Focus(); return;
            }
            errorProvider1.SetError(txtID, "");

            Empleado.Id = Convert.ToInt32(txtID.Text); 
            Empleado.Nombre = txtNombre.Text;
            Empleado.Dui = txtDUI.Text;
            Empleado.Salario = Double.Parse(txtSalario.Text);
            lbMostrar.Text = "¡Registro guardado!";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAFP_Click(object sender, EventArgs e)
        {
            txtAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void btnISSS_Click(object sender, EventArgs e)
        {
            txtISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void btnSalarioNeto_Click(object sender, EventArgs e)
        {
            txtSalarioNeto.Text = Empleado.salarioNeto(Empleado.Salario).ToString();
        }
    }
}
