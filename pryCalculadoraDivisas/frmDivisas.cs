using System.Data;
using System.Globalization;

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
                // Creamos la fila del placeholder para la Moneda1
                DataRow filaPMonedas = dtMonedas.NewRow();
                filaPMonedas["iddivisas"] = 0;
                filaPMonedas["monedas"] = "-- Selecciona una Moneda --";
                dtMonedas.Rows.InsertAt(filaPMonedas, 0); // Insertar al inicio de la lista

                // Enlazamos los datos al ComboBox visual
                cmbMonedas.DataSource = dtMonedas;
                cmbMonedas.DisplayMember = "monedas"; // El texto visible
                cmbMonedas.ValueMember = "iddivisas";       // La llave primaria real
                cmbMonedas.SelectedIndex = 0;               // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }

        private void cmbMonedas_Click(object sender, EventArgs e)
        {
            try
            {
                ///Valida que el usuario no haya seleccionado el placeholder "-- Selecciona una Moneda --"
                if (cmbMonedas.SelectedIndex == 0)
                {
                    MessageBox.Show("Selecciona una moneda de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtCantidad.Text, out double cantidad))
                {
                    MessageBox.Show("Ingresa una cantidad numerica valida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCantidad.Text, out double cantidadIngresada))
            {
                MessageBox.Show("Ingresa una cantidad numérica válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(txtCantidad.Text, out double tasaIngresada))
            {
                MessageBox.Show("La tasa de cambio no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMonedas.SelectedIndex == 0 || cmbMonedas.SelectedIndex == 0)
            {
                MessageBox.Show("Elemento seleccionado inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView fila = (DataRowView)cmbMonedas.SelectedItem;

            if (fila == null)
            {
                MessageBox.Show("Elemento seleccionado inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = divisas.CalcularConversion(cantidadIngresada, tasaIngresada);
            lblResultado.Text = resultado.ToString("N2", CultureInfo.CurrentCulture);
        }
    }
}
