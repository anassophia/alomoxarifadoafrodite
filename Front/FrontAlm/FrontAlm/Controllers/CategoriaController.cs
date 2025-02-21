﻿using Microsoft.AspNetCore.Mvc;

namespace FrontAlmoxarifado.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var url = "";
            List <CategoriaDTO> categoria = new List<CategoriaDTO> ();

            using HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                categoria = JsonSerializer.Deserialize<List<CategoriaDTO>>(json);
                ViewBag.Categorias = categoria;
            }
            catch (Exception)
            {
                return View();
            }

            return View();
        }
    }
}
