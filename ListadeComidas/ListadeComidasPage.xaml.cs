using Xamarin.Forms;
using System;
using System.Collections.Generic;
namespace ListadeComidas
{
	public partial class ListadeComidasPage : ContentPage
	{
		public ListadeComidasPage()
		{
			InitializeComponent();
			CarregaLista();
		}
		public async  void CarregaLista() {
			AzureService<Comida> services = new ListadeComidas.AzureService<Comida>();
			List<Comida> lstComidas = new List<Comida>();
		  	lstComidas=await services.GetComidas();
			if (lstComidas.Count > 0) {
				lista.ItemsSource = lstComidas;
			}
		}
	}
}
