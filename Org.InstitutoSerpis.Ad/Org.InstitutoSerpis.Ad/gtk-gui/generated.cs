
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;

		internal static void Initialize (Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false)) {
				Stetic.Gui.initialized = true;
			}
		}
	}

	internal class ActionGroups
	{
		private static global::Gtk.ActionGroup group1;
		private static global::Gtk.ActionGroup group2;

		public static Gtk.ActionGroup GetActionGroup (System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup (type.FullName);
		}

		public static Gtk.ActionGroup GetActionGroup (string name)
		{
			if ((name == "Org.InstitutoSerpis.Ad.ComboBoxHelper")) {
				if ((global::Stetic.ActionGroups.group1 == null)) {
					global::Stetic.ActionGroups.group1 = new Org.InstitutoSerpis.Ad.ComboBoxHelper ();
				}
				return global::Stetic.ActionGroups.group1;
			} else {
				if ((name == "Org.InstitutoSerpis.Ad.Null")) {
					if ((global::Stetic.ActionGroups.group2 == null)) {
						global::Stetic.ActionGroups.group2 = new Org.InstitutoSerpis.Ad.Null ();
					}
					return global::Stetic.ActionGroups.group2;
				} else {
					return null;
				}
			}
		}
	}
}