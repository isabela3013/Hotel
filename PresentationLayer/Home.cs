using PresentationLayer.Formularios;
using PresentationLayer.Formularios.Dashboard;
using PresentationLayer.Formularios.Personas;
using PresentationLayer.Formularios.Registros;

namespace PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            FormDashboard fmr = new FormDashboard();
            fmr.TopLevel = false;
            fmr.Parent = panelFondo;
            fmr.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            FormReservas fmRes = new FormReservas();
            fmRes.TopLevel = false;
            fmRes.Parent = panelFondo;
            fmRes.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            FormPersonas formPer = new FormPersonas();
            formPer.TopLevel = false;
            formPer.Parent = panelFondo;
            formPer.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            FormRegistros formReg = new FormRegistros();
            formReg.TopLevel = false;
            formReg.Parent = panelFondo;
            formReg.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelFondo.Controls.Clear();
            FormCheckOut formChO = new FormCheckOut();
            formChO.TopLevel = false;
            formChO.Parent = panelFondo;
            formChO.Show();
        }
    }
}
