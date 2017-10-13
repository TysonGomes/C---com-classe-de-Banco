using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace insert2
{
    class Conn
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Conn()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "localhost";
            database = "teste01";
            uid = "nigga";
            password = "9886";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível se conectar no banco de dados.  Contate o administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Usuário e/ou senha inválido, por favor tente novamente");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement

        public void Insert(String SQL)
        {

            string query = SQL;

            //open connection 
            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command 
                cmd.ExecuteNonQuery();

                //close connection 
                this.CloseConnection();

            }}
            
        public bool Login(string SQL)
{
   string query = SQL;
    

    
    MySqlCommand cmd = new MySqlCommand(query, connection);
    cmd.CommandType = CommandType.Text;

    this.OpenConnection();
    MySqlDataReader dr= cmd.ExecuteReader();
if (dr.HasRows)
                {
                    //usuario existe
                    return true;
                }
                else
                {
                    //usuario nao existe
                    return false;
                }
            }
            /*catch (Exception)
            {
                return false;
                throw;
            }*/
        }
    }


        
        
        
        
        
        
        
            
          /*  public void Login(String SQL){
            
{
 
 string query = SQL;



this.OpenConnection();

MySqlCommand cmd = new MySqlCommand(query, connection);

var resultado = cmd.ExecuteScalar();

      if (resultado is DBNull) // Se não retornar nada é  nao loga 
            {
      	MessageBox.Show("usuario errado");
		//return false; 
	    }
	    else
	    {
	    	MessageBox.Show("Logado");
		//return true; 
            }
        	}}}}*/
