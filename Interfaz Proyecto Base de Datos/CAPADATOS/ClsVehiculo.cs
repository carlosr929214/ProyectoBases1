using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz_Proyecto_Base_de_Datos.CAPADATOS
{
    class ClsVehiculo
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarMecanicos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarMecanicos";
            //Procedimiento Almacenado, mire ing. denos puntos extras
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            //Siempre es buena practica de programacion cerrar la conexion
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarCliente()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCliente";
            //Procedimiento Almacenado, mire ing. denos puntos extras de nuevo 
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            //Siempre es buena practica de programacion cerrar la conexion
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarTaller()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarTaller";
            //Procedimiento Almacenado, mire ing. bueno ya no da risa 
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            //Siempre es buena practica de programacion cerrar la conexion
            Conexion.CerrarConexion();
            return Tabla;
        }

        /// <summary>
        /// Seria mejor hacerlo con Get y Set ya que es uno de los prioncipios de la POO pero por timepo lo vamos a haccer de esta manera
        /// 
        /// </summary>
        /// <param name=""></param>
        public void InsertarVehiculos(string idCliente, string mecAsignado, int tallerAsignado, string placa, string marca, string modelo, string numeroMotor,string color,DateTime fechaHoraIngreso)
        {

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarVehiculo";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@placa", placa);
            Comando.Parameters.AddWithValue("@idCliente", idCliente);
            Comando.Parameters.AddWithValue("@marca", marca);
            Comando.Parameters.AddWithValue("@modelo", modelo);
            Comando.Parameters.AddWithValue("@numeroMotor", numeroMotor);
            Comando.Parameters.AddWithValue("@color", color);
            Comando.Parameters.AddWithValue("@fechaHoraIngreso", fechaHoraIngreso);
            Comando.Parameters.AddWithValue("@tallerAsignado", tallerAsignado);
            Comando.Parameters.AddWithValue("@mecAsignado", mecAsignado);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public DataTable ListarAutomoviles()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarAutomoviles";
            //Procedimiento Almacenado, mire ing. bueno ya no da risa 
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            //Siempre es buena practica de programacion cerrar la conexion
            Conexion.CerrarConexion();
            return Tabla;
        }

    }
}
