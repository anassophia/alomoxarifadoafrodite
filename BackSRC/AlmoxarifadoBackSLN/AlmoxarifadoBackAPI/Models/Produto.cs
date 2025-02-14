namespace AlmoxarifadoBackAPI.Models
{
    public class Produto
    {
        public int IdProd { get; set; }
        public string DescricaoProd { get; set; }
        public string UnidadeDeMedida { get; set; }
        public float EstoqueAtual { get; set; }
        public bool EPermanente { get; set; }
        public int IdCategoria { get; set; }

    }
}
