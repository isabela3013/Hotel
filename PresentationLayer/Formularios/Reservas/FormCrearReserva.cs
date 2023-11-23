using BusinessLayer.Servicios;
using PresentationLayer.Formularios.Personas;
using System;

namespace PresentationLayer.Formularios.Reservas
{
    public partial class FormCrearReserva : Form
    {
        private object random;
        private List<BusinessLayer.Modelos.ReservaDetalle> detalle = new List<BusinessLayer.Modelos.ReservaDetalle>();
        private int numeroAleatorio;

        public FormCrearReserva()
        {
            InitializeComponent();
        }

        private void FormCrearReserva_Load(object sender, EventArgs e)
        {
            CargarId();
            CargarPersonas();
            CargarHabitaciones();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            FormCrearPersonas form = new FormCrearPersonas();
            form.ShowDialog();
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            try
            {
                cmbClientes.DataSource = Persona.GetPersonas();
                cmbClientes.DisplayMember = "PrimerNombre";
                cmbClientes.ValueMember = "Identificacion";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarHabitaciones()
        {
            try
            {
                List<BusinessLayer.Modelos.Habitacion> hab = new List<BusinessLayer.Modelos.Habitacion>();
                hab = Habitacion.GetHabitaciones();
                cmbHabitaciones.DataSource = hab.Where(x => x.Ocupada == false).ToList();
                cmbHabitaciones.DisplayMember = "Numero";
                cmbHabitaciones.ValueMember = "Id";
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
                BusinessLayer.Modelos.Reserva reserva = new BusinessLayer.Modelos.Reserva
                {
                    ClienteId = int.Parse(cmbClientes.SelectedValue.ToString()),
                    Personas = int.Parse(txtPersonas.Text),
                    Id = numeroAleatorio
                };

                BusinessLayer.Servicios.Reserva.PostReservas(reserva);

                foreach (BusinessLayer.Modelos.ReservaDetalle d in detalle)
                {
                    BusinessLayer.Servicios.Reserva.PostReservaDetalle(d);
                    BusinessLayer.Servicios.Habitacion.PutHabitacionOcupada(d.HabitacionId, true);
                }

                MessageBox.Show("Se creó la reserva correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgrDetalle_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == null)
            {
                MessageBox.Show("La cantidad está vacía.");
                return;
            }

            BusinessLayer.Modelos.ReservaDetalle nuevoDetalle = new BusinessLayer.Modelos.ReservaDetalle
            {
                Id = numeroAleatorio + (10000000 * (detalle.Count + 1)),
                ReservaId = numeroAleatorio,
                HabitacionId = int.Parse(cmbHabitaciones.SelectedValue.ToString()),
                Cantidad = int.Parse(txtCantidad.Text),
                FechaEntrada = DateTime.Now,
                FechaSalida = DateTime.Now.AddDays(7)
            };

            detalle.Add(nuevoDetalle);

            CargarDetalle();
        }

        private void CargarId()
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1000000, 9999999);
        }

        private void CargarDetalle()
        {
            dgDetalle.DataSource = detalle;
        }
    }
}
