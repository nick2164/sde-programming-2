using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;


namespace Opgave1 {
	public static class Connections2 {
		
		public static void connection() {
			string host = "185.31.176.28", port = "3306", username = "dbuserrw", password = "TQ7U1Q7SY6aXXyaI1no3iqEXsjE8TT";
			MySql.Data.MySqlClient.MySqlConnection conn;
			string myConnectionString;

			myConnectionString = string.Format("server={0};uid={1};pwd={2};database=Programming2;",host,username,password);

			try {
				conn = new MySql.Data.MySqlClient.MySqlConnection( myConnectionString );

				conn.Open();
				Console.WriteLine("Test");
			}
			catch( MySql.Data.MySqlClient.MySqlException ex ) {
				Console.WriteLine( ex.Message );
			}


		}

	}
}