using PresentationLayer.Formularios.CheckOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Formularios
{
    public partial class FormCheckOut : Form
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            CargarCheckOut();
        }

        private void CargarCheckOut()
        {
            dgCheckOut.DataSource = BusinessLayer.Servicios.CheckOut.GetCheckOut();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearCheckOut formCrearCheckOut = new FormCrearCheckOut();
            formCrearCheckOut.ShowDialog();
            CargarCheckOut();
        }
    }
}
