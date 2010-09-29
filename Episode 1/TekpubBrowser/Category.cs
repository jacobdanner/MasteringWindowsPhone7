namespace TekpubBrowser
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Net;
	using System.Runtime.Serialization.Json;
	using System.Windows;
	using Microsoft.Phone.Shell;

	public class Category
	{
		static readonly Dictionary<string, string> TagMap = new Dictionary<string, string>
		                                                    	{
		                                                    		{".net", "microsoft"},
		                                                    		{"tools", "utility"},
		                                                    	};

		public Category()
		{
			Productions = new ObservableCollection<Production>();
		}

		public string Name { get; set; }
		public ObservableCollection<Production> Productions { get; private set; }

		public void LoadProductions()
		{
			if (Productions.Count > 0)
				return;

			var tag = TagMap.ContainsKey(Name)
			          	? TagMap[Name]
			          	: Name;

			var uri = new Uri("http://tekpub.com/productions?format=json&tag=" + tag);
			var request = (HttpWebRequest) WebRequest.Create(uri);
			request.BeginGetResponse(HandleResponse, request);
		}

		void HandleResponse(IAsyncResult ar)
		{
			var request = (HttpWebRequest) ar.AsyncState;

			using (var response = (HttpWebResponse) request.EndGetResponse(ar))
			{
				var serializer = new DataContractJsonSerializer(typeof (List<Production>));
				var items = (List<Production>) serializer.ReadObject(response.GetResponseStream());
				Deployment.Current.Dispatcher.BeginInvoke(() =>
				                                          	{
				                                          		foreach (var item in items)
				                                          		{
				                                          			Productions.Add(item);
				                                          			PhoneApplicationService.Current.State[item.slug] = item;
				                                          		}
				                                          	}
					);
			}
		}
	}
}