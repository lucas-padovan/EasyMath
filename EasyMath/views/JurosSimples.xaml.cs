using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class JurosSimples : ContentPage
	{
		public JurosSimples()
		{
			InitializeComponent();
		}

		public void CalculaJurosSimples(Object sender, EventArgs e)
		{
			if (ValorHolder.Text == "" || TaxaHolder.Text == "" || NHolder.Text == "")
			{

			}

			else {
				double valor = Convert.ToDouble(ValorHolder.Text);
				double taxa = Convert.ToDouble(TaxaHolder.Text);
				double n = Convert.ToDouble(NHolder.Text);
				double total = valor;

				//double somar = valor * (taxa / 100);

				if (taxa >= 0)
				{
					for (var i = 1; i <= n; i++)
					{
						total += valor * (taxa / 100);
					}
				}
				else if (taxa < 0)
				{
					for (var i = 1; i <= n; i++)
					{
						total += valor * (1 - (taxa / 100));
					}
				}

				string msg = "O Montante corresponde a $" + total;

				DisplayAlert("Cálculo Concluído", msg, "OK");
			}


		}
	}
}