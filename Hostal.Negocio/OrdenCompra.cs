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

        public bool CreateReserva(int numHabitacion, int precio, int tipoCama)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "INSERTAR_RESERVA_HABITACION";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("HUESPED_ID", OracleDbType.Int32).Value = 1; //DATO EN DURO
                _OracleCommand.Parameters.Add("SERVICIO_ID", OracleDbType.Int32).Value = 1; //DATO EN DURO
                _OracleCommand.Parameters.Add("ARCHIVO", OracleDbType.Varchar2).Value = "Test"; //DATO EN DURO
                _OracleCommand.Parameters.Add("TOTAL", OracleDbType.Int32).Value = precio; //cambiar
                _OracleCommand.Parameters.Add("HABITACION_ID", OracleDbType.Int32).Value = numHabitacion;
                _OracleCommand.Parameters.Add("TIPO_SERVICIO_ID", OracleDbType.Int32).Value = 1; //DATO EN DURO


                /*_OracleCommand.Parameters.Add("TIPO_CAMA_ID", OracleDbType.Int32).Value = tipoCama;*/
                //_OracleCommand.Parameters.Add("estado", OracleDbType.Int32).Value = 1; //DATO EN DURO

                System.Diagnostics.Debug.WriteLine("TIPOCAMA: " + tipoCama);
                System.Diagnostics.Debug.WriteLine("HABITACION_ID: " + numHabitacion);
                System.Diagnostics.Debug.WriteLine("TOTAL: " + precio);
                //OracleCommand comando = new OracleCommand("INSERTAR_RESERVA_HABITACION", OracleCon);
                _OracleCommand.CommandType = CommandType.StoredProcedure;
            
                //_OracleCommand.ExecuteNonQuery();
                OracleCon.Open();
                OracleDataAdapter _OracleDataAdapter = new OracleDataAdapter(_OracleCommand);
                //_OracleDataAdapter.SelectCommand = _OracleCommand;
                _OracleDataAdapter.Fill(dt);
                System.Diagnostics.Debug.WriteLine(dt.Rows.Count);
                
                OracleCon.Close();

                return true;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: "+ex);
                return false;
            }
        }
    }
}
