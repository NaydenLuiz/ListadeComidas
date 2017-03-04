using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace ListadeComidas
{
	public class AzureService<T>
	{
		

		IMobileServiceClient Client;
		IMobileServiceTable<T> Table;
		public AzureService()
		{
			string MyAppServiceURL = "http://demonaydenxamarin.azurewebsites.net";
			Client = new MobileServiceClient(MyAppServiceURL);
			Table = Client.GetTable<T>();
		}
		public Task<IEnumerable<T>> GetTable()
		{
			return Table.ToEnumerableAsync();
		}
		public async Task<List<Comida>> GetComidas()
		{
			var Service = new AzureService<Comida>();
			var Items = await Service.GetTable();
			return Items.ToList();
		}


	}
}
