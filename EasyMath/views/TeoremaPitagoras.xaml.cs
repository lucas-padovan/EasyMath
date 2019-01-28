using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class TeoremaPitagoras : ContentPage
	{
		public TeoremaPitagoras()
		{
			InitializeComponent();
		}

		public void Descobrir(Object sender, EventArgs e)
		{



			string msg = "";

			if (Cateto1Holder.Text == "" && Cateto2Holder.Text != "" && HipotenusaHolder.Text != "")
			{
				double cateto2 = Convert.ToDouble(Cateto2Holder.Text);
				double hipotenusa = Convert.ToDouble(HipotenusaHolder.Text);

				double Qcateto1 = (hipotenusa * hipotenusa) - (cateto2 * cateto2);

				if (hipotenusa < cateto2)
				{
					msg = "Este triangulo retangulo não existe";
				}

				else if (Qcateto1 % 1 != 0)
				{
					msg = "Cateto 1  = raiz de " + Qcateto1;
				}

				else if (Qcateto1 % 1 == 0)
				{
					msg = "Cateto 1 = " + Math.Sqrt(Qcateto1);
				}

				DisplayAlert("Cálculo Concluído", msg, "OK");
			}

			else if (Cateto2Holder.Text == "" && Cateto1Holder.Text != "" && HipotenusaHolder.Text != "")
			{
				double cateto1 = Convert.ToDouble(Cateto1Holder.Text);
				double hipotenusa = Convert.ToDouble(HipotenusaHolder.Text);

				double Qcateto2 = (hipotenusa * hipotenusa) - (cateto1 * cateto1);

				if (hipotenusa < cateto1)
				{
					msg = "Este triangulo retangulo não existe";
				}

				else if (Qcateto2 % 1 != 0)
				{
					msg = "Cateto 2 = raiz de " + Qcateto2;
				}

				else if (Qcateto2 % 1 == 0)
				{
					msg = "Cateto 2  = " + Math.Sqrt(Qcateto2);
				}



				DisplayAlert("Cálculo Concluído", msg, "OK");
			}



			else if ((HipotenusaHolder.Text == "" && Cateto1Holder.Text == "") || (HipotenusaHolder.Text == "" && Cateto1Holder.Text == "") || (Cateto1Holder.Text == "" && Cateto2Holder.Text == ""))
			{
				msg = "Este triangulo retangulo não existe";
				DisplayAlert("Cálculo Concluído", msg, "OK");
			}

			else //if (HipotenusaHolder.Text == "" && Cateto2Holder.Text != "" && Cateto1Holder.Text != "")
			{
				double cateto1 = Convert.ToDouble(Cateto1Holder.Text);
				double cateto2 = Convert.ToDouble(Cateto2Holder.Text);

				double Qhipotenusa = (cateto1 * cateto1) + (cateto2 * cateto2);

				if (Math.Sqrt(Qhipotenusa) % 1 != 0)
				{
					msg = "hipotenusa = raiz de " + Qhipotenusa;
				}

				else //if (Math.Sqrt(Qhipotenusa) % 1 == 0)
				{
					msg = "hipotenusa = " + Math.Sqrt(Qhipotenusa);
				}
				DisplayAlert("Cálculo Concluído", msg, "OK");
			}

		}
	}
}