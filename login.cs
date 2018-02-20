using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnsign_Click(object sender, EventArgs e){
        try
             {
            
            
            string myConnection = "datasource=localhost;port=3306;username=root";
            MySqlConnection mycon = new MySqlConnection(myConnection);

            
            MySqlCommand selectcommand = new MySqlCommand("select * from log.passworddata where username='"+this.txtuser.Text+"' and password='"+this.txtpass.Text+"' ;",mycon);
            MySqlDataAdapter dbadapter=new MySqlDataAdapter();
            
            
            MySqlDataReader myreader;

            mycon.Open();

            myreader = selectcommand.ExecuteReader();
            int count = 0;
            while (myreader.Read())
            {
                count =count + 1;
            }
            if (count ==1)
            {
                MessageBox.Show("user name accepted");
                this.Hide();
                main f1 = new main();
                f1.ShowDialog();
            }
            else if (count>3)
            {
                
                MessageBox.Show("over using a user name");
                this.Close();

            }
              else 
                MessageBox.Show("Wrong user name or password");
            
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncp_Click(object sender, EventArgs e)
        {
            changepw f3 = new changepw();
            f3.Show();

        }
    }
}
