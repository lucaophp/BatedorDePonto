using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string login=txt_Login.Text;
            string senha=txt_pass.Text;
            if (login != string.Empty && senha != string.Empty)
            {
                DAO dao = new DAO();
                dao.conn();
                dao.connect.Open();
                OleDbCommand cmd = new OleDbCommand("select [Matricula] from tb_admin where Login='"+login+"' AND Senha='"+senha+"'", dao.connect);
                OleDbDataReader reader=cmd.ExecuteReader();
                int x=0;
                while (reader.Read()) { x++; }
                if (x == 0 || x > 1)
                {
                    MessageBox.Show("Login incorreto!!!");
                    reader.Close();
                    dao.connect.Close();
                    return;
                }
                
                
                this.Hide();
                new FRMAdmin().ShowDialog();
                reader.Close();
                dao.connect.Close();

            }
            

        }

        private void btn_Cancela_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
