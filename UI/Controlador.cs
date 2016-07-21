using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Controlador
    {
        public Controlador()
        {

        }

        public bool SoloNumeros(string _cadena)
        {
            //convertimos la cadena en un charArray y lo recorremos.
            var comprobarCadena = _cadena.ToCharArray();
            var bandera = 0;

            for (int i = 0; i < comprobarCadena.Length; i++)
            {
                if (Char.IsDigit(comprobarCadena[i]))
                {

                }
                else
                {
                    bandera = bandera + 1;
                }
            }

            //Si es false indica que hay 1 o mas letras, si da true significa que la cadena contiene todos numeros 
            if (bandera>0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool SoloLetras(string _cadena)
        {
            var ComprobarCadena = _cadena.ToCharArray();
            var bandera = 0;

            for (int i = 0; i < ComprobarCadena.Length; i++)
            {
                if (Char.IsLetter(ComprobarCadena[i])==true || Char.IsWhiteSpace(ComprobarCadena[i])==true)
                {

                }
                else
                {
                    bandera = bandera + 1;
                }
            }

            if (bandera>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
