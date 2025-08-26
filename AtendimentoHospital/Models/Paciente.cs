// Classe paciente de um hospital

namespace AtendimentoHospital.Models;
public class Paciente
{
    public Paciente(string nome, int idade, bool ehEmergencia = false)
    {
        Nome = nome;
        Idade = idade;
        EhEmergencia = ehEmergencia;
    }
    public string Nome { get; set; } = default!;
    public int Idade { get; set; }
    public bool EhEmergencia { get; set; } = false;
}