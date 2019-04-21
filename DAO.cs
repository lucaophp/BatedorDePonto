using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;


namespace CadastroAlunos
{
    class DAO
    {
        private OleDbConnection _connect;
        #region "getters and setters"
        public OleDbConnection connect
        {
            get { return this._connect; }

            set { this._connect = value; }
        }
        #endregion
        public DAO(){

            
        }
        public bool conn()
        {
            try
            {

                String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBCONTROLE.accdb;";
                
                this.connect = new OleDbConnection();
                this.connect.ConnectionString = connection;
                this.connect.Open();
                return true;

            }
            catch (OleDbException ex)
            {

                return false;

            }
            finally
            {
                this.connect.Close();
            }
            
            
            
        }
    }
}
