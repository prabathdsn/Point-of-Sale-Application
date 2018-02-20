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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            fill_list1();
            timer1.Start();
            
            
        }
        decimal n1, n2, ans;
        decimal n3, n4, cha1;
        void fill_list1()
        {
            string dbConstring = "datasource=localhost;port=3306;username=root";
            string sql = "SELECT * FROM maindata.data;";
            MySqlConnection myconn = new MySqlConnection(dbConstring);
            MySqlCommand cmddata = new MySqlCommand(sql, myconn);
            MySqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = cmddata.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString("Item");
                    list1.Items.Add(sname);

                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you need to quit this application", "EXIT", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
            }



        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Addd f3 = new Addd();
            f3.Show();


      

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you need to quit this application", "EXIT", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;

            }
        }



        private void txtitem_KeyPress(object sender, KeyPressEventArgs e)
        { }

        private void button19_Click(object sender, EventArgs e)
        {

            string input2 = txtpri.Text;
            string input = txtitem.Text;
            string dbConstring = "datasource=localhost;port=3306;username=root";
            string sql = "SELECT * from 'maindata'.'data'  WHERE `Item` = '" + txtitem.Text + "';";
            MySqlConnection myconn = new MySqlConnection(dbConstring);
            MySqlCommand cmddata = new MySqlCommand(sql, myconn);
            MySqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = cmddata.ExecuteReader();
                while (myreader.Read())
                {
                    string sBarcode = myreader.GetDouble("Barcode").ToString();
                    string sItem_name = myreader.GetString("Item");
                    string sPrice = myreader.GetDouble("Price").ToString();
                    txtbar.Text = sBarcode;
                    txtitem.Text = sItem_name;
                    txtpri.Text = sPrice;




                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

       
        

        }

        private void txtpri_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btnqn_Click(object sender, EventArgs e)
        {
         
       //textBox1.Text = (int.Parse(txtqn.Text) + nCount).ToString();




       //int count = 0;
            //int add1 = 1;
           //int add2;
            //add1 = int.Parse(txtqn.Text);
            //add2 = int.Parse(txtqn.Text);
           // while (count < 15)
            {

                //count++;
                //add2 = add1 + 1;
                //txtqn.Text = add2.ToString();
            }
           
            

            
        }
        

        private void btnbuy_Click(object sender, EventArgs e)
        {
            try{


                n1 = decimal.Parse(txtpri.Text);
                n2 = decimal.Parse(txtqn.Text);
                //n3=int.Parse(txtpri.Text);
                ans = n1 * n2;
                //n7 = decimal.Parse(txtto.Text);
                //while (cou < 20)
                // {



                //cou = cou + 1;
                //}
                txtdis1.Text = ans.ToString();
                txtto.Text = ans.ToString();
                //txtto.Text =ans.ToString();


                n3 = decimal.Parse(txtpay.Text);
                n4 = decimal.Parse(txtto.Text);
                cha1 = n3 - n4;
                txtdis2.Text = cha1.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = datetime.ToString();


        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbConstring = "datasource=localhost;port=3306;username=root";

            MySqlConnection myconn = new MySqlConnection(dbConstring);

            string sql = "SELECT * FROM maindata.data  WHERE Item ='" + list1.Text + "';";

            //MySqlConnection myconn = new MySqlConnection(dbConstring);
            // MySqlConnection myconn1 = new MySqlConnection(dbConstringe);
            MySqlCommand cmddata = new MySqlCommand(sql, myconn);


            MySqlDataReader myreader;

            try
            {
                myconn.Open();
                myreader = cmddata.ExecuteReader();



                while (myreader.Read())
                {
                    string sBarcode = myreader.GetDouble("Barcode").ToString();
                    string sItem_name = myreader.GetString("Item");
                    string sPrice = myreader.GetDouble("Price").ToString();
                    string sin = myreader.GetString("Store");
                    txtbar.Text = sBarcode;
                    txtitem.Text = sItem_name;
                    txtpri.Text = sPrice;
                    txtstore.Text = sin;




                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
    
 
    
            
         

       

       
 


    
 


    