using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz_Proyecto_Base_de_Datos.CAPADATOS
{
    class ConexionBD
    {
        //Conexion con el SQL Server
        static private string CadenaConexion = "Data Source=TURBOPC\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        //Encapsulamiento y seguridad
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {

            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }



    }
}
