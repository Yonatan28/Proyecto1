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
        List<propiedad> listapropiedad = new List<propiedad>();
        List<gastos> listagastos = new List<gastos>();
        List<gastos2> listagastos2 = new List<gastos2>();
        List<loca> listalocal = new List<loca>();
        List<piso> listapiso = new List<piso>();
        List<Garaje> listagaraje = new List<Garaje>();

       public void archivos(bool a,bool b,bool c,bool d,bool e)
        {
            if (a==true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.comunidad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyecto1.comunidad.txt"));
                while (_textStreamReader.Peek() > -1)
                {
                    comunidad comuntemp = new comunidad();
                    comuntemp.Identificacion = _textStreamReader.ReadLine();
                    comuntemp.Nombre = _textStreamReader.ReadLine();
                    comuntemp.Poblacion = _textStreamReader.ReadLine();
                    listacomunidad.Add(comuntemp);
                }
                _textStreamReader.Close();
            }
            if (b == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.gastos.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyecto1.gastos.txt"));
                while (_textStreamReader.Peek() > -1)
                {
                    gastos gastotemp = new gastos();
                    gastotemp.Identifacion = _textStreamReader.ReadLine();
                    gastotemp.Nombre = _textStreamReader.ReadLine();
                    gastotemp.Tipoderepart = _textStreamReader.ReadLine();
                    listagastos.Add(gastotemp);
                }
                _textStreamReader.Close();

            }
           
            if (c == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.datospropietarios.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyecto1.datospropietarios.txt"));

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
            if (d == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.gastos2.txt.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyecto1.gastos2.txt.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    gastos2 gastostemp = new gastos2();
                    gastostemp.Idgastos = _textStreamReader.ReadLine();
                    gastostemp.Descripcion = _textStreamReader.ReadLine();
                    gastostemp.Impote = Convert.ToInt32(_textStreamReader.ReadLine());
                    gastostemp.Zonareparto = _textStreamReader.ReadLine();
                    listagastos2.Add(gastostemp);
                }
                _textStreamReader.Close();
            }
            if (e==true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyecto1.gastos2.txt.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyecto1.gastos2.txt.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    gastos2 gastostemp = new gastos2();
                    gastostemp.Idgastos = _textStreamReader.ReadLine();
                    gastostemp.Descripcion = _textStreamReader.ReadLine();
                    gastostemp.Impote = Convert.ToInt32(_textStreamReader.ReadLine());
                    gastostemp.Zonareparto = _textStreamReader.ReadLine();
                    listagastos2.Add(gastostemp);
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