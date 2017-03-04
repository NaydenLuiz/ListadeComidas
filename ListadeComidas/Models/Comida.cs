using System;
using Microsoft.WindowsAzure.MobileServices;
namespace ListadeComidas
{
	[DataTable("comidas")]
	public class Comida
	{
		int id { get; set;}
		string descricao { get; set; }
		[Version]
		public string AzureVersion { get; set; }

	}
}
