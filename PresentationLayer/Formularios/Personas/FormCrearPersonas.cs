namespace PresentationLayer.Formularios.Personas
{
    public partial class FormCrearPersonas : Form
    {
        public FormCrearPersonas()
        {
            InitializeComponent();
        }

        private void FormPersonas_Load(object sender, EventArgs e)
        {
            try
            {
                cmbGenero.DataSource = BusinessLayer.Servicios.Persona.GetGeneros();
                cmbGenero.DisplayMember = "GeneroNombre";
                cmbGenero.ValueMember = "Id";
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Modelos.Persona personaGuardar = new BusinessLayer.Modelos.Persona();
                personaGuardar.Identificacion = int.Parse(txtNumIdent.Text);
                personaGuardar.PrimerNombre = txtPriNombre.Text;
                personaGuardar.SegundoNombre = txtSegNombre.Text;
                personaGuardar.PrimerApellido = txtPriApellido.Text;
                personaGuardar.SegundoApellido = txtSegApellido.Text;
                personaGuardar.GeneroId = int.Parse(cmbGenero.SelectedValue.ToString());
                personaGuardar.Correo = txtCorreo.Text;
                personaGuardar.Telefono = txtTel.Text;
                personaGuardar.FechaNacimiento = dtpFechaNac.Value;

                BusinessLayer.Servicios.Persona.PostPersonas(personaGuardar);
                MessageBox.Show("Se creó correctamente la persona");

                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
