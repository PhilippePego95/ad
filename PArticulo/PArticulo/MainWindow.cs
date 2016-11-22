using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;

using Org.InstitutoSerpis.Ad;
using PArticulo;

public partial class MainWindow: Gtk.Window
{	private IEntityDao<Articulo> entityDao;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		App.Instance.DbConnection = new MySqlConnection (
			"Database=dbprueba;User Id=root;Password=sistemas"
			);
		App.Instance.DbConnection.Open ();
		//IDbCommand dbCommand = App.Instance.DbConnection.CreateCommand ();
		//dbCommand.CommandText = "update articulo set precio = 0 where precio is null";
		//dbCommand.ExecuteNonQuery ();

		fill ();

		treeView.Selection.Changed += delegate {
			bool selected = treeView.Selection.CountSelectedRows() > 0;
			editAction.Sensitive = selected;
			deleteAction.Sensitive = selected;
		};

		newAction.Activated += delegate {
			Articulo articulo = new Articulo();
			articulo.Nombre= string.Empty;
			articulo.Precio=0;
			new ArticuloView(articulo);
		};

		deleteAction.Activated += delegate {
			if (WindowHelper.confirm(this, "¿Quieres eliminar el registro?"))
				ArticuloDao.Delete(TreeViewHelper.GetId(treeView));
		};


		refreshAction.Activated += delegate {
			fill();
		};

		editAction.Activated += delegate {
		//	ArticuloDao articuloDao=new ArticuloDao();
			Articulo articulo = entityDao.Load((long)TreeViewHelper.GetId(treeView));
			new ArticuloView(articulo);
		};


	}
	public IEntityDao<Articulo> EntityDao{
		set {entityDao = value;}
	}

	private void fill() {
		editAction.Sensitive = false;
		deleteAction.Sensitive = false;
		//IList list = ArticuloDao.GetList ();
		//IList list = EntityDao.GetList<Articulo> ();
		IList list = EntityDao.GetList<Articulo> ();
		TreeViewHelper.Fill (treeView, list);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		App.Instance.DbConnection.Close ();
		Application.Quit ();
		a.RetVal = true;
	}
}
