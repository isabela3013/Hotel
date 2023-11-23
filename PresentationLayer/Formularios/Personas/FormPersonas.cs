namespace PresentationLayer.Formularios.Personas
{
    public partial class FormPersonas : Form
    {
        public FormPersonas()
        {
            InitializeComponent();
        }

        private void FormPersonas_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearPersonas frm = new FormCrearPersonas();
            frm.ShowDialog();
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            dgPersonas.DataSource = BusinessLayer.Servicios.Persona.GetPersonas();
        }
    }
}
