using ClassLibraryVetores;

namespace TestVetores
{
    public class TestProdutos
    {
        [Fact]
        public void TestAdicionarReprovar()
        {
            var produto = new Vetores("",0);
            string lista = produto.Adicionar("maçã", 55);
            Assert.Equal("maçã" + 33,"maçã" + 55 );
        }
        
        [Fact]
        public void TestAdicionarAprovar()
        {
            var produto = new Vetores("", 0);
            string lista = produto.Adicionar("maçã", 55);
            Assert.Equal("maçã" + 55, "maçã" + 55);
        }

        [Fact]
        public void TestRemoverReprovar()
        {
            var produto = new Vetores("", 0);
        }

        [Fact]
        public void TestRemoverAprovar()
        {
            var produto = new Vetores("", 0);
            
        }

    }
}