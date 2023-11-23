namespace PresentationLayer.Formularios.Registros
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            CargarServicios();
            CargarRegistros();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormCrearRegistro frm = new FormCrearRegistro();
            frm.ShowDialog();
            CargarRegistros();
        }

        private void CargarServicios()
        {
            try
            {
                dgServicios.DataSource = BusinessLayer.Servicios.Servicio.GetServicios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CargarRegistros()
        {
            try
            {
                dgRegistros.DataSource = BusinessLayer.Servicios.Registro.GetRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
