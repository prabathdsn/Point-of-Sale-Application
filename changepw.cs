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
    public partial class changepw : Form
    {
        public changepw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dbConnection = "datasource=localhost;port=3306;username=root";
            string Query = "UPDATE `log`.`passworddata` SET `username`='" + this.txt3.Text + "', `password`='" + this.txt2.Text + "' WHERE `password`='" + this.txt1.Text + "';";
            //update maindata.data set Barcode=" + this.txtba.Text + "',Item name='" + this.txtit.Text + "',Price='" + this.txtpr.Text + "',Store='" + this.txtin.Text + "',Specifications='" + this.txtsp.Text + "' where Barcode='" + this.txtba.Text + "' ;";

            MySqlConnection dbcon = new MySqlConnection(dbConnection);
            MySqlCommand cmddatabase = new MySqlCommand(Query, dbcon);
            //MySqlDataAdapter dbadapter=new MySqlDataAdapter();
            //dbadapter.SelectCommand=new MySqlCommand("select*database.e data;",dbcon);
            //MySqlCommandBuilder comb=new MySqlCommandBuilder(dbadapter);
            //dbcon.Open();
            //DataSet ds = new DataSet();
            //MessageBox.Show("Database connected");
            //dbcon.Close();
            MySqlDataReader myreader;
            try
            {
                dbcon.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("saved");
                while (myreader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
