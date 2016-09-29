using System;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using Gtk;

public partial class MainWindow: Gtk.Window {
	public static IDbConnection dbConnection;
	private static string SELECT_SQL = "select * from articulo order by id";

	public MainWindow (): base (Gtk.WindowType.Toplevel) {
		Build ();
		dbConnection = new MySqlConnection ("Database=dbprueba;User Id=root;Password=sistemas");
		dbConnection.Open ();

		treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText (), "text", 1);
		treeView.AppendColumn ("precio", new CellRendererText (), "text", 2);
		treeView.AppendColumn ("categoria", new CellRendererText (), "text", 3);

		ListStore listStore = new ListStore (typeof(long), typeof(string), typeof(string), typeof(long));

		treeView.Model = listStore;
		IDbCommand dbCommand = dbConnection.CreateCommand ();
		dbCommand.CommandText = SELECT_SQL;
		IDataReader dataReader = dbCommand.ExecuteReader ();
		while (dataReader.Read()) 
		listStore.AppendValues (dataReader["id"], dataReader ["nombre"], ""+dataReader["precio"],dataReader["categoria"]);
		dataReader.Close ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
		Application.Quit ();
		a.RetVal = true;
	}
	public void listar(){

	}
}
