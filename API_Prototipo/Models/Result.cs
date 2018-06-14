using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Prototipo.Models
{
    public class Result
    {
        public bool ClienteLocalizado { get; set; }
        public bool ExecutouManutencaoDeAgendaEmD0 { get; set; }
        public bool MaisDeUmContratoAtivo { get; set; }
        public bool ClienteAdimplente { get; set; }
        public bool AgendaAtiva { get; set; }
        public bool ContratoElegivelParaMP { get; set; }
        public string Erro { get; set; }
    }
}
