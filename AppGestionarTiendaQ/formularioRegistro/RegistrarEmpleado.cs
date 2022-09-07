using System;
using System.Windows.Forms;
using appGestionarTienda.logica;

namespace appGestionarTienda.formularioRegistro
{
    public partial class RegistrarEmpleado : Form
    {
        public RegistrarEmpleado()
        {
            InitializeComponent();
            cbxTipoEmp.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        Empleado emp = new Empleado();

        #region btn
        private void btnGuardarEmpleados_Click_1(object sender, EventArgs e)
        {
            if (txtCorreoEmp.Text == "" || txtIdEmpleado.Text == "" || txtNombreEmpleado.Text == "" || txtPrimerApellidoEmp.Text == "" || txtSueldoEmp.Text == "" || txtTelefonoEmp.Text == "" || cbxTipoEmp.Text == "")
            {
                MessageBox.Show("ERROR: Faltan datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo, resultado;
                string nombre, primerApellido, segundoApellido, correo, tipoEmpleado;
                double telefono, sueldo;
                codigo = int.Parse(txtIdEmpleado.Text);
                nombre = txtNombreEmpleado.Text;
                primerApellido = txtPrimerApellidoEmp.Text;
                segundoApellido = txtSegundoApellidoEmp.Text;
                telefono = double.Parse(txtTelefonoEmp.Text);
                correo = txtCorreoEmp.Text;
                sueldo = double.Parse(txtSueldoEmp.Text);
                tipoEmpleado = cbxTipoEmp.Text;
                resultado = emp.ingresarEmpleados(codigo, nombre, primerApellido, segundoApellido, telefono, correo, sueldo, tipoEmpleado);
                if (resultado > 0)
                {
                    MessageBox.Show("Se registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar (La clave ya existe) ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtIdEmpleado.Text = "";
                txtNombreEmpleado.Text = "";
                txtPrimerApellidoEmp.Text = "";
                txtSegundoApellidoEmp.Text = "";
                txtTelefonoEmp.Text = "";
                txtCorreoEmp.Text = "";
                txtSueldoEmp.Text = "";
                cbxTipoEmp.Text = null;
            }
        }
        #endregion

        #region keyPress
        private void txtIdEmpleado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreEmpleado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        #endregion


    }
}
