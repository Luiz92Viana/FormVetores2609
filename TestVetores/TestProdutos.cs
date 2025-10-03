using ClassLibraryVetores;

namespace TestVetores
{
    public class TestProdutos
    {
        [Fact]
        public void TestAdicionarAprovar()
        {
            var produtoF = new Vetores(new List<string>());
            produtoF.Adicionar("Arroz - R$45");
            Assert.Equal("Arroz - R$45", "Arroz - R$45");
        }
        
        [Fact]
        public void TestAdicionarReprovar()
        {
            var produtoF = new Vetores(new List<string>());
            produtoF.Adicionar("Arroz - R$45");
            Assert.Equal("Arroz - R$45", "Feijão - R$65");
        }
    }
}