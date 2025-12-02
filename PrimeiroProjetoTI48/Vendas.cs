using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrimeiroProjetoTI48
{
    public partial class Vendas : Form
    {
        string conexao = @"Server=JUN0684693W11-1\BDSENAC;Database=AgendaDB;User Id=senacLivre;Password=senaclivre;";




        int idSelecionado = 0; // ID vem do DataGridView

        public Vendas()
        {
            InitializeComponent();
        }

        // ============================
        // CARREGAR TABELA
        // ============================
        private void Vendas_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos", con);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                dg.DataSource = tabela;
            }
        }

        // ============================
        // ADICIONAR
        // ============================
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = @"INSERT INTO Produtos 
                               (Nome, Descricao, Preco, Estoque, Categoria)
                               VALUES (@Nome, @Descricao, @Preco, @Estoque, @Categoria)";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Descricao", textDesc.Text);
                cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@Estoque", int.Parse(txtEstoque.Text));
                cmd.Parameters.AddWithValue("@Categoria", textCategoria.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Produto adicionado!");
                CarregarTabela();
            }
        }

        // ============================
        // SELECIONAR LINHA DO GRID
        // ============================
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dg.Rows[e.RowIndex];

                idSelecionado = int.Parse(row.Cells["ID_Proutos"].Value.ToString());

                txtNome.Text = row.Cells["Nome"].Value.ToString();
                textDesc.Text = row.Cells["Descricao"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
                txtEstoque.Text = row.Cells["Estoque"].Value.ToString();
                textCategoria.Text = row.Cells["Categoria"].Value.ToString();
            }
        }

        // ============================
        // ALTERAR
        // ============================
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto no DataGridView!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = @"UPDATE Produtos SET 
                               Nome=@Nome, Descricao=@Descricao, Preco=@Preco,
                               Estoque=@Estoque, Categoria=@Categoria
                               WHERE ID_Proutos=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", idSelecionado);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Descricao", textDesc.Text);
                cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@Estoque", int.Parse(txtEstoque.Text));
                cmd.Parameters.AddWithValue("@Categoria", textCategoria.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Produto alterado!");
                CarregarTabela();
            }
        }

        // ============================
        // EXCLUIR
        // ============================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = "DELETE FROM Produtos WHERE ID_Proutos=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", idSelecionado);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Produto excluído!");
                CarregarTabela();
            }
        }
    }
}
