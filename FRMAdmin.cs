using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;


namespace CadastroAlunos
{
    public partial class FRMAdmin : Form
    {
        public OleDbConnection conn;
        public FRMAdmin()
        {
            DAO dao=new DAO();
            dao.conn();
            this.conn=dao.connect;
            InitializeComponent();
            lbl_listaadm.Text = this.listaAdm();
        }
        public string listaAdm()
        {
            string str="==== Administradores ====\n";
            try
            {
                if (ConnectionState.Open != this.conn.State)
                {
                    this.conn.Open();
                }
                
                OleDbCommand cmd = new OleDbCommand("SELECT Matricula,Login FROM tb_admin",this.conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    str += dr.GetValue(dr.GetOrdinal("Matricula"))+"\t -  " +dr.GetValue(dr.GetOrdinal("Login"))+"\n";
                }
                if (ConnectionState.Closed != this.conn.State)
                {
                    this.conn.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return str;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //Admin_UserCadastrados_CLICK(e, e);

        }

        private void FRMAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCONTROLEDataSet.tb_presenca' table. You can move, or remove it, as needed.
            //this.tb_presencaTableAdapter.Fill(this.dBCONTROLEDataSet.tb_presenca);
            this.carregaUsuarios();

        }
        
        

        private void click_user(object sender, MouseEventArgs e)
        {
            this.carregaUsuarios();
        }
        public void carregaUsuarios()
        {
            DAO dao = new DAO();
            dao.conn();
            dao.connect.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * from tb_usuario", dao.connect);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);




            DataTable dt = new DataTable();
            da.Fill(dt);


            this.dataGridView1.DataSource = dt;
        }

        private void cadastrarBTN_Click(object sender, EventArgs e)
        {
            int matricula;
            string nome;
            try
            {
                matricula=Int32.Parse(IN_Cad_Matricula.Text);
                nome=IN_Cad_Nome.Text;
                if (matricula == 0)
                {
                    this.conn.Close();
                    throw new Exception("A Matricula não pode zero ou nula!!!");
                }
                if (nome.Equals(""))
                {
                    this.conn.Close();
                    throw new Exception("Preencha o campo nome!!!");

                }
                this.conn.Open();
                OleDbCommand cmd = new OleDbCommand("select [Matricula] from tb_usuario where [Matricula]="+matricula+"",this.conn);
                OleDbDataReader dataReader = cmd.ExecuteReader();
                bool status=true;
                while (dataReader.Read()) { status = false; break; }
                if (!status)
                {
                    this.conn.Close();
                    throw new Exception("Erro \n Matricula Existente!!!");
                }
                this.conn.Close();
                this.conn.Open();
                cmd.CommandText = "insert into tb_usuario (Matricula,Nome) values("+matricula+",'"+nome+"');";
                MessageBox.Show(cmd.ExecuteNonQuery()==0?"Erro ao Cadastrar":"Cadastrado Com Sucesso!!!");
                this.conn.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void excluirBTN_Click(object sender, EventArgs e)
        {
            int matricula;
            try
            {
                matricula=Int32.Parse(IN_Cad_Matricula.Text);
                this.conn.Open();
                
                OleDbCommand cmd = new OleDbCommand("delete from tb_usuario where [Matricula]="+matricula+"",this.conn);

                MessageBox.Show(cmd.ExecuteNonQuery()==0?"Erro ao excluir":"Excluido com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.conn.Close();
            }
        }

        private void horas_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void onclick(object sender, EventArgs e)
        {
            this.conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Matricula,DataHoraEntrada AS Entrada,DataHoraSaida AS Saida FROM tb_presenca ", this.conn);
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            this.conn.Close();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            string inicio = dataInicio.Value.ToString("yyyy/MM/dd");
            string fim = dataFim.Value.ToString("yyyy/MM/dd");
            string partMatricula=string.Empty;
            if (txt_matricula.Text.Trim() != string.Empty && !txt_matricula.Text.Trim().Equals("##Matricula##"))
            {
                try
                {
                    int mat = Int32.Parse(txt_matricula.Text.Trim());

                    partMatricula = "AND Matricula=" + mat + "";
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Apenas Números\n " + fe.Message, "Formato Invalido");
                }

            }
            

            this.conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Matricula,DataHoraEntrada AS Entrada,DataHoraSaida AS Saida FROM tb_presenca WHERE (DataHoraEntrada between #"+inicio+"# AND #"+fim+"#) "+partMatricula+"", this.conn);
           
           
            

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            this.conn.Close();
            //MessageBox.Show("SELECT Matricula,DataHoraEntrada AS Entrada,DataHoraSaida AS Saida FROM tb_presenca WHERE Entrada>=''");
            
        }

        private void txt_matricula_Click(object sender, EventArgs e)
        {
            txt_matricula.Text = string.Empty;
        }
        /**
         *Excluir Administrador 
         */
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            
            int matricula=0;
            try
            {
                matricula = Int32.Parse(txt_Mat_Adm.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Apenas Numeros "+ex.Message);
            }
            this.conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM tb_admin WHERE Matricula=" + matricula + "",this.conn);
            MessageBox.Show(cmd.ExecuteNonQuery()==0?"Erro ao excluir o usuario":"Usuario cadastrado com sucesso");
            this.conn.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txt_Login_Adm.Text.Trim();
                string senha = txt_Pass_Adm.Text.Trim();
                int matricula = Int32.Parse(txt_Mat_Adm.Text.Trim());
                this.conn.Open();
                //verifica se existe um login identico ou matricula;
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM tb_admin WHERE Login='" + login + "' OR Matricula=" + matricula + "", this.conn);
                int conta=Int32.Parse(cmd.ExecuteScalar()+"");
                if (conta == 0)
                {
                    cmd.CommandText = "INSERT INTO tb_admin (Matricula,Login,Senha) VALUES (" + matricula + ",'" + login + "','" + senha + "')";
                    MessageBox.Show(cmd.ExecuteNonQuery()==0?"Erro ao Inserir":"Inserido com Sucesso!!!");
                    lbl_listaadm.Text = this.listaAdm();
                }else{
                    MessageBox.Show("Erro existe uma matricula ou login cadastrado...");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(this.conn.State!=ConnectionState.Closed){
                    this.conn.Close();

                }
                
            }
             


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE ",this.conn);
            
        }
    }
}
