using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostal.Negocio
{
    public class OrdenPedido
    {
        OracleConnection OracleCon = new OracleConnection();
        public OrdenPedido()
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


        public OrdenPedido(string sqlcon)
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

        public bool CreateOrdenPedido(int newCantidad, int newTotal, int newEmpleadoId, int newProveedorId, int newProductoId)
        {
            //System.Diagnostics.Debug.WriteLine(userN);
            DataTable dt = new DataTable();
            try
            {

                //
                OracleCommand _OracleCommand = new OracleCommand();
                _OracleCommand.CommandText = "INSERTAR_ORDEN_PEDIDO";
                _OracleCommand.Connection = OracleCon;
                _OracleCommand.CommandType = CommandType.StoredProcedure;

                //OracleCommand comando = new OracleCommand("INSERTAR_USUARIO_EMPLEADO", OracleCon);
                _OracleCommand.CommandType = CommandType.StoredProcedure;
                _OracleCommand.Parameters.Add("newCantidad", OracleDbType.Int32).Value = newCantidad;
                _OracleCommand.Parameters.Add("newTotal", OracleDbType.Int32).Value = newTotal;
                _OracleCommand.Parameters.Add("newEmpleadoId", OracleDbType.Int32).Value = newEmpleadoId;
                _OracleCommand.Parameters.Add("newProveedorId", OracleDbType.Int32).Value = newProveedorId;
                _OracleCommand.Parameters.Add("newProductoId", OracleDbType.Int32).Value = newProductoId;



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
                //System.Diagnostics.Debug.WriteLine(userN);
                return false;
            }
        }

    }
}
