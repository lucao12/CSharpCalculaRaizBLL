using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raiz
{
    internal class EqSegundoGrauBLL
    {
        public static void validaCalc(EqSegundoGrau calculo)
        {
            Erro.setErro(false);
            if (calculo.getA().Length == 0)
            {
                Erro.setErro("o primeiro numero é de preenchimento obrigatorio");
                return;
            }
            else
            {
                try
                {
                    float.Parse(calculo.getA());
                }
                catch
                {
                    Erro.setErro("O primeiro numero deve ser obrigatorio");
                    return;
                }
            }
            if (calculo.getB().Length == 0)
            {
                Erro.setErro("o segundo numero é de preenchimento obrigatorio");
                return;
            }
            else
            {
                try
                {
                    float.Parse(calculo.getA());
                }
                catch
                {
                    Erro.setErro("O segundo numero deve ser obrigatorio");
                    return;
                }
            }
            if (calculo.getC().Length == 0)
            {
                Erro.setErro("o delta é de preenchimento obrigatorio");
                return;
            }
            else
            {
                try
                {
                    float.Parse(calculo.getC());
                }
                catch
                {
                    Erro.setErro("O primeiro numero deve ser numerico");
                    return;
                }
                if (float.Parse(calculo.getC()) < 0)
                {
                    Erro.setErro("O DELTA deve ser maior ou igual a 0");
                }  
            }
        }
    }
}
