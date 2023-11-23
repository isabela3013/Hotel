using BusinessLayer.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.Formularios.Registros
{
    public partial class FormCrearRegistro : Form
    {
        private object random;
        private int numeroAleatorio;
        private List<BusinessLayer.Modelos.RegistroDetalle> detalle = new List<BusinessLayer.Modelos.RegistroDetalle>();
        private decimal total;

        public FormCrearRegistro()
        {
            InitializeComponent();
        }

        private void FormCrearRegistro_Load(object sender, EventArgs e)
        {
            CargarId();
            CargarPersonas();
            CargarServicios();
            CargarReservas();
        }

        private void CargarId()
        {
            Random random = new Random();
            numeroAleatorio = random.Next(10000, 99999);
        }

        private void CargarPersonas()
        {
            try
            {
                cmbClientes.DataSource = Persona.GetPersonas();
                cmbClientes.DisplayMember = "PrimerNombre";
                cmbClientes.ValueMember = "Identificacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CargarServicios()
        {
            try
            {
                cmbServicios.DataSource = Servicio.GetServicios();
                cmbServicios.DisplayMember = "ServicioNombre";
                cmbServicios.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CargarReservas()
        {
            try
            {
                cmbReservas.DataSource = BusinessLayer.Servicios.Reserva.GetReservasPendientes();
                cmbReservas.DisplayMember = "Id";
                cmbReservas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CargarDetalle()
        {
            dgDetalle.DataSource = ConsultarDetalle();
        }

        private List<BusinessLayer.Modelos.RegistroDetalle> ConsultarDetalle()
        {
            return detalle;
        }

        private void btnAgrDetalle_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == null)
            {
                MessageBox.Show("La cantidad está vacía.");
                return;
            }

            BusinessLayer.Modelos.Servicios servicioSelec = cmbServicios.SelectedItem as BusinessLayer.Modelos.Servicios;

            decimal totalArticulo = int.Parse(txtCantidad.Text) * servicioSelec.Precio;
            total += totalArticulo;

            BusinessLayer.Modelos.RegistroDetalle nuevoDetalle = new BusinessLayer.Modelos.RegistroDetalle
            {
                Id = numeroAleatorio + (100000 * (detalle.Count + 1)),
                RegistroId = numeroAleatorio,
                ServicioId = int.Parse(cmbServicios.SelectedValue.ToString()),
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioTotal = totalArticulo,
            };

            detalle.Add(nuevoDetalle);

            CargarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                BusinessLayer.Modelos.Registro registro = new BusinessLayer.Modelos.Registro
                {
                    ClienteId = int.Parse(cmbClientes.SelectedValue.ToString()),
                    RegistroFecha = DateTime.Now,
                    PrecioTotal = total,
                    ReservaId = int.Parse(cmbReservas.SelectedValue.ToString()),
                    Id = numeroAleatorio
                };

                BusinessLayer.Servicios.Registro.PostRegistro(registro);

                foreach (BusinessLayer.Modelos.RegistroDetalle d in detalle)
                {
                    BusinessLayer.Servicios.Registro.PostRegistroDetalle(d);
                }

                MessageBox.Show("Se creó el registro correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
