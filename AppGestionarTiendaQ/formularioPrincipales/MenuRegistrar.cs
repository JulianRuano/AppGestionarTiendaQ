using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using appGestionarTiendaQ.formularioRegistro;
using appGestionarTienda.formularioRegistro;


namespace appGestionarTiendaQ.formularioPrincipales
{
    public partial class MenuRegistrar : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nleftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
        );
        private Form FormSecundarios = new Form();
        public MenuRegistrar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnTemporal.Height;
            pnlNav.Top = btnTemporal.Top;
            pnlNav.Left = btnTemporal.Left;
            btnTemporal.BackColor = Color.FromArgb(46, 51, 73);                 
        }
        private void AbrirForm(Form FormHijo)
        {
            if (FormSecundarios != null)
            {
                FormSecundarios.Close();
            }
            FormSecundarios = FormHijo;

            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Add(FormHijo);
            pnlEscritorio.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }

        #region btn Externos
        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarCliente());
            pnlNav.Height = btnCliente.Height;
            pnlNav.Top = btnCliente.Top;
            pnlNav.Left = btnCliente.Left;
            btnCliente.BackColor = Color.FromArgb(24, 61, 85);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FormSecundarios?.Close();
            btnAgregarEmpleado.Visible = true;
            btnAgregarSucursal.Visible = true;
            btnAgregarTipoProducto.Visible = false;          
            btnAgregarLote.Visible = false;                 
            btnAgregarProductos.Visible = false;
            btnAgregarProveedor.Visible = false;
            btnAgregarBodega.Visible = false;
            btnAgregarDepositoBasura.Visible = false;
            btnAgregarAlmacena.Visible = false;
            pnlNav.Height = btnEmpleado.Height;
            pnlNav.Top = btnEmpleado.Top;
            btnEmpleado.BackColor = Color.FromArgb(24, 61, 85);
        }


        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormSecundarios?.Close();
            btnAgregarProductos.Visible = true; 
            btnAgregarProveedor.Visible = true;
            btnAgregarTipoProducto.Visible = true;
            btnAgregarLote.Visible = true;
            btnAgregarEmpleado.Visible = false;
            btnAgregarSucursal.Visible = false;                    
            btnAgregarBodega.Visible = false;
            btnAgregarDepositoBasura.Visible = false;
            btnAgregarAlmacena.Visible = false;
            pnlNav.Height = btnProducto.Height;
            pnlNav.Top = btnProducto.Top;
            btnProducto.BackColor = Color.FromArgb(24, 61, 85);
        }

        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            FormSecundarios?.Close();
            btnAgregarBodega.Visible = true;
            btnAgregarDepositoBasura.Visible = true;
            btnAgregarAlmacena.Visible = true;
            btnAgregarProductos.Visible = false;
            btnAgregarProveedor.Visible = false;
            btnAgregarTipoProducto.Visible = false;
            btnAgregarLote.Visible = false;
            btnAgregarEmpleado.Visible = false;
            btnAgregarSucursal.Visible = false;
            pnlNav.Height = btnAlmacenamiento.Height;
            pnlNav.Top = btnAlmacenamiento.Top;
            btnAlmacenamiento.BackColor = Color.FromArgb(24, 61, 85);
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarDescuento());
            pnlNav.Height = btnDescuento.Height;
            pnlNav.Top = btnDescuento.Top;
            btnDescuento.BackColor = Color.FromArgb(24, 61, 85);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirForm(new AgregarCompra());
            pnlNav.Height = btnCompra.Height;
            pnlNav.Top = btnCompra.Top;
            btnCompra.BackColor = Color.FromArgb(24, 61, 85);
        }
        #endregion

        #region Leave
        private void btnCliente_Leave(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEmpleado_Leave(object sender, EventArgs e)
        {
            btnEmpleado.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnProducto_Leave(object sender, EventArgs e)
        {
            btnProducto.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAlmacenamiento_Leave(object sender, EventArgs e)
        {
            btnAlmacenamiento.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDescuento_Leave(object sender, EventArgs e)
        {
            btnDescuento.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCompra_Leave(object sender, EventArgs e)
        {
            btnCompra.BackColor = Color.FromArgb(46, 51, 73);
        }


        #endregion


        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarEmpleado());
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarSucursal());
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarProducto());
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarProveedor());
        }

        private void btnAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarTipoProducto());
        }

        private void btnAgregarLote_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarLote());
        }

        private void btnAgregarBodega_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarBodega());
        }

        private void btnAgregarDepositoBasura_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarDepBasura());
        }

        private void btnAgregarAlmacena_Click(object sender, EventArgs e)
        {
            AbrirForm(new SeAlmacena());
        }

        private void btnConfigurarDescuento_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarDescuento());
        }
    }
}
