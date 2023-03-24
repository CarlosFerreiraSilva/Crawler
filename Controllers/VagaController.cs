using CoderCarrer.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;


namespace CoderCarrer.Controllers
{
    public class VagasController : Controller
    {
        public IActionResult Index()
        {
            List<Vaga> vagas = new List<Vaga>();    
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.trabalhabrasil.com.br/");
            Vaga title = new Vaga();
            int i = 0;
            var titulo = doc.DocumentNode.SelectNodes("//*[@id=\"jobs-wrapper\"]").First().InnerText;

            //foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\"jobs-wrapper\"]"))
            //{
            // string titulo = item.ChildNodes[i].InnerText.Trim();
            // vagas.Add(new Vaga());
            // {
            //  title.titulo = titulo;
            // }


            //  i++;
            //  }

            return View(titulo);
            
        }
    }
}
