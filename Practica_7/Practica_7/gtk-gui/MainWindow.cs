
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Entry txtNombre;
	private global::Gtk.Label lblNombre;
	private global::Gtk.Label lblCodigo;
	private global::Gtk.Label lblPregunta1;
	private global::Gtk.Entry txtCodigo;
	private global::Gtk.Label lblrespueta1a;
	private global::Gtk.Label lblPregunta2;
	private global::Gtk.Label lblPregunta3;
	private global::Gtk.Label lblRespueta2a;
	private global::Gtk.Label lblPregunta4;
	private global::Gtk.SpinButton spbRespuesta2;
	private global::Gtk.ComboBox cmbGrupo;
	private global::Gtk.Label lblGrupo;
	private global::Gtk.RadioButton rburespuesta1a;
	private global::Gtk.Label lblrespueta1b;
	private global::Gtk.RadioButton rburespuesta1b;
	private global::Gtk.Label lblrespueta1c;
	private global::Gtk.RadioButton rburespuesta1c;
	private global::Gtk.Label lblrespueta1d;
	private global::Gtk.RadioButton rburespuesta1d;
	private global::Gtk.CheckButton ckbRespuesta3a;
	private global::Gtk.Label lblRespueta2b;
	private global::Gtk.CheckButton ckbRespuesta3b;
	private global::Gtk.Label lblRespueta2c;
	private global::Gtk.CheckButton ckbRespuesta3c;
	private global::Gtk.Label lblRespueta2d;
	private global::Gtk.CheckButton ckbRespuesta3d;
	private global::Gtk.Calendar calendario;
	private global::Gtk.Button btnTerminar;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtNombre = new global::Gtk.Entry ();
		this.txtNombre.CanFocus = true;
		this.txtNombre.Name = "txtNombre";
		this.txtNombre.IsEditable = true;
		this.txtNombre.InvisibleChar = '●';
		this.fixed1.Add (this.txtNombre);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtNombre]));
		w1.X = 87;
		w1.Y = 13;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblNombre = new global::Gtk.Label ();
		this.lblNombre.Name = "lblNombre";
		this.lblNombre.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
		this.fixed1.Add (this.lblNombre);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblNombre]));
		w2.X = 22;
		w2.Y = 19;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblCodigo = new global::Gtk.Label ();
		this.lblCodigo.Name = "lblCodigo";
		this.lblCodigo.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo");
		this.fixed1.Add (this.lblCodigo);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblCodigo]));
		w3.X = 22;
		w3.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblPregunta1 = new global::Gtk.Label ();
		this.lblPregunta1.Name = "lblPregunta1";
		this.lblPregunta1.LabelProp = global::Mono.Unix.Catalog.GetString ("1-.¿PERSONAJE DE LA INDEPENDENCIA DE MEXICO?");
		this.fixed1.Add (this.lblPregunta1);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblPregunta1]));
		w4.X = 24;
		w4.Y = 98;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtCodigo = new global::Gtk.Entry ();
		this.txtCodigo.CanFocus = true;
		this.txtCodigo.Name = "txtCodigo";
		this.txtCodigo.IsEditable = true;
		this.txtCodigo.InvisibleChar = '●';
		this.fixed1.Add (this.txtCodigo);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtCodigo]));
		w5.X = 87;
		w5.Y = 45;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblrespueta1a = new global::Gtk.Label ();
		this.lblrespueta1a.Name = "lblrespueta1a";
		this.lblrespueta1a.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.lblrespueta1a);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblrespueta1a]));
		w6.X = 21;
		w6.Y = 136;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblPregunta2 = new global::Gtk.Label ();
		this.lblPregunta2.Name = "lblPregunta2";
		this.lblPregunta2.LabelProp = global::Mono.Unix.Catalog.GetString ("2-.¿Cuanto es 2*2?");
		this.fixed1.Add (this.lblPregunta2);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblPregunta2]));
		w7.X = 31;
		w7.Y = 174;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblPregunta3 = new global::Gtk.Label ();
		this.lblPregunta3.Name = "lblPregunta3";
		this.lblPregunta3.LabelProp = global::Mono.Unix.Catalog.GetString ("3-.¿Cuales paises son de America?");
		this.fixed1.Add (this.lblPregunta3);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblPregunta3]));
		w8.X = 29;
		w8.Y = 235;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblRespueta2a = new global::Gtk.Label ();
		this.lblRespueta2a.Name = "lblRespueta2a";
		this.lblRespueta2a.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.lblRespueta2a);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblRespueta2a]));
		w9.X = 27;
		w9.Y = 262;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblPregunta4 = new global::Gtk.Label ();
		this.lblPregunta4.Name = "lblPregunta4";
		this.lblPregunta4.LabelProp = global::Mono.Unix.Catalog.GetString ("4-.¿Indique la fecha de la Independencia de Mexico?");
		this.fixed1.Add (this.lblPregunta4);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblPregunta4]));
		w10.X = 38;
		w10.Y = 326;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.spbRespuesta2 = new global::Gtk.SpinButton (0D, 100D, 1D);
		this.spbRespuesta2.CanFocus = true;
		this.spbRespuesta2.Name = "spbRespuesta2";
		this.spbRespuesta2.Adjustment.PageIncrement = 10D;
		this.spbRespuesta2.ClimbRate = 1D;
		this.spbRespuesta2.Numeric = true;
		this.fixed1.Add (this.spbRespuesta2);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.spbRespuesta2]));
		w11.X = 150;
		w11.Y = 203;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.cmbGrupo = global::Gtk.ComboBox.NewText ();
		this.cmbGrupo.AppendText (global::Mono.Unix.Catalog.GetString ("A"));
		this.cmbGrupo.AppendText (global::Mono.Unix.Catalog.GetString ("B"));
		this.cmbGrupo.AppendText (global::Mono.Unix.Catalog.GetString ("C"));
		this.cmbGrupo.AppendText (global::Mono.Unix.Catalog.GetString ("D"));
		this.cmbGrupo.AppendText (global::Mono.Unix.Catalog.GetString ("E"));
		this.cmbGrupo.Name = "cmbGrupo";
		this.fixed1.Add (this.cmbGrupo);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.cmbGrupo]));
		w12.X = 411;
		w12.Y = 22;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblGrupo = new global::Gtk.Label ();
		this.lblGrupo.Name = "lblGrupo";
		this.lblGrupo.LabelProp = global::Mono.Unix.Catalog.GetString ("Grupo");
		this.fixed1.Add (this.lblGrupo);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblGrupo]));
		w13.X = 350;
		w13.Y = 24;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.rburespuesta1a = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Lola la Trailera"));
		this.rburespuesta1a.CanFocus = true;
		this.rburespuesta1a.Name = "rburespuesta1a";
		this.rburespuesta1a.DrawIndicator = true;
		this.rburespuesta1a.UseUnderline = true;
		this.rburespuesta1a.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed1.Add (this.rburespuesta1a);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.rburespuesta1a]));
		w14.X = 38;
		w14.Y = 135;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblrespueta1b = new global::Gtk.Label ();
		this.lblrespueta1b.Name = "lblrespueta1b";
		this.lblrespueta1b.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.lblrespueta1b);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblrespueta1b]));
		w15.X = 158;
		w15.Y = 137;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.rburespuesta1b = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("El Chavo Del 8"));
		this.rburespuesta1b.CanFocus = true;
		this.rburespuesta1b.Name = "rburespuesta1b";
		this.rburespuesta1b.DrawIndicator = true;
		this.rburespuesta1b.UseUnderline = true;
		this.rburespuesta1b.Group = this.rburespuesta1a.Group;
		this.fixed1.Add (this.rburespuesta1b);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.rburespuesta1b]));
		w16.X = 174;
		w16.Y = 136;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblrespueta1c = new global::Gtk.Label ();
		this.lblrespueta1c.Name = "lblrespueta1c";
		this.lblrespueta1c.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.lblrespueta1c);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblrespueta1c]));
		w17.X = 292;
		w17.Y = 137;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.rburespuesta1c = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Miguel Hidalgo y Costilla"));
		this.rburespuesta1c.CanFocus = true;
		this.rburespuesta1c.Name = "rburespuesta1c";
		this.rburespuesta1c.DrawIndicator = true;
		this.rburespuesta1c.UseUnderline = true;
		this.rburespuesta1c.Group = this.rburespuesta1a.Group;
		this.fixed1.Add (this.rburespuesta1c);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.rburespuesta1c]));
		w18.X = 304;
		w18.Y = 135;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblrespueta1d = new global::Gtk.Label ();
		this.lblrespueta1d.Name = "lblrespueta1d";
		this.lblrespueta1d.LabelProp = global::Mono.Unix.Catalog.GetString ("d)");
		this.fixed1.Add (this.lblrespueta1d);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblrespueta1d]));
		w19.X = 470;
		w19.Y = 135;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.rburespuesta1d = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Laura Bozzo"));
		this.rburespuesta1d.CanFocus = true;
		this.rburespuesta1d.Name = "rburespuesta1d";
		this.rburespuesta1d.DrawIndicator = true;
		this.rburespuesta1d.UseUnderline = true;
		this.rburespuesta1d.Group = this.rburespuesta1a.Group;
		this.fixed1.Add (this.rburespuesta1d);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.rburespuesta1d]));
		w20.X = 484;
		w20.Y = 134;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbRespuesta3a = new global::Gtk.CheckButton ();
		this.ckbRespuesta3a.CanFocus = true;
		this.ckbRespuesta3a.Name = "ckbRespuesta3a";
		this.ckbRespuesta3a.Label = global::Mono.Unix.Catalog.GetString ("Mexico");
		this.ckbRespuesta3a.DrawIndicator = true;
		this.ckbRespuesta3a.UseUnderline = true;
		this.fixed1.Add (this.ckbRespuesta3a);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbRespuesta3a]));
		w21.X = 40;
		w21.Y = 262;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblRespueta2b = new global::Gtk.Label ();
		this.lblRespueta2b.Name = "lblRespueta2b";
		this.lblRespueta2b.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.lblRespueta2b);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblRespueta2b]));
		w22.X = 145;
		w22.Y = 262;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbRespuesta3b = new global::Gtk.CheckButton ();
		this.ckbRespuesta3b.CanFocus = true;
		this.ckbRespuesta3b.Name = "ckbRespuesta3b";
		this.ckbRespuesta3b.Label = global::Mono.Unix.Catalog.GetString ("Argentina");
		this.ckbRespuesta3b.DrawIndicator = true;
		this.ckbRespuesta3b.UseUnderline = true;
		this.fixed1.Add (this.ckbRespuesta3b);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbRespuesta3b]));
		w23.X = 159;
		w23.Y = 261;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblRespueta2c = new global::Gtk.Label ();
		this.lblRespueta2c.Name = "lblRespueta2c";
		this.lblRespueta2c.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.lblRespueta2c);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblRespueta2c]));
		w24.X = 262;
		w24.Y = 260;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbRespuesta3c = new global::Gtk.CheckButton ();
		this.ckbRespuesta3c.CanFocus = true;
		this.ckbRespuesta3c.Name = "ckbRespuesta3c";
		this.ckbRespuesta3c.Label = global::Mono.Unix.Catalog.GetString ("Alemania");
		this.ckbRespuesta3c.DrawIndicator = true;
		this.ckbRespuesta3c.UseUnderline = true;
		this.fixed1.Add (this.ckbRespuesta3c);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbRespuesta3c]));
		w25.X = 277;
		w25.Y = 259;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblRespueta2d = new global::Gtk.Label ();
		this.lblRespueta2d.Name = "lblRespueta2d";
		this.lblRespueta2d.LabelProp = global::Mono.Unix.Catalog.GetString ("d)");
		this.fixed1.Add (this.lblRespueta2d);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblRespueta2d]));
		w26.X = 381;
		w26.Y = 259;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ckbRespuesta3d = new global::Gtk.CheckButton ();
		this.ckbRespuesta3d.CanFocus = true;
		this.ckbRespuesta3d.Name = "ckbRespuesta3d";
		this.ckbRespuesta3d.Label = global::Mono.Unix.Catalog.GetString ("Japon");
		this.ckbRespuesta3d.DrawIndicator = true;
		this.ckbRespuesta3d.UseUnderline = true;
		this.fixed1.Add (this.ckbRespuesta3d);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.ckbRespuesta3d]));
		w27.X = 395;
		w27.Y = 258;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calendario = new global::Gtk.Calendar ();
		this.calendario.CanFocus = true;
		this.calendario.Name = "calendario";
		this.calendario.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.fixed1.Add (this.calendario);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.calendario]));
		w28.X = 157;
		w28.Y = 352;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnTerminar = new global::Gtk.Button ();
		this.btnTerminar.CanFocus = true;
		this.btnTerminar.Name = "btnTerminar";
		this.btnTerminar.UseUnderline = true;
		this.btnTerminar.Label = global::Mono.Unix.Catalog.GetString ("Terminar");
		this.fixed1.Add (this.btnTerminar);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnTerminar]));
		w29.X = 504;
		w29.Y = 487;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 637;
		this.DefaultHeight = 575;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnTerminar.Clicked += new global::System.EventHandler (this.OnBtnTerminarClicked);
	}
}
