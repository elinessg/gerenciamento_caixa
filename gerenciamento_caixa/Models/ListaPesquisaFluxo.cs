using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace gerenciamento_caixa.Models
{
    public class ListaPesquisaFluxo
    {
        public IEnumerable<TB_Fluxo_Caixa> lstFluxoCaixa { set; get; }
        //public IEnumerable<SelectListItem> Statuses { set; get; }
        public DateTime Filtro { set; get; }
    }
}
