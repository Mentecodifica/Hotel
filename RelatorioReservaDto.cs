using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public record RelatorioReservaDto(
    string NomeHospede,
    int NumeroQuarto,
    int QuantidadeDiarias,
    decimal ValorTotal,
    string Situacao
    );

}
