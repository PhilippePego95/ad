using System;
using Gtk;
using Org.InstitutoSerpis.Ad;

public partial class MainWindow: Gtk.Window {	
	public MainWindow (): base (Gtk.WindowType.Toplevel){
		Build ();

		TreeViewHelper.AppendColumns (treeView, new string [] { "id", "nombre", "precio"});
		ListStore listStore = new ListStore (typeof(long), typeof(string),typeof(decimal));
		listStore.AppendValues (1L, "categoria 1",3.2m);
		listStore.AppendValues (2L, "categoria 2",3.1m);
		treeView.Model = listStore;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
