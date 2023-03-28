using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula1pds
{
    public partial class cadastrarContato : Form
    {
        private MySqlConnection _conexao;

        public cadastrarContato()
        {
            InitializeComponent();

            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;" + "user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                var data = tbNascimento.Text;
                var nome = tbNome.Text;
                var email = tbEmail.Text;
                var sexo = tbSexo.Text;
                var telefone = tbTelefone.Text;

                var sql = "INSERT INTO contato_con (nome_con, email_con, sexo_con, telefone_con, nascimento_con) VALUES (@_nome, @_email, @_sexo, @_telefone, @_nascimento)";
                var comando = new MySqlCommand(sql, _conexao);

                comando.Parameters.AddWithValue("@_nome", nome);
                comando.Parameters.AddWithValue("@_email", email);
                comando.Parameters.AddWithValue("@_sexo", sexo);
                comando.Parameters.AddWithValue("@_telefone", telefone);
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados salvos com sucesso!!!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreram erros ao salvar as informações!!! contate a equipe de suporte");
            }

            tbNome.Clear();
            tbSexo.Clear();
            tbNascimento.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();

        }

    }
}     