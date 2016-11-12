using System;
using Nest;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Zenoti
{
	public class DatabaseContext
	{
		public DatabaseContext ()
		{

		}

		public ElasticClient GetElasticClient(){
			var node = new Uri(AppConstants.ELASTIC_SEARCH_URL);
			var settings = new ConnectionSettings (node);
			settings.DefaultIndex (AppConstants.ELASTIC_SEARCH_INDEX_NAME);
			var client = new ElasticClient (settings);

			return client;
		}

		public void CreateIndex(){
			var client = this.GetElasticClient();

			var indexDescriptor = new CreateIndexDescriptor (AppConstants.ELASTIC_SEARCH_INDEX_NAME)
				.Mappings (ms => ms
					.Map<Business> (m => m.AutoMap ()));

			client.CreateIndex (AppConstants.ELASTIC_SEARCH_INDEX_NAME, i => indexDescriptor);
			this.CreateData ();
		}

		public void CreateData(){
			var client = this.GetElasticClient();

			var data = AppConstants.INITIAL_DATA;

			List<Business> businessData = JsonConvert.DeserializeObject<List<Business>> (data);

			var count = client.Count<Business> (i => i
				.Index (AppConstants.ELASTIC_SEARCH_INDEX_NAME)
				.Type (AppConstants.ELASTIC_SEARCH_TYPE_BUSINESS)
			);
			if (count.Count == 0) {
				var bulkDescriptor = new BulkDescriptor ();
				
				foreach (var item in businessData) {
					bulkDescriptor.Index<Business> (i => i
						.Index (AppConstants.ELASTIC_SEARCH_INDEX_NAME)
						.Type (AppConstants.ELASTIC_SEARCH_TYPE_BUSINESS)
						.Document (item)
					);
				}
				
				client.Bulk (bulkDescriptor);
			
			}
		}


	}
}

