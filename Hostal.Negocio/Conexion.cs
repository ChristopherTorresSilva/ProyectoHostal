using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Hostal.Negocio
{
    public class Conexion
    {
        public OracleConnection Get_Connecion()
        {
            return new  OracleConnection("DATA SOURCE = XE ; PASSWORD = 123 ; USER ID = hostal");
        }
    }
}
