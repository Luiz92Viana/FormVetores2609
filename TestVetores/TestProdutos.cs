using ClassLibraryVetores;

namespace TestVetores
{
    public class TestProdutos
    {
        [Fact]
        public void TestAdicionarReprovar()
        {
            var produto = new Vetores("",0);
            string lista = produto.Adicionar("ma��", 55);
            Assert.Equal("ma��" + 33,"ma��" + 55 );
        }
        
        [Fact]
        public void TestAdicionarAprovar()
        {
            var produto = new Vetores("", 0);
            string lista = produto.Adicionar("ma��", 55);
            Assert.Equal("ma��" + 55, "ma��" + 55);
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