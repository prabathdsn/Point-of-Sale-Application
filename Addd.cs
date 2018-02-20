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
    public partial class Addd : Form
    {
        public Addd()
        {
            InitializeComponent();
        }



        
        

        private void btnsa_Click_1(object sender, EventArgs e)
        
            {
            
            
            string dbConnection = "datasource=localhost;port=3306;username=root";
            string Query = "INSERT INTO `maindata`.`data` (`Barcode`, `Item`, `Price`, `Store`, `Specifications`) VALUES ('" + this.txtba.Text + "','" + this.txtit.Text + "','" + this.txtpr.Text + "','" + this.txtin.Text + "','" + this.txtsp.Text + "') ;";
            //insert into maindata.data (Barcode,Item name,Price,Store,Specifications) values('" + this.txtba.Text + "','" + this.txtit.Text + "','" + this.txtpr.Text + "','" + this.txtin.Text + "','" + this.txtsp.Text + "') ;";

            MySqlConnection dbcon = new MySqlConnection(dbConnection);
            MySqlCommand cmddatabase = new MySqlCommand(Query, dbcon);
            MySqlDataReader myreader;
            try
            {
                dbcon.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("saved");
                while (myreader.Read())
                {
                }
                

       
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string dbConnection = "datasource=localhost;port=3306;username=root";
            string Query = "UPDATE `maindata`.`data` SET `Barcode`='" + this.txtba.Text + "', `Item`='" + this.txtit.Text + "' WHERE `Barcode`='"+this.txtba.Text+"';";
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtba.Text = " ";
            txtin.Text = " ";
            txtit.Text = " ";
            txtpr.Text = " ";
            txtsp.Text = " ";
        }
    }
}
