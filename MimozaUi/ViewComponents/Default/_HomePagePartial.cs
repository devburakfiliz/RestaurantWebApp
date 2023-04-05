using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MimozaUi.ViewComponents.Default
{
    public class _HomePagePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomePagePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}