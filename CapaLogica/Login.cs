using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Login
    {
        public int Id { get; set; }
        public string Pass { get; set; }

        Accesodatos Acceso = new Accesodatos();
        //pclr
        public void CheckLogin(int Id, string Pass)
        {
            string[] parametros = { "_Id", "_Pas" };


            if (Acceso.GetTabla("Login", parametros, Id, Pass).Columns.Count>0) {
                bool a;
                a = true;
            }
        }
    }

}
