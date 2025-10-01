using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVetores
{
    public class Vetores
    {
        public int tamanhoLista {  get; set; }
        public string Produtos { get; set; }
        
        public double Preco { get; set;}

        public Vetores(string produtos, double preco)
        {
            this.Produtos = produtos;
            this.Preco = preco;
            this.tamanhoLista = 0;
        }
        public string Adicionar(string produtos, double preco)
        {
            return ($"{produtos} - R${preco}");
        }
    }

}
