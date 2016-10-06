using System;
using Gtk;

namespace PTreeView2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();

			win.Show ();
			Application.Run ();
		}
	}
}
