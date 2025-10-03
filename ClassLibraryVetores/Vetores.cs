using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVetores
{
    public class Vetores
    {
        private List<string> _produtos = new List<string>();

        // public string Produtos { get; set; }
        
        // public double Preco { get; set;}

        public Vetores(List<string> produtosF)
        {
            this._produtos = produtosF;
        }
        public void Adicionar(string produtosF)
        {
            _produtos.Add(produtosF);
        }

        public void Remover(string produtosF)
        {
            _produtos.Remove(produtosF);
        }

        public List<string> LimparLista() =>
            new List<string>(_produtos);
        
    }

}
