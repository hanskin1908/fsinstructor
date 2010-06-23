/*
 * Creado por SharpDevelop.
 * Usuario: s0rcerer
 * Fecha: 22/06/2010
 * Hora: 5:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FSInstructor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Fsuipc fsuipc = new Fsuipc();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
