
// This file has been generated by the GUI designer. Do not modify.
namespace PArticulo
{
	public partial class ArticuloView
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action saveAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.Toolbar toolbar1;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox comboBoxCategoria;
		private global::Gtk.Entry entryNombre;
		private global::Gtk.HBox hbox1;
		private global::Gtk.SpinButton spinButtonPrecio;
		private global::Gtk.Label label3;
		private global::Gtk.Label Nomnre;
		private global::Gtk.Label Preu;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PArticulo.ArticuloView
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.saveAction = new global::Gtk.Action ("saveAction", null, null, "gtk-save");
			w1.Add (this.saveAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "PArticulo.ArticuloView";
			this.Title = global::Mono.Unix.Catalog.GetString ("ArticuloView");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child PArticulo.ArticuloView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='saveAction' action='saveAction'/></toolbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.vbox1.Add (this.toolbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboBoxCategoria = new global::Gtk.ComboBox ();
			this.comboBoxCategoria.Name = "comboBoxCategoria";
			this.table1.Add (this.comboBoxCategoria);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboBoxCategoria]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryNombre = new global::Gtk.Entry ();
			this.entryNombre.CanFocus = true;
			this.entryNombre.Name = "entryNombre";
			this.entryNombre.IsEditable = true;
			this.entryNombre.InvisibleChar = '•';
			this.table1.Add (this.entryNombre);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNombre]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinButtonPrecio = new global::Gtk.SpinButton (-1000000, 10000000, 1);
			this.spinButtonPrecio.CanFocus = true;
			this.spinButtonPrecio.Name = "spinButtonPrecio";
			this.spinButtonPrecio.Adjustment.PageIncrement = 10;
			this.spinButtonPrecio.ClimbRate = 1;
			this.spinButtonPrecio.Numeric = true;
			this.hbox1.Add (this.spinButtonPrecio);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.spinButtonPrecio]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Categoria");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.Nomnre = new global::Gtk.Label ();
			this.Nomnre.Name = "Nomnre";
			this.Nomnre.Xalign = 1F;
			this.Nomnre.LabelProp = global::Mono.Unix.Catalog.GetString ("Nom");
			this.table1.Add (this.Nomnre);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.Nomnre]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.Preu = new global::Gtk.Label ();
			this.Preu.Name = "Preu";
			this.Preu.Xalign = 1F;
			this.Preu.LabelProp = global::Mono.Unix.Catalog.GetString ("Preu");
			this.table1.Add (this.Preu);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.Preu]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w10.Position = 1;
			w10.Expand = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 393;
			this.DefaultHeight = 158;
			this.Show ();
		}
	}
}
