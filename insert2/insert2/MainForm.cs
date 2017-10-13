/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 21/09/2017
 * Time: 08:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace insert2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string sql;
			Conn conn = new Conn();
			 	sql="SELECT * FROM login where userlogin ='"+txt_user.Text+"' and pass='"+txt_pass.Text+"';";
			if (conn.Login (sql)){
				
				MessageBox.Show("Bem Vindo");	
			}
			
			else {
				MessageBox.Show("Deu errado");
			}
			//conn.Login ("SELECT * FROM login where userlogin ='"+txt_user.Text+"' and pass='"+txt_pass.Text+"';") ;

			
			
			 
            }
			
			
      /*{
		if (result==true) 
		{
			MessageBox.Show("Logado");
			//OutroForm.Show(); 
			this.Close();  
		}
		else
		{
			MessageBox.Show("Usuário ou senha inválido");
		}
        }

//Logado = result
	


	//if (logado == true)
//{

//MessageBox.Show("Seja bem vindo!");

//this.Close();
//}
//else
//{
//MessageBox.Show("Usuário ou senha incorreto!");
//}
			}
			
			
			
		}
       */}}
