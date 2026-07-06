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

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Se valida de que se haya seleccionado una moneda valida
            if (cmbMonedas.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor selecciona una moneda válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se valida si haya ingresado una cantidad valida
            if (!double.TryParse(txtCantidad.Text, out double cantidadIngresada))
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
            lblResultado.Text = "Resultado: " + resultado.ToString("N2", CultureInfo.CurrentCulture);
        }
    }
}
