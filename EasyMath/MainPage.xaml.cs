using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EasyMath
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			/*Equacao1Button.Clicked += async(sender, e) =>
			{
				await Navigation.PushAsync(new Equacao1());
			};*/

			Equacao2Button.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new Equacao2());
			};

			SimplificarFracao.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new SimplificarFracao());
			};

			VerificadorPrimoButton.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new VerificadorPrimos());
			};

			JurosSimples.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new JurosSimples());
			};

			JuroComposto.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new JurosComposto());
			};

			TeoremaPita.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new TeoremaPitagoras());
			};

			Fatorador.Clicked += async (sender, e) => 
			{
				await Navigation.PushAsync(new Fatorador());
			};

			Mol.Clicked += async(sender, e) =>
			{
				await Navigation.PushAsync(new CalculoMol());
			};

			AnguloInternoPR.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new AnguloInternoPoligonoRegular());
			};

			AnguloExternoPR.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new AnguloExternoPoligonoRegular());
			};
            SudokuB.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Sudoku());
            };
		}
	}
}
