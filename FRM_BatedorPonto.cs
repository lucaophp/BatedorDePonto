using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CadastroAlunos
{
    public partial class FRM_BatedorPonto : Form
    {
        //private OleDbConnection conexao=null;
        public OleDbConnection Conexao { get; set; }
        public bool statusSair = false;
        public FRM_BatedorPonto()
        {
            InitializeComponent();
            listarMatriculas();
        }
        public void listarMatriculas()
        {
            DAO dao = new DAO();

            dao.conn();
            this.Conexao = dao.connect;
            dao.connect.Open();
            OleDbCommand cmd = new OleDbCommand("select p.Matricula,u.Nome from tb_presenca as p inner join tb_usuario as u on u.Matricula=p.Matricula where [DataHoraSaida] IS NULL", dao.connect);

            OleDbDataReader datareader = cmd.ExecuteReader();
            labelPrincipal.Text = " ";

            while (datareader.Read())
            {
                labelPrincipal.Text += "\n" + datareader.GetInt32(0)+"\t "+datareader.GetString(1);
            }
            dao.connect.Close();
        }

        private void Frm_Teclado(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.button1_Click(e, e);
                    
                    break;
                case Keys.F1:
                    sobre_Click(e, e);
                    break;
                
                case Keys.F12:
                    new FRM_Login().ShowDialog();
                    
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Conexao.Open();
            int matriculaDigitada;
            try
            {
                matriculaDigitada=Int32.Parse(IN_matricula.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Apenas números");
                this.Conexao.Close();

                return;
            }
            finally
            {

            }
            
            
            OleDbCommand cmd = new OleDbCommand("select [Matricula] from tb_usuario where [Matricula] = "+matriculaDigitada, this.Conexao);

            OleDbDataReader datareader = cmd.ExecuteReader();
            int verificaSeExiste=0;
            while (datareader.Read()){verificaSeExiste++;}
           
            if (verificaSeExiste == 0)
            {
                MessageBox.Show("Matricula inexistente");
                this.Conexao.Close();
                return;
                

            }
            this.Conexao.Close();
            this.Conexao.Open();

            OleDbCommand cmd2 = new OleDbCommand("select [Codigo] from tb_presenca where [Matricula]=" + matriculaDigitada + " AND [DataHoraSaida] is null", this.Conexao);
            verificaSeExiste = 0;
            
            //datareader = new OleDbDataReader();
            int codigo = 1;
            OleDbDataReader datareader2 = cmd2.ExecuteReader();

            while (datareader2.Read())
            {
                codigo = datareader2.GetInt32(0);
                verificaSeExiste++;
            }
            this.Conexao.Close();
           
            
            if (verificaSeExiste != 0)
            {
                this.Conexao.Open();

                cmd.CommandText = "update tb_presenca set [DataHoraSaida]='"+DateTime.Now+"' where [Codigo]="+codigo+"";
                cmd.ExecuteNonQuery();
                
                this.Conexao.Close();
                this.listarMatriculas();

                new FRMSair().ShowDialog();
                return;
            }
            this.Conexao.Open();
            cmd.CommandText="insert into tb_presenca ([Matricula],[DataHoraEntrada]) values("+matriculaDigitada+",'"+DateTime.Now+"')";
            cmd.ExecuteNonQuery();
            
            this.Conexao.Close();
            this.listarMatriculas();
            


        }

        private void labelPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarMatriculas();
            
        }

        private void tickReloj(object sender, EventArgs e)
        {
            
            DateTime status= DateTime.Now;
            StatusLabel.Text=status.ToLongTimeString();
        }

        private void sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Um presente do Departamento de Projetos Gestão 2015.\n Para a infoalto. \n Desenvolvido por: Lucas Batista Fialho\n Desenvolvido em C#.\n Duvidas envie um e-mail: lucas.b.fialho@ufv.br");

        }

        private void fechando(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Estou aki!!";
            try
            {
                if (!statusSair)
                {
                    e.Cancel = true;
                    this.Hide();

                }
                


            }
            catch (Exception ex)
            {

            }



        }

        public void balaoDuploClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusSair = true;
            this.Close();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Show();
            
        }

        private void adminAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_Login().ShowDialog();

        }
        
    }
}
