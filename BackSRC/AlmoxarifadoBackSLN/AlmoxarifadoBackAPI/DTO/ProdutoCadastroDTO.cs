namespace AlmoxarifadoBackAPI.DTO
{
    public class ProdutoCadastroDTO
    {
        public string DescProd { get; set; }
        public string UnidadeMedida { get; set; }
        public float EstoqueAtual { get; set; }
        public bool EPermanente { get; set; }
        public int Codigo { get; set; }
    }
}
