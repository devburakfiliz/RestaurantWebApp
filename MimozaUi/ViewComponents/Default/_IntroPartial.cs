using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MimozaUi.ViewComponents.Default
{
    public class _IntroPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _IntroPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}