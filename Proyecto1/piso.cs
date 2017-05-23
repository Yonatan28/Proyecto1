using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1
{
    public class piso: propiedad
    {
        string vhvn;
        string habitacion;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public string Habitacion
        {
            get
            {
                return habitacion;
            }

            set
            {
                habitacion = value;
            }
        }
    }
}