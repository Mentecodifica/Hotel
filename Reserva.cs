using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Reserva
    {
        public int Id { get; set; }

        public string NomeHospede { get; set; }

        public int NumeroQuarto { get; set; }

        public int QuantidadeDiarias { get; set; }

        public decimal ValorDiaria { get; set; }

        public string StatusInterno { get; set; }

        public string ObservacaoInterna { get; set; }

    }

}
