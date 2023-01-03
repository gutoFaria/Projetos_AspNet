namespace WebAPI.Models
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public string? DescricaoPergunta { get; set; }
        public string? ImageUrl { get; set; }
        public string? Resposta1 { get; set; }
        public string? Resposta2 { get; set; }
        public string? Resposta3 { get; set; }
        public string? Resposta4 { get; set; }
        public string? RespostaCerta { get; set; }

        //Relacionamentos
        public int TemaId { get; set; }
        public Tema? Tema { get; set; }
    }
}