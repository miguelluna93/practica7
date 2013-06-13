using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnTerminarClicked (object sender, EventArgs e)
	{
		int puntos=0;
		if (this.rburespuesta1c.Active) puntos++;
		if (this.spbRespuesta2.Text=="4") puntos++;
		if (this.ckbRespuesta3a.Active) puntos++;
		if (this.ckbRespuesta3b.Active) puntos++;
		DateTime Fecha=this.calendario.GetDate();
		string fechaSeleccionada=Fecha.ToShortDateString();
		if (fechaSeleccionada=="16/09/2013"){
			puntos++;
		}
		MessageDialog md = new MessageDialog (null,DialogFlags.Modal,MessageType.Info,ButtonsType.None,"Tu Resultado es: "+puntos+" Puntos"); 
		md.Show();
	}
}
