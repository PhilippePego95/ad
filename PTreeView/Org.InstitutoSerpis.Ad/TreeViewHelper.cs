using System;
using Gtk;
namespace Org.Institutoserpis.Ad
{
	public class TreeViewHelper	{

		public static void AppendColumns(TreeView treeView, string [] columnsNames){
			int index = 0;
			foreach (string columName in columnsNames) {
			
				treeView.AppendColumn (columName, new CellRendererText (),
				    delegate (TreeViewColumn tree_column, CellRenderer cell, TreeModel tree_model, TreeIter tree_iter){
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

