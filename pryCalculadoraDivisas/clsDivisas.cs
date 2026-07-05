using MySqlConnector;
using pryCalculadoraDivisas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pryCalculadoraDivisas
{
    internal class clsDivisas
    {
        private DataTable tabla;
        private MySqlDataAdapter consulta;

        //Para el combobox      -Hafizi
        public DataTable ObtenerMonedas()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT iddivisas, monedas, valor FROM tbldivisas;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de monedas: " + ex.Message);
            }
            return tabla;
        }
       
        public double CalcularConversion(double cantidad, double tasaCambio)
        {
            ///Metodo para calcular la conversion
            return cantidad * tasaCambio;
        }
    }
}
