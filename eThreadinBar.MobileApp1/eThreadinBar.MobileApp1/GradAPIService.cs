﻿using eThreadingBar.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eThreadinBar.MobileApp1
{
  public   class GradAPIService
    {
        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:50377/api";
#endif
#if RELEASE
        private string apiUrl = "https://mywebsite.com/api";

#endif
        public GradAPIService(string route)
        {
            _route = route;
        }



        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Zahtjev nije uspio", "OK");
                }
                throw;
            }

        }
    }
}
