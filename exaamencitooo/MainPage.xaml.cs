using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exaamencitooo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
   
        private void SumaClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Numero1.Text);
            double num2 = Convert.ToDouble(Numero2.Text);
            double resultado = num1 + num2 ;
            Resultado.Text = "Resultado: " + resultado;
        }

        private void MultiClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Numero1.Text);
            double num2 = Convert.ToDouble(Numero2.Text);
            double resultado = num1 * num2 ;
            Resultado.Text = "Resultado: " + resultado;
        }

        private void DivClick(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Numero1.Text);
            double num2 = Convert.ToDouble(Numero2.Text);

            if (num2 == 0 || num1 == 0)
            {
                Resultado.Text = "No puedes dividir por cero miguel";
            }
            else
            {
                double resultado = num1 / num2;
                Resultado.Text = "Resultado: " + resultado;
            }
        }
  
    }
}
