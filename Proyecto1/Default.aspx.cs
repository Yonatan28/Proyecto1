using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;

namespace Proyecto1
{
    public partial class _Default : Page
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<datospropietarios> listadatospropiedad = new List<datospropietarios>();
        List<gastos> listagastos = new List<gastos>();
        List<gastos2> listagastos2 = new List<gastos2>();
        List<loca> listalocal = new List<loca>();
        List<piso> listapiso = new List<piso>();
        List<Garaje> listagaraj = new List<Garaje>();

        public void  cargando (bool a, bool b, bool c) {

       
            if (a == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.comunidad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("examenrepaso2.comunidad.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    comunidad comutemp = new comunidad();
                    comutemp.Identificacion = _textStreamReader.ReadLine();
                    comutemp.Nombre = _textStreamReader.ReadLine();
                    comutemp.Nombre =_textStreamReader.ReadLine();
                    listacomunidad.Add(comutemp);
                }
                _textStreamReader.Close();
            }
            if (b == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.datospropietarios.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("examenrepaso2.datospropietarios.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    datospropietarios datostemp = new datospropietarios();
                    datostemp.Nombre = _textStreamReader.ReadLine();
                    datostemp.Nit = _textStreamReader.ReadLine();
                    datostemp.Email = _textStreamReader.ReadLine();


                    listadatospropiedad.Add(datostemp);
                }
                _textStreamReader.Close();
            }
            if (c == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.gastos.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("examenrepaso2.gastos.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    gastos gastostemp = new gastos();
                    gastostemp.Identifacion = _textStreamReader.ReadLine();
                    gastostemp.Nombre = _textStreamReader.ReadLine();
                    gastostemp.Tipoderepart =_textStreamReader.ReadLine();
                    
                    listagastos.Add(gastostemp);
                }
                _textStreamReader.Close();
            }
            //trmino 1 lista



        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}