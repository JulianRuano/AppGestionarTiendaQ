using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using appGestionarTiendaQ.formularioPrincipales;
using appGestionarTiendaQ.consultas;
namespace appGestionarTiendaQ
{
    public partial class MenuPrincipal : Form
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
        public MenuPrincipal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnRegistrar.Height;
            pnlNav.Top = btnRegistrar.Top;
            pnlNav.Left = btnRegistrar.Left;
            btnRegistrar.BackColor = Color.FromArgb(46, 51, 73);
            AbrirForm(new MenuRegistrar());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirForm(new MenuRegistrar());
            pnlNav.Height = btnRegistrar.Height;
            pnlNav.Top = btnRegistrar.Top;
            pnlNav.Left = btnRegistrar.Left;
            btnRegistrar.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirForm(new ClienteSucursal());
            pnlNav.Height = btnConsultar.Height;
            pnlNav.Top = btnConsultar.Top;
            btnConsultar.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRegistrar_Leave(object sender, EventArgs e)
        {           
            btnRegistrar.BackColor = Color.FromArgb(24,30,54);
        }

        private void btnConsultar_Leave(object sender, EventArgs e)
        {

            btnConsultar.BackColor = Color.FromArgb(24, 30, 54);
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

        private void btnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
