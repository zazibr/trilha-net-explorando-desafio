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
            Hospedes = hospedes;
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (ObterQuantidadeHospedes() > Suite.Capacidade )  {
                // TODO: Retornar uma exception caso a capacidade seja maior que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception($"A quantidade de hóspedes não pode exceder a capacidade da suíte\n Capacidade da suite é {Suite.Capacidade} e a quantidade de hóspedes {ObterQuantidadeHospedes()}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10 )
            {
                decimal desconto = valor * 0.10m;
                decimal valorComDesconto = valor - desconto;
                valor = valorComDesconto ;
            }

            return valor;
        }
    }
}