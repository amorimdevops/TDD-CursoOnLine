namespace CurcoOnLine.Domain.Entities
{
    public class Curso
    {
        public Curso(string descricao, int cargaHorario, PublicoAlvo publicoAlvo, decimal valor)
        {

            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentException("Descrição invalida.");

            if (valor < 1)
                throw new ArgumentException();

            Descricao = descricao;
            CargaHoraria = cargaHorario;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }

        public string Descricao { get; private set; }
        public int CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public decimal Valor { get; private set; }
    }
}
