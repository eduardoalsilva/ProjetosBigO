// Calcula o valor das corridas de aplicativos de viagens como Uber e 99 para o motorista.
// Esse é o valor que o motorista recebe na hora que tem uma solicitação da corrida
//
using System.Text.Json;

string json = File.ReadAllText("viagens.json");
List<Viagem>? viagens = JsonSerializer.Deserialize<List<Viagem>>(json) ?? new List<Viagem>();

foreach (var viagem in viagens)
{
    decimal valor = 6M + ((decimal)viagem.Distancia) * 0.7M + ((decimal)viagem.Tempo) * 0.6M;
    Console.WriteLine($"O valor da corrida é: R$ {valor:F2}");
}
public class Viagem
{
    public double Distancia { get; set; }
    public int Tempo { get; set; }
}
