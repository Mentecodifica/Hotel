using Hotel;
using System;

class Program
{
    public static RelatorioReservaDto Mapear(Reserva reserva)
    {
        decimal valorTotal =
        reserva.QuantidadeDiarias * reserva.ValorDiaria;


        return new RelatorioReservaDto(
            reserva.NomeHospede,
            reserva.NumeroQuarto,
            reserva.QuantidadeDiarias,
            valorTotal,
            "Reserva confirmada"
        );
    }

    public static void ExibirRelatorio(RelatorioReservaDto relatorio)
    {
        Console.WriteLine("=== RELATÓRIO DA RESERVA ===");

        Console.WriteLine($"Nome do hóspede: {relatorio.NomeHospede}");
        Console.WriteLine($"Número do quarto: {relatorio.NumeroQuarto}");
        Console.WriteLine($"Quantidade de diárias: {relatorio.QuantidadeDiarias}");
        Console.WriteLine($"Valor total: R$ {relatorio.ValorTotal:F2}");
        Console.WriteLine($"Situação: {relatorio.Situacao}");
    }

    static void Main(string[] args)
    {
        Reserva reserva = new Reserva
        {
            Id = 1,
            NomeHospede = "Ana Machado",
            NumeroQuarto = 07,
            QuantidadeDiarias = 7,
            ValorDiaria = 670.00m,
            StatusInterno = "CONFIRMADA",
            ObservacaoInterna = "Hóspede solicitou quarto silencioso com hidro"
        };

        RelatorioReservaDto relatorio = Mapear(reserva);

        ExibirRelatorio(relatorio);
    }


}
