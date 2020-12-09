using AppTipika.PersonDAL.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTipika.PersonDAL
{
    public class LoginDal
    {
        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();

        public static bool ExisteUsuario(string nombreUsuario, string password)
        {
            if (adaptador.ExisteUsuario(nombreUsuario, password) == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool EstadoPassword()
        {
            if (adaptador.EstadoPassword() == null)
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