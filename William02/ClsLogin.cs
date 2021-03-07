using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using William01.DOMINIO;

namespace William01.NEGOCIO
{
    class ClsLogin
    {
        String[] user = new string[3] {"william","denis","paula" };
        String[] pass = new string[3] { "12", "123", "1234" };
        private object i;

        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0;i<user.Length; i++)
            {
                if (log.Usuario.Equals(user[i]) && log.Password.Equals(pass[i])) {
                    estado = 1;

            }
            }
            return estado;
        }

    }
}
