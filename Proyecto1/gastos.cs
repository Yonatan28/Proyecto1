using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1
{
    public class gastos
    {
        string identifacion;
        string nombre;
        string tipoderepart;

        public string Identifacion
        {
            get
            {
                return identifacion;
            }

            set
            {
                identifacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tipoderepart
        {
            get
            {
                return tipoderepart;
            }

            set
            {
                tipoderepart = value;
            }
        }
    }
}