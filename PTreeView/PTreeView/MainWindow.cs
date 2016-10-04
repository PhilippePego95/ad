using System;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using Gtk;
using Org.InstitutoSerpis.Ad;

public partial class MainWindow: Gtk.Window {
	//public static IDbConnection dbConnection;
	//private static string SELECT_SQL = "select * from articulo order by id";

	public MainWindow (): base (Gtk.WindowType.Toplevel) {
		Build ();



		string[] columnNames = {"id", "nombre","precio"};
		TreeViewHelper.AppendColumns(treeView,columnNames);
		ListStore listStore = new ListStore (typeof(long),typeof(string),typeof(decimal));
		treeView.Model = listStore;
		/*
		dbConnection = new MySqlConnection ("Database=dbprueba;User Id=root;Password=sistemas");
		dbConnection.Open ();	treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText (), "text", 1);
		treeView.AppendColumn ("precio", new CellRendererText (), //"text", 2);		                      
		                       delegate  TreeViewColumn tree_column, CellRenderer cell, TreeModel tree_model,
			            CellRendererText cellRendererText = (CellRendererText)cell;
		          object value = tree_model.GetValue(iter, 2);
		          cellRendererText.Text = value.ToString();
			            }
		          );

			treeView.AppendColumn ("categoria", new CellRendererText (), "text", 3);	
		ListStore listStore = new ListStore (typeof(long), typeof(string), typeof(string), typeof(long));


		IDbCommand dbCommand = dbConnection.CreateCommand ();
		dbCommand.CommandText = SELECT_SQL;
		IDataReader dataReader = dbCommand.ExecuteReader ();
		while (dataReader.Read()) 
		listStore.AppendValues (dataReader["id"], dataReader ["nombre"], ""+dataReader["precio"],dataReader["categoria"]);
		dataReader.Close ();
		*/

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
		Application.Quit ();
		a.RetVal = true;
	}
	public void listar(){

	}
}
