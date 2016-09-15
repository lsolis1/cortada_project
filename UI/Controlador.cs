using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MaterialSkin.Controls;
using System.Windows.Forms;

namespace UI
{
    public  static class Controlador
    {

        public  static bool SoloNumeros(string _cadena)
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
            if (bandera > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        //asdasd
        public static bool SoloLetras(string _cadena)
        {
            var ComprobarCadena = _cadena.ToCharArray();
            var bandera = 0;

            for (int i = 0; i < ComprobarCadena.Length; i++)
            {
                if (Char.IsLetter(ComprobarCadena[i]) == true || Char.IsWhiteSpace(ComprobarCadena[i]) == true)
                {

                }
                else
                {
                    bandera = bandera + 1;
                }
            }

            if (bandera > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool SoloLetrasYnumeros(string _cadena)
        {
            var ComprobarCadena = _cadena.ToCharArray();
            var bandera = 0;
            for (int i = 0; i < ComprobarCadena.Length; i++)
            {
                if (Char.IsLetter(ComprobarCadena[i]) == true || Char.IsDigit(ComprobarCadena[i]) == true || Char.IsWhiteSpace(ComprobarCadena[i]) == true)
                {

                }
                else
                {
                    bandera = bandera + 1;
                }
            }

            if (bandera > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //1 espacio por palabra (keyPress)
        public static void EspaciosKeyPress(KeyPressEventArgs _letra, object sender)
        {
            TextBox tb = (TextBox)sender;
            if ((_letra.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    _letra.Handled = true;
            }
        }


        //controlar que los txtBox tengan valores
        public static bool TxtconValores(string _cadena)
        {
            if (!string.IsNullOrWhiteSpace(_cadena))
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
