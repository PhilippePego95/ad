using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace PDbPrueba
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			IDbConnection dbConnection = new MySqlConnection ("Database=dbprueba; User Id=root; Password=sistemas");
			dbConnection.Open ();
			
			
			Boolean bandera=true;
			do{
				Console.WriteLine ("Tria la opció que vols fer: " +
				                   "\n0.Eixir" +
				                   "\n1.Nou" +
				                   "\n2.Editar" +
				                   "\n3.Eliminar" +
				                   "\n4.Llistar");

				switch (Console.Read())
				{
					case '0': Console.Write("\n Eixint..");
					bandera=false;
					break;
					case '1': Console.Write("\n Creant..");
					// Continuar lógica y extraer métodos //
						//Console.WriteLine ("Probando acceso a dbPrueba");

						

						//operacioins...
						dbConnection.CreateCommand ();

						IDbCommand dbCommand= dbConnection.CreateCommand();
						dbCommand.CommandText = "insert into categoria (nombre) values (@nombre)";

						IDbDataParameter dbDataParameter = dbCommand.CreateParameter ();
						dbDataParameter.ParameterName = "nombre";
						Console.WriteLine("Disme el nom ");
						String nom = Console.ReadLine();
						dbDataParameter.Value = nom;
						dbCommand.Parameters.Add (dbDataParameter);
						dbCommand.ExecuteNonQuery ();
						

						
					break;
					case '2': Console.Write("\n Editant..");

					IDbCommand cmd1 = dbConnection.CreateCommand();
					cmd1.CommandText="Update categoria set nombre =@nombre where id=@id";
					IDataReader dr1 =cmd1.ExecuteReader();
					dr1.Close();
					break;
					case '3': Console.Write("\n Eliminant..");
					// Continuar lógica y extraer métodos //
					break;
					case '4': Console.WriteLine("\n Llistant..");

										
					IDbCommand cmd = dbConnection.CreateCommand();
					cmd.CommandText="Select * From categoria";
					IDataReader dr =cmd.ExecuteReader();

						while(dr.Read()){

							Console.Write(Convert.ToString(dr["id"]));
							Console.WriteLine(Convert.ToString(dr["nombre"]));
																
					}dr.Close();	
				
					break;
				} 
				Console.ReadKey();
			}while (bandera==true);
			
		dbConnection.Close ();
		

	
	/*}private static void parametrosnombre(String parametros,String valor,IDbCommand comand, IDbDataParameter ParameterNombre){
			dataparameternombre.ParameterName = parametrosnombre;
			IDataParameternombre.Value = Valor;
}*/
	}
	}
}
