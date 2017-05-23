using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1
{
    public class gastos2
    {
        string idgastos;
        string descripcion;
        int impote;
        string zonareparto;

        public string Idgastos
        {
            get
            {
                return idgastos;
            }

            set
            {
                idgastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Impote
        {
            get
            {
                return impote;
            }

            set
            {
                impote = value;
            }
        }

        public string Zonareparto
        {
            get
            {
                return zonareparto;
            }

            set
            {
                zonareparto = value;
            }
        }
    }
}