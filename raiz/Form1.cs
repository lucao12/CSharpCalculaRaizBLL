using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EqSegundoGrau calculo = new EqSegundoGrau();

            calculo.setA(txtNum1.Text);
            calculo.setB(txtNum2.Text);
            calculo.setC(txtNum3.Text);

            EqSegundoGrauBLL.validaCalc(calculo);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem());
            }
            else
            {
                if (double.Parse(calculo.getCalcDelta()) <= 0)
                {
                    MessageBox.Show("Nao havera raiz!");
                }
                else
                {
                    MessageBox.Show(calculo.getCalcA());
                    MessageBox.Show(calculo.getCalcB());
                }

            }
        }
    }
}
