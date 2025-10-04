namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verifica se a suíte foi definida
            if (Suite == null)
            {
                throw new Exception("A suíte ainda não foi cadastrada para a reserva.");
            }

            // Regra: a capacidade deve ser maior ou igual ao número de hóspedes.
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retorna uma exception caso a capacidade seja menor.
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (contando os itens da lista).
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Se os dias reservados forem 10 ou mais, conceder desconto de 10%.
            if (DiasReservados >= 10)
            {
                // Aplica o desconto de 10%. Multiplicar por 0.90 é o mesmo que subtrair 10%.
                valor = valor * 0.90m; 
            }

            return valor;
        }
    }
}