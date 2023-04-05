using Microsoft.AspNetCore.Mvc;
using MimozaUi.Dtos.SocialDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MimozaUi.ViewComponents.Default
{
    public class _SocialPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _SocialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:32010/api/Social");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSocialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
