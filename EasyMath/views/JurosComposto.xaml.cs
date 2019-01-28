using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class JurosComposto : ContentPage
	{
		public JurosComposto()
		{
			InitializeComponent();
		}

		public void CalculaJurosComposto3(Object sender, EventArgs e)
		{
			if (Valor5Holder.Text == "" || Taxa5Holder.Text == "" || N5Holder.Text == "")
			{

			}

			else {
				double valor1 = Convert.ToDouble(Valor5Holder.Text);
				double taxa1 = Convert.ToDouble(Taxa5Holder.Text);
				double n1 = Convert.ToDouble(N5Holder.Text);

				double total1 = valor1;
				if(taxa1 > 0) {
					for (var i = 0; i < n1; i++)
					{
						total1 = valor1 * Math.Pow((1 + (taxa1/100)), n1);
					}
				}
				else if (taxa1 < 0)
				{
					for (var i = 0; i<n1; i++)
					{
						total1 = valor1 * Math.Pow((1 - (taxa1/100)), n1);
					}
				}



				string msg1 = "O Montante corresponde a $" + total1;
				DisplayAlert("Cálculo Concluído", msg1, "OK");
			}
		}
	}
}