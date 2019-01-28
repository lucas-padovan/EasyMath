using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class AnguloExternoPoligonoRegular : ContentPage
	{
		public AnguloExternoPoligonoRegular()
		{
			InitializeComponent();
		}

		public void CalcularAnguloExterno(Object sender, EventArgs e)
		{
			if (Convert.ToInt32(NLados.Text) <= 0) {

			}

			else {
				double lados = Convert.ToInt32(NLados.Text);

				double anguloI = 360.0 / lados;

				string msg = "Cada ângulo interno deste polígono regular tem " + anguloI + "°";

				DisplayAlert("Cálculo Concluído", msg, "OK");
			}
		}
	}
}
