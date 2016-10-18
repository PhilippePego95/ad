using Gtk;
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;


namespace Org.InstitutoSerpis.Ad {

	public class TreeViewHelper {

		public static void AppendColumns (TreeView treeView, string [] ColumnsNames) {
			foreach (string colummName in ColumnsNames){
				treeView.AppendColumn(colummName, new CellRendererText(),				                      	
			         delegate(TreeViewColumn tree_column, CellRenderer cell, TreeModel tree_model, TreeIter iter) {
					int column = Array.IndexOf(treeView.Columns, tree_column);
					CellRendererText cellRendererText = (CellRendererText)cell;
					object value = tree_model.GetValue(iter, column);
					cellRendererText.Text = value.ToString();
			      }
			);
		}
	}
		public static void AppendColumns(TreeView treeView, Type type){
			PropertyInfo[] propertyInfos = type.GetProperties ();
			List<string> propertyNames = new List<string> ();
			foreach (PropertyInfo propertyInfo in propertyInfos)
				propertyNames.Add (propertyInfo.Name);
			AppendColumns (treeView, propertyNames.ToArray ());
		}
		public static void Fill(TreeView treeView, IList list){
			Type listType = list.GetType ();
			Type elementType = listType.GetGenericArguments () [0];
			PropertyInfo[] propertyInfos = elementType.GetProperties ();
			foreach (PropertyInfo propertyInfo in propertyInfos) {
				string columnName = propertyInfo.Name;
				treeView.AppendColumn (columnName, new CellRendererText (),
					delegate(TreeViewColumn Tree_column, CellRenderer CellView, 
				  	  	TreeModel Tree_model, TreeIter Iter){
						object  item = Tree_model.GetValue(Iter, 0);
						object value = propertyInfo.GetValue(item,null);
						CellRendererText cellRendererText = (CellRendererText)CellView;	
						cellRendererText.Text  = " "+value;
					}
				);
			}

			ListStore listStore = new ListStore (typeof(object));
			treeView.Model = listStore;
			foreach (object item in list)
				listStore.AppendValues (item);
		}
	}
}

