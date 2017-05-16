using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Opgave1 {
	public static class Connection {

		static SQLiteConnection m_dbConnection;

		public static void Run() {

			SQLiteConnection.CreateFile( "MyDatabase.sqlite" );

			// m_dbConnection = new SQLiteConnection( "Data Source=MyDatabase.sqlite;Version=3;" );
			// m_dbConnection.Open();

		}


	}
}