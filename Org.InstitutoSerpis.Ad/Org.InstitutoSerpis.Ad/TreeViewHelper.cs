using System;
using Gtk;
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
}
}

