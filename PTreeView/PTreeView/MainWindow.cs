using System;
using MySql.Data.MySqlClient;
using System.Data;
using Gtk;
using Org.InstitutoSerpis.Ad;

public partial class MainWindow: Gtk.Window {

	public MainWindow (): base (Gtk.WindowType.Toplevel) {
		Build ();

		string[] columnNames = {"id", "nombre","precio"};
		TreeViewHelper.AppendColumns(treeView,columnNames);
		ListStore listStore = new ListStore (typeof(long),typeof(string),typeof(decimal));
		treeView.Model = listStore;
			
	}
}
