using DAL.Contratos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    public sealed class Factory
    {

        private readonly static Factory _instance = new Factory();

        private string backend;

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            //Implement here the initialization of your singleton

            backend = ConfigurationManager.AppSettings["backend"];
        }


        public IRVenta<Boleto> GetRepositorioVenta()
        {


            return new Repositorios.SQLServer.RepositorioVenta();

            /*if (backend == "SQLv")
            {
                return new Repositorios.SQLServer.RepositorioVenta();
            }
            else
            {
                return new Repositorios.MySQL.RepositorioVenta();
            }*/
        }

    }
}
