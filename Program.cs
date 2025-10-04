using DesafioProjetoHospedagem.Models;

try
{
    Console.WriteLine("--- Sistema de Reserva de Hotel ---");

    // --- Cadastro da Suíte ---
    Console.Write("Digite o tipo da suíte (Ex: Premium, Luxo): ");
    string tipoSuite = Console.ReadLine();

    Console.Write("Digite a capacidade da suíte: ");
    int capacidade = int.Parse(Console.ReadLine());

    Console.Write("Digite o valor da diária: ");
    decimal valorDiaria = decimal.Parse(Console.ReadLine());

    // Cria a suíte com os dados informados
    Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidade, valorDiaria: valorDiaria);

    // --- Cadastro dos Hóspedes ---
    List<Pessoa> hospedes = new List<Pessoa>();
    Console.Write("Quantos hóspedes serão? ");
    int quantidadeHospedes = int.Parse(Console.ReadLine());

    for (int i = 1; i <= quantidadeHospedes; i++)
    {
        Console.Write($"Digite o nome completo do {i}º hóspede: ");
        // Separa nome e sobrenome, se houver
        string[] nomeCompleto = Console.ReadLine().Split(' ');
        string nome = nomeCompleto[0];
        string sobrenome = nomeCompleto.Length > 1 ? string.Join(" ", nomeCompleto.Skip(1)) : "";
        hospedes.Add(new Pessoa(nome, sobrenome));
    }

    // --- Cadastro da Reserva ---
    Console.Write("Quantos dias deseja reservar? ");
    int diasReservados = int.Parse(Console.ReadLine());

    // Cria a reserva e associa a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados: diasReservados);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes); // A validação de capacidade acontece aqui

    // --- Exibe o Resultado ---
    Console.WriteLine("\n--- Resumo da Reserva ---");
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor final da diária: {reserva.CalcularValorDiaria():C}");
}
catch (Exception ex)
{
    // Captura qualquer erro (capacidade excedida, texto em vez de número, etc.)
    Console.WriteLine($"\nOps, ocorreu um erro: {ex.Message}");
}