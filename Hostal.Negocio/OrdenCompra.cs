using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace Hostal.Negocio
{
    public class OrdenCompra
    {
        OracleConnection OracleCon = new OracleConnection();
        public OrdenCompra()
        {
            try
            {
                Conexion con = new Conexion();

                OracleCon = con.Get_Connecion();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
        public OrdenCompra(string sqlcon)
        {
            try
            {
                OracleCon = new OracleConnection(sqlcon);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public bool CreateReserva(int huesped_id, int servicio_id, int habitacion_id, int tipo_servicio_id)
        {
            DataTable dt = new DataTable();
            try
            {
                System.Diagnostics.Debug.WriteLine(huesped_id);
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "INSERTAR_RESERVA_HABITACION";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("huesped_id", OracleDbType.Int32).Value = huesped_id;
                _OracleCommand.Parameters.Add("servicio_id", OracleDbType.Int32).Value = servicio_id;
                _OracleCommand.Parameters.Add("archivo", OracleDbType.Varchar2).Value = "Test"; //DATO EN DURO
                _OracleCommand.Parameters.Add("TOTAL", OracleDbType.Int32).Value = 0; //cambiar
                _OracleCommand.Parameters.Add("habitacion_id", OracleDbType.Int32).Value = habitacion_id;
                _OracleCommand.Parameters.Add("tipo_servicio_id", OracleDbType.Int32).Value = tipo_servicio_id;
                
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                OracleCon.Open();
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                _OracleDataAdapter.Fill(dt);
                
                
                OracleCon.Close();

                return true;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: "+ex);
                return false;
            }
        }

        public bool CreateReservaHuesped(string nombre, string apellido, string rut, int empresa_id,int habitacion_id,
            int servicio_id, string archivo, int precio,int tipo_servicio_id)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "RESERVA_HABITACION_HUESPED";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
                _OracleCommand.Parameters.Add("apellido", OracleDbType.Varchar2).Value = apellido;
                _OracleCommand.Parameters.Add("rut", OracleDbType.Varchar2).Value = rut; 
                _OracleCommand.Parameters.Add("empresa_id", OracleDbType.Int32).Value = empresa_id; 
                _OracleCommand.Parameters.Add("habitacion_id", OracleDbType.Int32).Value = habitacion_id;
                _OracleCommand.Parameters.Add("servicio_id", OracleDbType.Int32).Value = servicio_id;
                _OracleCommand.Parameters.Add("archivo", OracleDbType.Varchar2).Value = archivo;
                _OracleCommand.Parameters.Add("precio", OracleDbType.Int32).Value = precio;
                _OracleCommand.Parameters.Add("tipo_servicio_id", OracleDbType.Int32).Value = tipo_servicio_id;

                _OracleCommand.CommandType = CommandType.StoredProcedure;
                OracleCon.Open();
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                _OracleDataAdapter.Fill(dt);
                System.Diagnostics.Debug.WriteLine(dt.Rows.Count);

                OracleCon.Close();

                return true;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: " + ex);
                return false;
            }
        }
    }
}
