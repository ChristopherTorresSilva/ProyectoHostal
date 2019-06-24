using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Hostal.Negocio;
using System.Data;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Hostal.Servicio
{
    /// <summary>
    /// Descripción breve de ServicioHostal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]


    //IMPORTANTE!!
    //URL DEL SERVICIO http://localhost:63876/ServicioHostal.asmx

    public class ServicioHostal : System.Web.Services.WebService
    {
        [WebMethod]
        public bool login(string user, string pass)
        {
            Boolean _resp = false;
            try
            {
                USUARIO usuario = new USUARIO();
                _resp = usuario.login(user, pass);
                return _resp;
            }
            catch (Exception)
            {

                return _resp;
            }
        }

        [WebMethod]
        public bool CreateProveedor(string userN,int perfil,string rut,string nombre,string telefono,string correo,int rubro)
        {
            Boolean _resp = false;
            try
            {
                PROVEEDOR proveedor = new PROVEEDOR();
                _resp = proveedor.CreateProveedor(userN, perfil, rut, nombre, telefono, correo, rubro);
                return _resp;
            }
            catch (Exception)
            {
                return _resp;
            }
            
        }

        [WebMethod]
        public bool CreateEmpleados(string userN, int perfil, string rut, string nombre,string apellido,int cargo)
        {
            Boolean _resp = false;
            try
            {
                EMPLEADO empleados = new EMPLEADO();
                _resp = empleados.CreateEmpleados(userN, perfil, rut, nombre, apellido, cargo);
                return _resp;
            }
            catch (Exception)
            {
                return _resp;
            }

        }

        [WebMethod]
        public bool CreateEmpresa(string userN,int perfil,string rut, string nombre,string correo)
        {
            Boolean _resp = false;
            try
            {
                EMPRESA empresa = new EMPRESA();
                _resp = empresa.CreateEmpresa(userN, perfil, rut, nombre, correo);
                return _resp;
            }
            catch (Exception)
            {
                return _resp;
            }

        }
        
        [WebMethod]
        public string ListaUsuarios()
        {
            DataTable dt = null;
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            try
            {
                USUARIO usuario = new USUARIO();
                dt = usuario.ListaUsuarios();
                System.Diagnostics.Debug.WriteLine("Bien");
                
                //dt.WriteXml();

                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(dt);
                System.Diagnostics.Debug.WriteLine(JSONString);
                System.Diagnostics.Debug.WriteLine(dt);
                return JSONString;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return "Vacío";
            }
        }

        [WebMethod]
        public string ListaPerfiles()
        {
            DataTable dt = null;
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            try
            {
                Perfiles perfiles = new Perfiles();
                dt = perfiles.ListaPerfiles();
                System.Diagnostics.Debug.WriteLine(dt);
                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(dt);
                return JSONString;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return "Vacío";
            }
        }

        [WebMethod]
        public string ListaCargos()
        {
            DataTable dt = null;
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            try
            {
                Cargos cargos = new Cargos();
                dt = cargos.ListaCargos();
                System.Diagnostics.Debug.WriteLine(dt);
                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(dt);
                return JSONString;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return "Vacío";
            }
        }
    }
}
