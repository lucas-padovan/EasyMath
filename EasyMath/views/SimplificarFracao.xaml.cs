using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class SimplificarFracao : ContentPage
	{
		public SimplificarFracao()
		{
			InitializeComponent();
		}

		public void CalculaResultado(Object sender, EventArgs e)
		{
			bool somaS = somaSwitch.IsToggled;
			bool subS = subSwitch.IsToggled;

			if (somaS && subS)
			{
				return;
			}
			if (n1Box.Text == "" || d1Box.Text == "" || n2Box.Text == "" || d2Box.Text == "")
			{
				return;
			};


			double n1 = Convert.ToDouble(n1Box.Text);
			double d1 = Convert.ToDouble(d1Box.Text);
			double n2 = Convert.ToDouble(n2Box.Text);
			double d2 = Convert.ToDouble(d2Box.Text);

			double op1 = 0;
			double op2 = 0;

			if (somaS)
			{
				op1 = n1 * d2 + n2 * d1;
				op2 = d1 * d2;
			}
			else if (subS)
			{
				op1 = n1* d2 - n2 * d1;
				op2 = d1 * d2;
			}

			for (double i = op1 - 1; i > 0; i--)
			{
				if (op1 % i == 0 && op2 % i == 0)
				{
					op1 = op1 / i;
					op2 = op2 / i;
				}
			}

			string msg = "numerador final: " + op1 + ", denominador final: " + op2;
			DisplayAlert("Cálculo Concluído", msg, "OK");

		}


	
	}

}



		
	

