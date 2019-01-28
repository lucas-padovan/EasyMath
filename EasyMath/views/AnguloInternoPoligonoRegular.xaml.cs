using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class AnguloInternoPoligonoRegular : ContentPage
	{
		public AnguloInternoPoligonoRegular()
		{
			InitializeComponent();
		}

		public void CalcularAnguloInterno(Object sender, EventArgs e)
		{
			if (Convert.ToInt32(NLados.Text) <= 0)
			{

			}

			else {
				int lados = Convert.ToInt32(NLados.Text);

				double anguloI = ((lados - 2) * 180) / lados;

				string msg = "Cada ângulo interno deste polígono regular tem " + anguloI + "°";

				DisplayAlert("Cálculo Concluído", msg, "OK");
			}
		}
	}
}
