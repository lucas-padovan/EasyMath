using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class CalculoMol : ContentPage
	{
		public CalculoMol()
		{
			InitializeComponent();
		}

		/*public double MassaMolar(string s)
		{
			int i = 0;
			int massaMolar
			while (i < s.Length - 1)
			{
				if(s[i] == "H" && s[i+1] && s[i] != "e" && s[i] != "")
			}
		}*/

		public string Notacao(string t)
		{
			//80.10^4
			string s = "";
			for (int w = 0; w < t.Length; w++)
			{
				if (t[w] == Convert.ToChar(","))
				{
					s += Convert.ToChar(".");
				}
				else
				{
					s += t[w];
				}
			}
			double a;
			if (Double.TryParse(s, out a))
			{
				int expoente = 0;
				double fator = Convert.ToDouble(s);
				if (fator >= 10)
				{
					while (fator >= 10)
					{
						fator /= 10;
						expoente += 1;
					}
				}
				else if (fator < 1)
				{
					while (fator < 1)
					{
						fator *= 10;
						expoente -= 1;
					}
				}
				string retorno = fator + "x10ˆ" + expoente;
				return retorno;
			}
			else
			{
				string sFator = "";
				string sExpoente = "";
				int i;
				for (i = 0; i < s.Length; i++)
				{
					if (s[i] != Convert.ToChar("x"))
					{
						sFator += s[i];
					}
					else break;
				}
				for (int x = i + 4; x < s.Length; x++)
				{
					sExpoente += s[x];
				}
				double fator = Convert.ToDouble(sFator);
				int expoente = Convert.ToInt32(sExpoente);
				if (fator >= 10)
				{
					while (fator >= 10)
					{
						fator /= 10;
						expoente += 1;
					}
				}
				else if (fator < 1)
				{
					while (fator < 1)
					{
						fator *= 10;
						expoente -= 1;
					}
				}
				string massamolar = fator + "x10ˆ" + expoente;
				return massamolar;
				//string retorno = "fator" + fator + " expoente" + sExpoente;
				//return retorno;
			}
		}

		public string Multiplica(string s, string r)
		{
			string fators = "";
			string fatorr = "";
			string expos = "";
			string expor = "";
			int i;
			int j;
			for (i = 0; i<s.Length; i++)
			{
				/*if (s[i] != Convert.ToChar("x"))
				{
					fators += s[i];
				}*/
				if (s[i] == Convert.ToChar(","))
				{
					//fators += Convert.ToChar(".");
					fators += ".";
				}
				else if (s[i] != Convert.ToChar("x"))
				{
					fators += s[i];
				}
				else break;
			}
			for(j = 0; j<r.Length; j++)
			{
				/*if (r[j] != Convert.ToChar("x"))
				{
					fatorr += r[j];
				}*/
				if (r[j] == Convert.ToChar(","))
				{
					//fators += Convert.ToChar(".");
					fatorr += ".";
				}
				else if (r[j] != Convert.ToChar("x"))
				{
					fatorr += r[j];
				}
				else break;
			}
			for (int x = i + 4; x<s.Length; x++)
			{
				expos += s[x];
			}
			for (int y = j + 4; y<r.Length; y++)
			{
				expor += r[y];
			}

			if (expos == "") expos = "0";
			
			if (expor == "") expor = "0";

			/*string retorno = (Convert.ToDouble(fators) * Convert.ToDouble(fatorr)) + "x10ˆ"
				+ (Convert.ToInt32(expos) + Convert.ToInt32(expor));
			return retorno;*/
			double fatorsi = Convert.ToDouble(fators);
			double fatorri = Convert.ToDouble(fatorr);
			int exposi = Convert.ToInt32(expos);
			int expori = Convert.ToInt32(expor);
			double a = (fatorsi * fatorri);
			int b = (exposi + expori);
			string retorno = a + "x10ˆ" + b;
			return retorno;
			//return fatorr;
		
		}

		public double Numero(string s)
		{
			string sFator = "";
			string sExpoente = "";
			int i;
			for (i = 0; i<s.Length; i++)
			{
				/*if (s[i] != Convert.ToChar("x"))
				{
					sFator += s[i];
				}*/
				if (s[i] == Convert.ToChar(","))
				{
					sFator += Convert.ToChar(".");
				}
				else if (s[i] != Convert.ToChar("x"))
				{
					sFator += s[i];
				}
				else break;
			}
			for (int x = i + 4; x<s.Length; x++)
			{
				sExpoente += s[x];
			}
			double retorno = Convert.ToDouble(sFator) * Math.Pow(10, Convert.ToInt32(sExpoente));
			return retorno;
		}

		public string divide(string s, string r)
		{
			string fators = "";
			string fatorr = "";
			string expos = "";
			string expor = "";
			int i;
			int j;
			for (i = 0; i < s.Length; i++)
			{
				if (s[i] == Convert.ToChar(","))
				{
					//fators += Convert.ToChar(".");
					fators += ".";
				}
				else if (s[i] != Convert.ToChar("x"))
				{
					fators += s[i];
				}
				else break;
			}
			for(j = 0; j < r.Length; j++)
			{
				if (r[j] == Convert.ToChar(","))
				{
					fatorr += Convert.ToChar(".");
				}
				else if (r[j] != Convert.ToChar("x"))
				{
					fatorr += r[j];
				}
				else break;
			}
			for (int x = i+4; x < s.Length; x++)
			{
				expos += s[x];
			}
			for (int y = j + 4; y < r.Length; y++)
			{
				expor += r[y];
			}

			if (expos == "") expos = "0";
			
			if (expor == "") expor = "0";

			//string retorno = (Convert.ToDouble(fators) / Convert.ToDouble(fatorr)) + "x10ˆ" 
			//	+ (Convert.ToInt32(expos) - Convert.ToInt32(expor));

			double fatorsi = Convert.ToDouble(fators);
			double fatorri = Convert.ToDouble(fatorr);
			int exposi = Convert.ToInt32(expos);
			int expori = Convert.ToInt32(expor);
			double a = (fatorsi / fatorri);
			int b = (exposi - expori);
			string retorno = a + "x10ˆ" + b;
			return retorno;
			//return expos;
			//string teste = "fators: " + fators + " fatorr: " + fatorr + " expoentes:" + expos +
			//	" expoenter: " + expor;
			/*string teste = "fators: " + Convert.ToDouble(fators)  + " fatorr: " + 
			                                   Convert.ToDouble(fatorr) + " expoentes:" + 
			                                   Convert.ToDouble(expos) + " expoenter: " + 
			                                   Convert.ToDouble(expor);
			return teste;*/
		}

		/*public string CalculaM(string numero, string massa)
		{
			string M;

			return M;
		}*/

		public bool verifica(string s)
		{
			bool aprovada = true;

			int contC = 0;
			int lugardox = -1;
			for (int i = 0; i < s.Length; i++)
			{
				double a;
				string caracter = Convert.ToString(s[i]);
				if (Double.TryParse(caracter, out a) == false)
				{
					if (caracter != "x" || caracter != "." || caracter != "," || caracter != "^")
					{
						aprovada = false;
						break;
					}
					contC++;
					if (caracter == "x")
					{
						lugardox = i;
					}
				}
			}
			if ((s.Length < lugardox + 4) || s.Length < 4 || (lugardox == -1 && contC != 0))
			{
				aprovada = false;
			}
			else if (contC > 3 || (s[lugardox + 4] != Convert.ToChar("^") && lugardox != -1))
			{
				aprovada = false;
			}
			if (contC == 0)
			{
				aprovada = true;
			}
			return aprovada;
		}

		public void Calcular(Object sender, EventArgs e)
		{
			string msg;
			bool molS = molSwitch.IsToggled;
			/*if (MBox.Text == "" || MassaBox.Text == "" || NBox.Text == "")
			{
				return;
			}*/
			/*if (verifica(MBox.Text) == false || verifica(MassaBox.Text) == false || verifica(NBox.Text) == false)
			{
				return;
			}*/
			if (MBox.Text  == "x" && MassaBox.Text != "" && NBox.Text != "")
			{
				if (verifica(MBox.Text) == false || verifica(MassaBox.Text) == false || verifica(NBox.Text) == false)
				{
					return;
				}
				//Quando quero descobrir a massa molar, tenho que pegar a massa em g
				//em notação científica e dividir pelo numero de mols. Para achar o número
				//de mols, se for dado o número de moléculas(x.10^y) em notação científica
				// tenho que dividir o numero dado por 6.10^23, dividindo x por 6
				// e subtraindo 23 de y. Com o número de mols, é só dividir a massa em g em
				//notação cientifica (a.10^b) pelo número de mols também em notação científica
				// entao vou ter um a/x . 10^b-y, e este número será dado em notação científica
				// e bruto
				//double n = Convert.ToDouble(NBox.Text); //* Convert.ToInt64(Math.Pow(10, 23));
				string m;
				m = Notacao(MassaBox.Text);
				string mols;
				//double a;
				/*if (Double.TryParse(NBox.Text, out a))
				{
					mols = Notacao(NBox.Text);
				}
				else
				{
					mols = divide(NBox.Text, "6x10^23");
					//mols = Numero(n);
				}*/
				if (molS)
				{
					mols = Notacao(NBox.Text);
				}
				else
				{
					mols = divide(NBox.Text, "6x10^23");
				}

				//string M = divide(MassaBox.Text, n);
				//string M = "" + (m / mols);
				string produto = divide(m, mols);
				string M = "" + Numero(produto);
				//string M = divide(m, mols);

				//msg += "Massa molar = " + M;
				//msg += "" + Notacao(NBox.Text);
				msg = "Massa Molar = " + M + "g/mol";
				//msg = "m = " + m + ", mols = " + mols;
				//msg = divide(m, mols);
				//msg = M + "g/mol";
                DisplayAlert("Cálculo Concluído", msg, "OK");
			}
			else if (MBox.Text != "" && MassaBox.Text == "x" && NBox.Text != "")
			{
				if (verifica(MBox.Text) == false || verifica(MassaBox.Text) == false || verifica(NBox.Text) == false)
				{
					return;
				}
				//double a;
				//double mols;
				string n;

				/*if (Double.TryParse(NBox.Text, out a))
				{
					//mols = Convert.ToDouble((NBox.Text));
					n = Notacao(NBox.Text);

				}
				else
				{
					n = divide(NBox.Text, "6x10^23");
					//mols = Numero(n);
				}*/
				if (molS)
				{
					n = Notacao(NBox.Text);
				}
				else
				{
					n = divide(NBox.Text, "6x10^23");
				}
				string M = Notacao(MBox.Text);
				//double n = Convert.ToDouble(NBox.Text); //* Convert.ToInt64(Math.Pow(10, 23));
				//string n = divide(NBox.Text, "6x10^23");
				//double mols = Numero(n);
				//double m = mols * M;
				string m = Multiplica(n, M);
				//string massa = Notacao((""+ m));
				string massa = Notacao(m);
				msg = "Massa = " + massa + "g";
				//msg = m;
                DisplayAlert("Cálculo Concluído", msg, "OK");
			}
			else if (MBox.Text != "" && MassaBox.Text != "" && NBox.Text == "x")
			{
				if (verifica(MBox.Text) == false || verifica(MassaBox.Text) == false || verifica(NBox.Text) == false)
				{
					return;
				}
				//double M = Convert.ToDouble(MBox.Text);
				//double m = Convert.ToDouble(MassaBox.Text);
				//double n = m / M;//* Convert.ToInt64(Math.Pow(10, 23));
				//string res = Notacao((n * 6) + "x10^23");
				/*double a;
				string m;
				if (Double.TryParse(MassaBox.Text, out a))
				{
					m = MassaBox.Text;
				}
				else
				{
					string w = divide(NBox.Text, "6x10^23");
					mols = Numero(w);
				}*/
				string m = Notacao(MassaBox.Text);
				//double b;
				/*if (Double.TryParse(MassaBox.Text, out b))
				{
					m = Convert.ToDouble((NBox.Text));
				}
				else
				{
					m = Numero(MassaBox.Text);
				}*/

				string M = Notacao(MBox.Text);
				//string M = MBox.Text;
				//string m = MassaBox.Text;

				string n = divide(m, M);
				string nm = Multiplica(n, "6x10^23");
				string res = Notacao(n);
				string res2 = Notacao(nm);

				msg = "Número de moléculas = " + res + "mol(s) ou " + res2 + " moléculas";
				//msg = n;
				//msg = "M = " + M + "   m = " + m;
                DisplayAlert("Cálculo Concluído", msg, "OK");
			}

   

		}
	}
}
