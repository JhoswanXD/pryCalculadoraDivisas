using System.Data;

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
    }
}
