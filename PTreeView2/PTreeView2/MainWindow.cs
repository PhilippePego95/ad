using System;
using Gtk;
using Org.InstitutoSerpis.Ad;
using System.Collections;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window {	
	public MainWindow (): base (Gtk.WindowType.Toplevel){
		Build ();

		IList list = new List<Articulo> ();
		list.Add (new Articulo(1L,"articulo 1", 1.5m));
		list.Add (new Articulo(2L,"articulo 2", 6.5m));
		list.Add (new Articulo(3L,"articulo 3", 2.5m));


		//List<Categoria> categorias = new List<Categoria> ();
		TreeViewHelper.Fill (treeView, list);

		//TreeViewHelper.AppendColumns (treeView, typeof(Articulo));
		//TreeViewHelper.AppendColumns (treeView, new string [] { "id", "nombre", "precio"});
		//ListStore listStore = new ListStore (typeof(long), typeof(string),typeof(decimal));
		//listStore.AppendValues (1L, "categoria 1",3.2m);
		//listStore.AppendValues (2L, "categoria 2",3.1m);
		//treeView.Model = listStore;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
	public class Categoria{
		public long Id { get; set;}
		public string Nombre { get; set;}
	}

	public class Articulo{
		public Articulo (long id, string nombre, decimal precio){
			
		Id = id;
		Nombre = nombre;
		Precio = precio;
	}
		public long Id { get; set;}
		public string Nombre { get; set;}
		public decimal Precio { get; set;}
}

