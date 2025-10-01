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
        private Vetores _produtos = new Vetores("", 0);
        public FormV23()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string produto = "";
            double preco = 0;

            if (tbxPreco.Text == "" || tbxProduto.Text == "") {
                MessageBox.Show("Preencha os campos que estão vazios.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                produto = tbxProduto.Text;
                preco = Convert.ToDouble(tbxPreco.Text);
                string resultado = _produtos.Adicionar(produto, preco);
                MessageBox.Show($"O produto {produto} foi adicionado na lista com o preço de R${preco}.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbxProdutos.Items.Add(resultado);
                tbxPreco.Clear();
                tbxProduto.Clear();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(lbxProdutos.SelectedItem != null) {
                string produtoF = lbxProdutos.SelectedItem.ToString();
                lbxProdutos.Items.Remove(produtoF);
                MessageBox.Show($"O produto {produtoF} foi removido da lista com sucesso.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.", "Notifiação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            DialogResult respotaConfirmacao = MessageBox.Show("Você realmente deseja apagar todos os produtos cadastrados na lista? Esta ação é irreversível.", "Notificação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respotaConfirmacao == DialogResult.Yes)
            {
                lbxProdutos.Items.Clear();
                MessageBox.Show("A lista de produtos foi apagada completamente.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
