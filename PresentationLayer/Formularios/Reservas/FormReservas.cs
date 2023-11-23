using PresentationLayer.Formularios.Reservas;

namespace PresentationLayer.Formularios
{
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearReserva formCrearReserva = new FormCrearReserva();
            formCrearReserva.ShowDialog();
            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                dgReservas.DataSource = BusinessLayer.Servicios.Reserva.GetReservas();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
