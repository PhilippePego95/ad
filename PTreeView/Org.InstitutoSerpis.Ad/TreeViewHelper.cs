using System;
using Gtk;
namespace Org.InstitutoSerpis.Ad
{
	public class TreeViewHelper	{

		public static void AppendColumns(TreeView treeView, string [] columnsNames){
			foreach (string columName in columnsNames) {
				treeView.AppendColumn (columName, new CellRendererText (),
				    delegate (TreeViewColumn tree_column, CellRenderer cell, TreeModel tree_model, TreeIter iter){
						int Column = Array.IndexOf(treeView.Columns, tree_column);
						CellRendererText cellRendererText = (CellRendererText)cell;
						object value = tree_model.GetValue(iter, 2);
						cellRendererText.Text = value.ToString();
					}
				);
			}
		}
	}
}

