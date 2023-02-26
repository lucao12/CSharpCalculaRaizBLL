using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raiz
{
    internal class Erro
    {
        private static bool erro;
        private static String mensagem;

        public static void setErro(bool Erro) { erro = Erro; }
        public static void setErro(String Mensagem) { erro = true; mensagem = Mensagem; }
        public static bool getErro() { return erro; }
        public static String getMensagem() { return mensagem; }
    }
}
