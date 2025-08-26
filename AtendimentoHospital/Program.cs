// Organiza uma fila para atendimento de um hospital

using AtendimentoHospital.Models;

Queue<Paciente> filaPacientes = new Queue<Paciente>();
string? opcao = "";
string? nome;
int idade;
bool ehEmergencia = false;

while (opcao != "0")
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Adicionar paciente.");
    Console.WriteLine("2. Chamar próximo.");
    Console.WriteLine("3. Listar fila.");
    Console.WriteLine("0. Sair.");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("É emergencial? Pressione S para emergencial ou ENTER para não emergencial");
            if (Console.ReadLine().ToLower() == "s")
            {
                ehEmergencia = true;
            }
            Paciente paciente = new Paciente(nome, idade, ehEmergencia);
            filaPacientes.Enqueue(paciente);
            break;

        case "2":
            if (filaPacientes.Any())
            {
                Console.WriteLine($"Próximo paciente: {filaPacientes.Dequeue().Nome}");
            }
            else
            {
                Console.WriteLine("Não há pacientes na fila");
            }
            break;

        case "3":
            if (filaPacientes.Any())
            {
                foreach (Paciente pacienteNaFila in filaPacientes)
                {
                    Console.WriteLine($"{pacienteNaFila.Nome}");
                }
            }
            else
            {
                Console.WriteLine("Não há pacientes na fila");
            }
            break;

        case "0":
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }



}