using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using gerenciamento_caixa.Models;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace gerenciamento_caixa.Controllers
{
    public class GerenciamentoController : Controller
    {
        // GET: GerenciamentoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GerenciamentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GerenciamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GerenciamentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

      
        [HttpPost]
        public async Task<IActionResult> Index(TB_Fluxo_Caixa fluxo_Caixa)
        {
            fluxo_Caixa.DataMovimentacao = DateTime.Now;
            TB_Fluxo_Caixa fluxo = new TB_Fluxo_Caixa();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(fluxo_Caixa), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:5001/api/Fluxo_Caixa", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    fluxo = JsonConvert.DeserializeObject<TB_Fluxo_Caixa>(apiResponse);
                }
            }
            return View(fluxo);
        }
        // GET: GerenciamentoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GerenciamentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GerenciamentoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GerenciamentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
