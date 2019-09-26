using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramentas;


namespace UI
{
    public partial class frmBackupBancoDeDados : Form
    {
        public frmBackupBancoDeDados()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {          
            try
            {
                SaveFileDialog d = new SaveFileDialog(); //criando o backup indicando onde iremos salvar o bak
                d.Filter = "Backup Files|*.bak"; // definindo um filto pra o dialog, onde o nosso filtro serão todos os arquivos com as extensões .back
                d.ShowDialog(); //pede para o usuário informar onde ele vai salvar o backup

                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string localBackup = d.FileName;
                    string conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User="+ //vou me conectar no servidor e selecionar o banco master.
                        DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha; //usuário e senha do banco de dados
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);

                    MessageBox.Show("Backup realizado com sucesso!");
                }
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnRestaura_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog(); //criando o backup indicando onde iremos restaurar o bak
                d.Filter = "Backup Files|*.bak"; // definindo um filto pra o dialog, onde o nosso filtro serão todos os arquivos com as extensões .back
                d.ShowDialog(); //pede para o usuário informar o que ele quer restaurar

                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string localBackup = d.FileName; 
                    string conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User="+ //vou me conectar no servidor e selecionar o banco master.
                        DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha; //usuário e senha do banco de dados
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName); //informando os dados da conexão, o banco e o arquivo.

                    MessageBox.Show("Backup restaurado com sucesso!");
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
