using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryVetores;

namespace FormVetores2609
{
    public partial class FormV23 : Form
    {
        public FormV23()
        {
            InitializeComponent();
        }

        private Vetores _gestaoProdutos = new Vetores(new List<string>{""});
    
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string produtoF = "";
            double preco = 0;

            if (tbxPreco.Text == "" || tbxProduto.Text == "") {
                MessageBox.Show("Preencha os campos que estão vazios.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string produtoN = tbxProduto.Text;
                preco = Convert.ToDouble(tbxPreco.Text);
                produtoF = ($"{produtoN} - R${preco}");
                preco = Convert.ToDouble(tbxPreco.Text);
                _gestaoProdutos.Adicionar(produtoF);
                MessageBox.Show($"O produto {produtoN} foi adicionado na lista com o preço de R${preco}.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbxProdutos.Items.Add(produtoF);
                tbxPreco.Clear();
                tbxProduto.Clear();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(lbxProdutos.SelectedItem != null) {
                string produtoR = lbxProdutos.SelectedItem.ToString();
                _gestaoProdutos.Remover(produtoR);
                lbxProdutos.Items.Remove(produtoR);
                MessageBox.Show($"O produto {produtoR} foi removido da lista com sucesso.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            DialogResult respotaConfirmacao = MessageBox.Show("Você realmente deseja apagar todos os produtos cadastrados na lista? Esta ação é irreversível.", "Notificação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respotaConfirmacao == DialogResult.Yes)
            {
                lbxProdutos.Items.Clear();
                _gestaoProdutos.LimparLista();
                MessageBox.Show("A lista de produtos foi apagada completamente.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
