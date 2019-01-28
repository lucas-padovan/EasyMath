using System; using System.Collections.Generic;  using Xamarin.Forms;  namespace EasyMath { 	public partial class Equacao2 : ContentPage 	{ 		public Equacao2() 		{ 			InitializeComponent(); 		}  		public void ResolveConta(Object sender, EventArgs e) 		{ 			double a; //= Convert.ToDouble(aS); 			double b;// = Convert.ToDouble(bS); 			double c;// = Convert.ToDouble(cS);  			if (aBox.Text == "" || bBox.Text == "" || cBox.Text == "" || Double.TryParse(aBox.Text, out a) == false || Double.TryParse(aBox.Text, out b) == false || Double.TryParse(aBox.Text, out c) == false) 			{  			}  			else
			{ 				string aS = aBox.Text; 				string bS = bBox.Text; 				string cS = cBox.Text;  				string msg = "";  				a = Convert.ToDouble(aS); 				b = Convert.ToDouble(bS); 				c = Convert.ToDouble(cS);  				double res1; 				double res2;  				double delta = Math.Pow(b, 2) - (4 * a * c);  				if (delta < 0) 				{ 					msg += "S = { }"; 				}
				else
				{

					double raizQuadradaDelta;

					raizQuadradaDelta = Math.Sqrt(delta);

					//msg = "" + delta;

					res1 = ((-1 * b) + raizQuadradaDelta) / (2 * a);
					res2 = ((-1 * b) - raizQuadradaDelta) / (2 * a);

					msg = "S = { " + res1 + "; " + res2 + " }    ou    S = { (-" + b + " +- √" + delta + ") / " + 2 * a + "}";
 				}
				DisplayAlert("Cálculo Concluído", msg, "OK"); 			} 		 		} 	} }  