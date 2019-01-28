using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class Fatorador : ContentPage
	{
		bool[] e_composto = new bool[99999999];
		List<long> divisores = new List<long>();


		public Fatorador()
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
						if (c * i == x)
						{
							divisores.Add(c);
							divisores.Add(i);
						}
						e_composto[c * i] = true;
					}
				}
			}
		}

		/*public bool VerificaPrimalidade(double numero)
		{

			bool primalidade = true;
			for (double i = numero - 1; i >= 2; i--)
			{
				if (numero % i == 0)
				{
					primalidade = false;
				}

			}

			return primalidade;

		}*/

		public void Fatorar(Object sender, EventArgs e)
		{
			if (NumeroHolder.Text == "")
			{
				return;
			}
			else if (Convert.ToInt64(NumeroHolder.Text) > 99999990)
			{
				return;
			}

			else {
				double numero = Convert.ToDouble(NumeroHolder.Text);

				string msg = numero + " = ";

				//List<Double> fatores = new List<Double>();
				int w = Convert.ToInt32(numero);
				Double[] fatores = new Double[w+1];
				int nFatores = 0;
                crivo(w);
				//double[] fatores;
				double x;
				//double y;
				for (x = numero; x > 1; x--)
				{
				int xi = Convert.ToInt32(x);
					if (numero % x == 0 && e_composto[xi] == false)
					{
						if (fatores[xi] == 0)
						{
							nFatores++;
						}
						fatores[xi] += 1;
						//fatores.Add(13);
						numero = numero / x;
						x = numero;
						//y = numero - 1;
					}
				}

				int y = Convert.ToInt32(numero);
				if (numero % y == 0 && e_composto[y] == false)
				{
					if (fatores[y] == 0)
					{
						nFatores++;
					}
					fatores[y] += 1;
					//fatores.Add(13);
					numero = numero / y;
						//y = numero - 1;
				}

				//msg += "(" + numero + ") ";
				//msg += "(" + x + ") ";


				/*for (int n = 0; n < fatores.Count; n++)
				{
					if (n == fatores.Count - 1)
					{
						msg = msg + " " + fatores[n] + "ˆ" + (nFatores[Convert.ToInt32(fatores[n])] + 0);
					}
					else {
							msg = msg + " " + fatores[n] + "ˆ" + (nFatores[Convert.ToInt32(fatores[n])] + 0) + " x";
					}

				}*/
				int contador = 1;
				for (int m = 1; m <= w; m++)
				{
					if (fatores[m] > 0)
					{
						if (contador == nFatores)
						{
							msg += " " + m + "ˆ" + fatores[m];
						}
						else
						{
							msg += " " + m + "ˆ" + fatores[m] + " x";
						}
						contador++;
					}
				}

				/*for (int n = 2; n <= w; n++)
				{
					
							msg += " " + n + "ˆ" + fatores[n] + "\n";
						
				}*/

				DisplayAlert("Fatoração Concluída", msg, "OK");
				divisores.Clear();
			}
		}
	}
}
