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
        string nitpropietario;
        List<string> gastos;
        List<string> listapor;
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

        public string Nitpropietario
        {
            get
            {
                return nitpropietario;
            }

            set
            {
                nitpropietario = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }

        public List<string> Listapor
        {
            get
            {
                return listapor;
            }

            set
            {
                listapor = value;
            }
        }
    }
}