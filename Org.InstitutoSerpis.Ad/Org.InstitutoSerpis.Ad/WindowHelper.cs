using System;
using Gtk;

namespace Org.InstitutoSerpis.Ad
{
	public class WindowHelper
	{
		public static bool confirm(Window parent, string message){
			MessageDialog messageDialog = new MessageDialog(
				parent,
				DialogFlags.Modal,
				MessageType.Question,
				ButtonsType.YesNo,
				message
				);
			messageDialog.Title = parent.Title;
			ResponseType response = (ResponseType)messageDialog.Run();
			messageDialog.Destroy();
			return response == ResponseType.Yes;
		
		}
	}
}

