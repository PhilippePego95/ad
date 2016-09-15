using System;

namespace PCategoria
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("\n0.Eixir" +"\n1.Nou" +"\n2.Editar" +"\n3.Eliminar" + "\n4.Llistar");
			readLong ("Introduce el id: ");
		//	String opc = null;
		//	opc = Console.ReadKey ().ToString ();

			switch (Console.Read()) {
			case '0':
				Console.Write ("Eixint..");
				//Environment.Exit();
				break;
			case '1':

				break;
			case '2':

				break;
			case '3':

				break;
			case '4':

				break;
			}


		}
		private static long readLong (String label)
		{
			while (true) {
				Console.WriteLine (label);
				string data = Console.ReadLine ();
				try {
					return long.Parse (data);
				} catch {
					Console.WriteLine ("Sols numeros");
				}

			}
		}

	}
}
