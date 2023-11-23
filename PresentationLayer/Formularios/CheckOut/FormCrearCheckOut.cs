namespace PresentationLayer.Formularios.CheckOut
{
    public partial class FormCrearCheckOut : Form
    {
        private object random;
        private int numeroAleatorio;
        public decimal totalReserva;
        public decimal totalReservaH;
        public decimal totalReservaS;
        public decimal descuento;
        public List<BusinessLayer.Modelos.ReservaDetalle> detalle = new List<BusinessLayer.Modelos.ReservaDetalle>();
        public List<BusinessLayer.Modelos.RegistroDetalle> detalleRegistro = new List<BusinessLayer.Modelos.RegistroDetalle>();

        public FormCrearCheckOut()
        {
            InitializeComponent();
        }

        private void FormCrearCheckOut_Load(object sender, EventArgs e)
        {
            CargarReservas();
            CargarMediosPago();
            CargarId();
        }

        private void CargarId()
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1000, 9999);
        }

        private void CargarReservas()
        {
            try
            {
                cmbReservas.DataSource = BusinessLayer.Servicios.Reserva.GetReservasPendientes();
                cmbReservas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void CargarMediosPago()
        {
            try
            {
                cmbMedioPago.DataSource = BusinessLayer.Servicios.CheckOut.GetMediosPago();
                cmbMedioPago.DisplayMember = "MedioPagoNombre";
                cmbMedioPago.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CargarReservaItems()
        {
            try
            {
                BusinessLayer.Modelos.Reserva reservaSelect = cmbReservas.SelectedItem as BusinessLayer.Modelos.Reserva;

                detalle = BusinessLayer.Servicios.Reserva.GetReservaDetalle(reservaSelect.Id);

                var hab = BusinessLayer.Servicios.Habitacion.GetHabitaciones();

                List<ReservaItems> reservaItems = new List<ReservaItems>();

                foreach (var item in detalle)
                {
                    decimal totalItem = item.Cantidad * hab.Find(x => x.Id == item.HabitacionId).TipoHabitacion.Precio;
                    totalReservaH += totalItem;

                    ReservaItems itemDetalle = new ReservaItems
                    {
                        Habitacion = hab.Find(x => x.Id == item.HabitacionId).Numero,
                        Tipo = hab.Find(x => x.Id == item.HabitacionId).TipoHabitacion.TipoNombre,
                        Cantidad = item.Cantidad,
                        Precio = hab.Find(x => x.Id == item.HabitacionId).TipoHabitacion.Precio,
                        Total = totalItem,
                    };

                    reservaItems.Add(itemDetalle);
                }

                ValidarDescuento(reservaSelect);

                lblTotalReservaH.Text = totalReservaH.ToString();
                dgReservaItems.DataSource = reservaItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarDescuento(BusinessLayer.Modelos.Reserva reserva)
        {
            var cliente = BusinessLayer.Servicios.Persona.GetPersonaById(reserva.ClienteId);

            int edad = DateTime.Now.Year - cliente.FechaNacimiento.Year;

            if (edad > 65)
            {
                descuento = 0.25m;
            }
            else if (edad < 5)
            {
                descuento = 0.15m;
            }
            else
            {
                descuento = 0.5m;
            }

            decimal desc = totalReservaH * descuento;
            totalReservaH = totalReservaH - desc;
        }

        private void CargarServiciosItems()
        {
            try
            {
                var reservaSeleccionada = cmbReservas.SelectedItem as BusinessLayer.Modelos.Reserva;
                var registros = BusinessLayer.Servicios.Registro.GetRegistroId(reservaSeleccionada.Id);

                List<ServicioItems> listItems = new List<ServicioItems>();

                foreach (var registro in registros)
                {
                    var servicios = BusinessLayer.Servicios.Servicio.GetServicios();

                    detalleRegistro = BusinessLayer.Servicios.Registro.GetRegistroDetalle(registro.Id);

                    foreach (var item in detalleRegistro)
                    {
                        BusinessLayer.Modelos.Servicios servicioActual = new BusinessLayer.Modelos.Servicios();
                        servicioActual = servicios.Find(x => x.Id == item.ServicioId);

                        ServicioItems servicioItems = new ServicioItems
                        {
                            Servicio = servicioActual.ServicioNombre,
                            Cantidad = item.Cantidad,
                            Precio = servicioActual.Precio,
                            Total = item.Cantidad * servicioActual.Precio,
                        };
                        totalReservaS += item.Cantidad * servicioActual.Precio;
                        listItems.Add(servicioItems);
                    }
                }

                lblTotalReservaS.Text = totalReservaS.ToString();
                dgServicios.DataSource = listItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private class ReservaItems
        {
            public int Habitacion { get; set; }
            public string Tipo { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Total { get; set; }
        }

        private class ServicioItems
        {
            public string Servicio { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Total { get; set; }
        }

        private void cmbReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarReservaItems();
            CargarServiciosItems();

            totalReserva = totalReservaH + totalReservaS;
            lblTotalReserva.Text = totalReserva.ToString();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var reservaSeleccionada = cmbReservas.SelectedItem as BusinessLayer.Modelos.Reserva;

                BusinessLayer.Modelos.CheckOut checkOut = new BusinessLayer.Modelos.CheckOut
                {
                    Id = numeroAleatorio,
                    ReservaId = reservaSeleccionada.Id,
                    FechaSalida = DateTime.Now,
                    PrecioTotal = totalReserva,
                    MedioPagoId = int.Parse(cmbMedioPago.SelectedValue.ToString()),
                    Descuento = descuento
                };

                BusinessLayer.Servicios.CheckOut.PostCheckOut(checkOut);

                foreach (var d in detalle)
                {
                    BusinessLayer.Servicios.Habitacion.PutHabitacionOcupada(d.HabitacionId, false);
                }
                MessageBox.Show("Se creó correctamente el checkout");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
