using gerenciamento_caixa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamento_caixa.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public async Task<IActionResult> Index(DateTime Filtro)
        {
            //TB_Fluxo_Caixa fluxo = new TB_Fluxo_Caixa();
            List<TB_Fluxo_Caixa> lstFluxoCaixa = new List<TB_Fluxo_Caixa>();
            ListaPesquisaFluxo lst=new ListaPesquisaFluxo();
            if(Filtro == new DateTime())
                Filtro = DateTime.Now;


            using (var httpClient = new HttpClient())
            { 
                using (var response = await httpClient.GetAsync("https://localhost:5000/api/TB_Fluxo_Caixa?DataMovimentacao=" + Filtro))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    lstFluxoCaixa = JsonConvert.DeserializeObject<List<TB_Fluxo_Caixa>>(apiResponse);
                }
            }
            lst.lstFluxoCaixa = lstFluxoCaixa;
            lst.Filtro = Filtro;    
            return View(lst);
            //return View();
        }

      

        // GET: Relatorio/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Relatorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relatorio/Create
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

        // GET: Relatorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Relatorio/Edit/5
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

        // GET: Relatorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Relatorio/Delete/5
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
