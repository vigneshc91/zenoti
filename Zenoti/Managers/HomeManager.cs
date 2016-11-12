using System;
using System.Collections.Generic;
using System.Linq;
using Nest;

namespace Zenoti
{
	public class HomeManager
	{
		public HomeManager ()
		{
		}

		public List<Business> GetBusinessList(int start, int size, string businessName, string businessType) {
			try {
				
				var client = new DatabaseContext().GetElasticClient();

				string field = "", value = "";
				if(!String.IsNullOrWhiteSpace(businessName)){
					field = AppConstants.ELASTIC_BUSINESS_NAME;
					value = businessName;
				}
				if(!String.IsNullOrWhiteSpace(businessType)){
					field = AppConstants.ELASTIC_BUSINESS_TYPE;
					value = businessType;
				}

				var response = client.Search<Business>(g => g
					.Index(AppConstants.ELASTIC_SEARCH_INDEX_NAME)
					.Type(AppConstants.ELASTIC_SEARCH_TYPE_BUSINESS)
					.Query(n => n
						.Prefix(field, value)
					)
					.Skip(start)
					.Take(size)
				);

				List<Business> businessList = new List<Business>();

				if(response.Total > 0){
					foreach (var item in response.Hits) {
						businessList.Add(item.Source);
					}
				}

				return businessList;

				
			} catch (Exception e){
				throw e;
			} 
		}
	}
}

