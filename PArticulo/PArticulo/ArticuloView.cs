using Gtk;
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Org.InstitutoSerpis.Ad;

namespace PArticulo
{
	public partial class ArticuloView : Gtk.Window
	{

		public ArticuloView () : 
				base(Gtk.WindowType.Toplevel) {
			this.Build ();

			spinButtonPrecio.Value = 0;
			saveAction.Sensitive = false;

			saveAction.Activated += delegate {
				Console.WriteLine ("saveAction.Activated");
				string nombre = entryNombre.Text;
				decimal precio = (decimal)spinButtonPrecio.Value;
				TreeIter treeIter; 
				comboBoxCategoria.GetActiveIter(out treeIter);
				comboBoxCategoria.Model.GetValue(treeIter,0);

				string insertSql ="insert into articulo (nombre, precio) values (@nombre,@precio)";
				IDbCommand dbCommand = App.Instance.DbConnection.CreateCommand ();
				dbCommand.CommandText = insertSql;
				DBCommandHelper.AddParameter (dbCommand, "nombre", nombre);
				DBCommandHelper.AddParameter (dbCommand, "precio", precio);
				dbCommand.ExecuteNonQuery ();
				};

			entryNombre.Changed += delegate {
				string content = entryNombre.Text.Trim();
				saveAction.Sensitive = content != string.Empty;
				};
			

			/*List<Categoria> list = new List<Categoria> ();
			list.Add (new Categoria (1L, "categoria 1"));
			list.Add (new Categoria (2L, "categoria 2"));
			list.Add (new Categoria (3L, "categoria 3"));
			ComboBoxHelper.Fill(comboBoxCategoria, list ,"Nombre");

			*/


		}

	/*	public void fillComboBox(ComboBox comboBox, IList list, string propertyName){
			Type listType = list.GetType ();
			Type elementType = listType.GetGenericArguments () [0];
			PropertyInfo propertyInfo= elementType.GetProperty (propertyName);
				ListStore listStore = new ListStore (typeof(object));
				foreach (object item in  list)
					listStore.AppendValues (item);
				comboBox.Model = listStore;
				CellRendererText cellRendererText = new CellRendererText ();
				comboBox.PackStart (cellRendererText, false);
				comboBox.SetCellDataFunc (cellRendererText,
				     delegate(CellLayout cell_layout, CellRenderer cell, TreeModel tree_model, TreeIter iter) {
						object item = tree_model.GetValue(iter,0);
						object value= propertyInfo.GetValue(item, null);
						cellRendererText.Text = value.ToString();
				}
			);
		}*/
	
	}
	public class Categoria{
		public Categoria (long id, string nombre) {
			Id = id;
			Nombre = nombre;

		}

		public long Id 		   { set; get; }
		public string Nombre   { set; get; }
	}
}

