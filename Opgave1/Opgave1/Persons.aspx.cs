using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Opgave1;
using MySql.Data.MySqlClient;
using System.Data;

namespace Opgave1 {
	public partial class Persons : System.Web.UI.Page {
        string host = "185.31.176.28", port = "3306", username = "dbuserrw", password = "TQ7U1Q7SY6aXXyaI1no3iqEXsjE8TT";

        protected void Page_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

            searchData( searchBox.Text, DropDownList1.SelectedValue );

        }

        protected void Unnamed3_Click( object sender, EventArgs e ) {

            if (nameError.IsValid == true && ageError.IsValid == true && mailError.IsValid == true)
            {
                insertData(Name.Text,Age.Text,Mail.Text);
            }

            updateGridView();

        }

        protected void insertData(string name, string age, string mail)
        {
            string myConnectionString = string.Format(@"Data Source={0};User Id={1};Password='{2}';Database=Programming2;", host, username, password);

            DataSourceSign.Text = "Connecting";

            try
            {

                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    string sql = string.Format("INSERT INTO `Programming2`.`persons` (`name`, `age`, `mail`) VALUES ('{0}', '{1}', '{2}')",name,age,mail);
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    DataSourceSign.Text = "Completed";
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                DataSourceSign.Text = ex.Message;
            }
        }

        protected void updateGridView()
        {
            string myConnectionString = string.Format(@"Data Source={0};User Id={1};Password='{2}';Database=Programming2;", host, username, password);
            

            try
            {

                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter("SELECT name, age, mail FROM Programming2.persons;", conn);
                    DataTable dt = new DataTable();

                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            catch (MySqlException ex)
            {
                DataSourceSign.Text = ex.Message;
            }
        }

        protected void searchData(string value, string type)
        {
            string myConnectionString = string.Format(@"Data Source={0};User Id={1};Password='{2}';Database=Programming2;", host, username, password);


            try
            {

                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {

                    string sqlQuery = string.Format("SELECT name, age, mail FROM Programming2.persons WHERE {0} LIKE '%{1}%'",type,value);
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);
                    DataTable dt = new DataTable();

                    adp.Fill(dt);
                    
                        GridView2.DataSource = dt;
                        GridView2.DataBind();
                    
                }
            }
            catch (MySqlException ex)
            {
                DataSourceSign.Text = ex.Message;
            }
        }

    }
}