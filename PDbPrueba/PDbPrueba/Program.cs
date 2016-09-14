using System;
using MySql.Data.MySqlClient;
namespace PDbPrueba
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			MySqlConnection mySqlConnection = new MySqlConnection ("");
		}
	}
}
