using System.Data;

namespace PresentationLayer.Formularios.Dashboard
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            CargarCantidadesClientes();
        }

        private void CargarCantidadesClientes()
        {
            #region Cantidad Huespedes
            // Carga los valores para la suma de los huéspedes
            var clientes = BusinessLayer.Servicios.Persona.GetPersonas();
            int totalClientes = clientes.Count;
            lblTotalClientes.Text = totalClientes.ToString();

            // Carga los valores para la suma de los géneros
            var masculinos = clientes.Where(x => x.GeneroId == 1).ToList();
            int totalClientesM = masculinos.Count;
            lblTotMasc.Text = totalClientesM.ToString();

            // Carga los valores para la suma de los géneros
            var femeninos = clientes.Where(x => x.GeneroId == 2).ToList();
            int totalClientesF = femeninos.Count;
            lblTotFem.Text = totalClientesF.ToString();

            #region Porcentaje Cantidad Huespedes por genero
            // Carga los porcentajes
            double porcentajeM = ((double)totalClientesM / totalClientes) * 100;
            lblPorHM.Text = porcentajeM.ToString();
            double porcentajeF = ((double)totalClientesF / totalClientes) * 100;
            lblPorHF.Text = porcentajeF.ToString();
            #endregion

            #endregion

            #region Dinero Recaudado
            // Carga los valores del dinero recaudado
            var checkouts = BusinessLayer.Servicios.CheckOut.GetCheckOut();
            decimal totalDinero = checkouts.Sum(check => check.PrecioTotal);
            lblTotalDinero.Text = totalDinero.ToString();
            #endregion

            #region Dinero por Medio Pago
            // Carga los valores del dinero recaudado por medio de pago
            var totalDEfectivo = checkouts.Where(x => x.MedioPagoId == 1)
                .Sum(check => check.PrecioTotal);
            lblTotalDE.Text = totalDEfectivo.ToString();

            var totalDDebito = checkouts.Where(x => x.MedioPagoId == 2)
                .Sum(check => check.PrecioTotal);
            lblTotalDD.Text = totalDDebito.ToString();

            var totalDCredito = checkouts.Where(x => x.MedioPagoId == 3)
                .Sum(check => check.PrecioTotal);
            lblTotalDC.Text = totalDCredito.ToString();

            // Carga los porcentajes
            decimal porcentajeDEfectivo = (totalDEfectivo / totalDinero) * 100;
            lblPorDE.Text = porcentajeDEfectivo.ToString();

            decimal porcentajeDDebito = (totalDDebito / totalDinero) * 100;
            lblPorDD.Text = porcentajeDDebito.ToString();

            decimal porcentajeDCredito = (totalDCredito / totalDinero) * 100;
            lblPorDC.Text = porcentajeDCredito.ToString();
            #endregion

            #region Dinero por Género
            // Carga los valores del dinero recaudado por genero
            var checkoutsM = BusinessLayer.Servicios.CheckOut.GetCheckOutByGenero(1);
            decimal totalDineroM = checkoutsM.Sum(check => check.PrecioTotal);
            lblTotalDineroM.Text = totalDineroM.ToString();

            var checkoutsF = BusinessLayer.Servicios.CheckOut.GetCheckOutByGenero(2);
            decimal totalDineroF = checkoutsF.Sum(check => check.PrecioTotal);
            lblTotalDineroF.Text = totalDineroF.ToString();

            // Carga los porcentajes
            decimal porcentajeDM = (totalDineroM / totalDinero) * 100;
            lblPorDM.Text = porcentajeDM.ToString();

            decimal porcentajeDF = (totalDineroF / totalDinero) * 100;
            lblPorDF.Text = porcentajeDF.ToString();
            #endregion

            #region Clientes con mas y menos Pago
            // Carga el nombre del cliente que más pagó
            var personaMas = BusinessLayer.Servicios.Persona.GetPersonaByPago("mayor");
            lblNomCliMas.Text = personaMas.PrimerNombre + " " + personaMas.SegundoNombre + " " + personaMas.PrimerApellido + " " + personaMas.SegundoApellido;

            // Carga el nombre del cliente que menos pagó
            var personaMenos = BusinessLayer.Servicios.Persona.GetPersonaByPago("menor");
            lblNomCliMenos.Text = personaMenos.PrimerNombre + " " + personaMenos.SegundoNombre + " " + personaMenos.PrimerApellido + " " + personaMenos.SegundoApellido;
            #endregion

            #region Edades
            var edad = BusinessLayer.Servicios.CheckOut.GetCheckOut();
            int totalEdad = edad.Count;
            lblTotalE.Text = totalEdad.ToString();

            var menor5 = edad.Where(x => x.Descuento == decimal.Parse("0.15")).ToList();
            int totalMenor5 = menor5.Count;
            lblTotE5.Text = totalMenor5.ToString();

            var mayor65 = edad.Where(x => x.Descuento == decimal.Parse("0.25")).ToList();
            int totalMayor65 = mayor65.Count;
            lblTotalE65.Text = totalMayor65.ToString();

            var demas = edad.Where(x => x.Descuento == decimal.Parse("0.5")).ToList();
            int totalDemas = demas.Count;
            lblTotalED.Text = totalDemas.ToString();

            #region Porcentaje Cantidad Huespedes por genero
            // Carga los porcentajes
            double porcentajeE5 = ((double)totalMenor5 / totalEdad) * 100;
            lblPorE5.Text = porcentajeE5.ToString();
            double porcentajeE65 = ((double)totalMayor65 / totalEdad) * 100;
            lblPorE65.Text = porcentajeE65.ToString();
            double porcentajeED = ((double)totalDemas / totalEdad) * 100;
            lblPorED.Text = porcentajeED.ToString();
            #endregion

            #endregion

        }
    }
}
