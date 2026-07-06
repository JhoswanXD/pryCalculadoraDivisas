using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace pryCalculadoraDivisas
{
    public partial class frmDivisas : Form
    {
        clsDivisas divisas;

        public frmDivisas()
        {
            InitializeComponent();
            CargarCombos();
        }

        public void CargarCombos()
        {
            divisas = new clsDivisas();

            try
            {
                DataTable dtMonedas = divisas.ObtenerMonedas();

                // Creamos la fila del placeholder para la Moneda
                DataRow filaPMonedas = dtMonedas.NewRow();
                filaPMonedas["iddivisas"] = 0;
                filaPMonedas["monedas"] = "-- Selecciona una Moneda --";

                filaPMonedas["valor"] = 0.0;

                dtMonedas.Rows.InsertAt(filaPMonedas, 0);

                cmbMonedas.DisplayMember = "monedas";
                cmbMonedas.ValueMember = "iddivisas";
                cmbMonedas.DataSource = dtMonedas;
                cmbMonedas.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }
        private void CalculoEnTiempoReal()
        {
            
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                lblResultado.Text = "Resultado: 0.00";
                return;
            }

            bool resp = !double.TryParse(txtCantidad.Text, out double cantidadIngresada);
            // Se valida si haya ingresado una cantidad valida
            if (resp)
            {
                MessageBox.Show("Ingresa una cantidad numérica válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView fila = (DataRowView)cmbMonedas.SelectedItem;

            if (fila == null)
            {
                MessageBox.Show("Elemento seleccionado inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tasaIngresada = Convert.ToDouble(fila["valor"]);

            //Aqui se muestra el resultado
            double resultado = divisas.CalcularConversion(cantidadIngresada, tasaIngresada);
            lblResultado.Text = "Resultado: " + resultado.ToString("N2");
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalculoEnTiempoReal();
        }

        private void cmbMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculoEnTiempoReal();
        }
    }
}
