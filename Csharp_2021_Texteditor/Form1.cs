using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_2021_Texteditor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSpeichern_Click(object sender, EventArgs e)
		{
			try
			{
				// SaveFileDialog erstellen
				var sfd = new SaveFileDialog()
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					Filter = "Textdateien (*.txt)|*.txt",
					Title = "Datei speichern"
				};

				// SaveFileDialog anzeigen & Rückgabe auswerten => Datei speichern
				if (sfd.ShowDialog() == DialogResult.OK) 
					File.WriteAllText(sfd.FileName, txtEditor.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnÖffnen_Click(object sender, EventArgs e)
		{
			try
			{
				// OpenFileDialog erstellen
				var ofd = new OpenFileDialog()
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					Filter = "Textdateien (*.txt)|*.txt",
					Title = "Datei öffnen"
				};

				// OpenFileDialog anzeigen, Rückgabe auswerten => Datei lesen
				if (ofd.ShowDialog() == DialogResult.OK)
					txtEditor.Text = File.ReadAllText(ofd.FileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBeenden_Click(object sender, EventArgs e)
		{
			var abfrageBeenden = MessageBox.Show("Wollen Sie wirklich beenden?", "Beenden",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (abfrageBeenden == DialogResult.OK) Close();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			var abfrageBeenden = MessageBox.Show("Wollen Sie wirklich beenden?", "Beenden",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (abfrageBeenden == DialogResult.Cancel) e.Cancel = true;
		}
	}
}
