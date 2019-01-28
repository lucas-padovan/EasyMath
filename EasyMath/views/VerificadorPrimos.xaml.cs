using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class VerificadorPrimos : ContentPage
	{
		bool[] e_composto = new bool[99999999];
		List<long> divisores = new List<long>();
		long numero;

		public VerificadorPrimos()
		{
			InitializeComponent();
		}

		public void crivo(long x)
		{
			e_composto[1] = true;

			for (long i = 2; i < x; i++)
			{
				if (!e_composto[i])
				{
					for (long c = 2; i * c <= x; c++)
					{
						if (c * i == numero)
						{
							divisores.Add(c);
							divisores.Add(i);
						}
						e_composto[c * i] = true;
					}
				}
			}
		}

		public void TestarNumero(Object sender, EventArgs e)
		{
			if (NumeroBox.Text == "")
			{

			}
			else if (Convert.ToInt64(NumeroBox.Text) > 99999990)
			{
				return;
			}

			else {
				string numeroS = NumeroBox.Text;
				numero = Convert.ToInt64(numeroS);
				/*List<double> divisores = new List<double>();
				bool primalidade = true;
				string msg;
				for (var i = numero - 1; i > 1; i--)
				{
					if (numero % i == 0)
					{
						divisores.Add(i);
						primalidade = false;
					}
				}*/
				string msg;
				crivo(numero);


				if (!e_composto[numero])
				{
					msg = "O número " + numero + " é primo";
					DisplayAlert("Teste Concluído", msg, "Ok");

				}

				else
				{
					msg = "O número " + numero + " não é primo, pois é divisível por: ";
					for (int d = 0; d < divisores.Count; d++)
					{
						msg += divisores[d] + "; ";
						//e_composto.
					}
				}
				DisplayAlert("Teste Concluído", msg, "OK");
				divisores.Clear();
			}
		}
	}
}
