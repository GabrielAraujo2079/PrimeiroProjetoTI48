using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PrimeiroProjetoTI48
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }


        string conexao = @"Server=JUN0684693W11-1\BDSENAC;Database=AgendaDB;User Id=senacLivre;Password=senaclivre;";


        private void frmAgendda_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            CarregarGrid();
        }


        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }


        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }


        void CarregarGrid()
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = "SELECT * FROM Contatos ORDER BY ID";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome!");
                return;
            }

            if (!EmailValido(txtEmail.Text))
            {
                MessageBox.Show("E-mail inválido!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = @"INSERT INTO Contatos (Nome, Telefone, Email, DataRegistro)
                               VALUES (@Nome, @Telefone, @Email, @DataRegistro)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DataRegistro", txtDateTimePiker.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Contato adicionado com sucesso!");

            CarregarGrid();
            LimparCampos();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione um registro!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = @"UPDATE Contatos SET 
                               Nome=@Nome,
                               Telefone=@Telefone,
                               Email=@Email,
                               DataRegistro=@DataRegistro
                               WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DataRegistro", txtDateTimePiker.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro alterado com sucesso!");

            CarregarGrid();
            LimparCampos();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir!");
                return;
            }

            if (MessageBox.Show("Deseja excluir este registro?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(conexao))
            {
                string sql = "DELETE FROM Contatos WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro excluído com sucesso!");

            CarregarGrid();
            LimparCampos();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
           
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}