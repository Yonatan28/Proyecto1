using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1
{
    public class propiedad
    {
        string tipopropiedad;
        string codigoinden;
        int metroscuadrados;
        string nit;
        string listaporcen;

        public string Tipopropiedad
        {
            get
            {
                return tipopropiedad;
            }

            set
            {
                tipopropiedad = value;
            }
        }

        public string Codigoinden
        {
            get
            {
                return codigoinden;
            }

            set
            {
                codigoinden = value;
            }
        }

        public int Metroscuadrados
        {
            get
            {
                return metroscuadrados;
            }

            set
            {
                metroscuadrados = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Listaporcen
        {
            get
            {
                return listaporcen;
            }

            set
            {
                listaporcen = value;
            }
        }
    }
}