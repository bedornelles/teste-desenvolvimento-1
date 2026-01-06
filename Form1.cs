using System;
using System.Windows.Forms;
using CadastroProdutosCervantes.Data;
using Npgsql;

namespace CadastroProdutosCervantes
{
    public partial class Form1 : Form
    {
        private readonly ProdutoRepository repository;

        enum eEvento
        {
            inserir,
            atualizar
        }
        private eEvento evento = eEvento.atualizar;

        public Form1()
        {
            InitializeComponent();
            repository = new ProdutoRepository();

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DgvProdutos.DataSource = repository.ListarProdutos();
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Text = DgvProdutos.Rows[e.RowIndex].Cells["codigo_produto"].Value.ToString();
                TxtNome.Text = DgvProdutos.Rows[e.RowIndex].Cells["nome_produto"].Value.ToString();

                evento = eEvento.atualizar;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }

            int codigo = int.Parse(TxtCodigo.Text);

            var confirmacao = MessageBox.Show(
                "Tem certeza que quer exlcuir este produto?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.No)
                return;

            try
            {
                repository.ExcluirProduto(codigo);

                CarregarLista();
                TxtCodigo.Clear();
                TxtNome.Clear();

                MessageBox.Show("Produto excluído!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            DgvProdutos.DataSource = repository.ListarProdutos();

        }

        private void InserirProduto(int codigo, string nome)
        {
            repository.InserirProduto(codigo, nome);
            CarregarLista();
        }

        private bool AtualizarProduto(int codigo, string nome)
        {
            bool atualizado = repository.AtualizarProduto(codigo, nome);
            if (!atualizado)
            {
                MessageBox.Show("Produto não encontrado. Selecione um item da lista.");
                return false;
            }

            CarregarLista();
            return true;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtCodigo.Clear();

            TxtCodigo.Enabled = true;

            evento = eEvento.inserir;

            TxtCodigo.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                MessageBox.Show("Informe o código do produto.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            { 
                MessageBox.Show("Informe o nome do produto.");
                return;
            }           

            int codigo = int.Parse(TxtCodigo.Text);
            if (codigo <= 0)
            {
                MessageBox.Show("O código deve ser um número maior que zero.");
                return;
            }
            string nome = TxtNome.Text;

            switch (evento)
            {
                case eEvento.inserir:
                    try
                    {
                        InserirProduto(codigo, nome);

                        MessageBox.Show("Produto inserido!");
                    }
                    catch (PostgresException ex) when (ex.SqlState == "23505")
                    {
                        MessageBox.Show("Já existe um produto com esse código!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case eEvento.atualizar:
                    try
                    {
                        bool sucesso = AtualizarProduto(codigo, nome);
                        if (!sucesso) return;

                        MessageBox.Show("Produto atualizado!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
            evento = eEvento.atualizar;
            TxtCodigo.Clear();
            TxtNome.Clear();

        }
    }
}