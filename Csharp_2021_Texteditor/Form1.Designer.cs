
namespace Csharp_2021_Texteditor
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtEditor = new System.Windows.Forms.TextBox();
			this.btnÖffnen = new System.Windows.Forms.Button();
			this.btnSpeichern = new System.Windows.Forms.Button();
			this.btnBeenden = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEditor
			// 
			this.txtEditor.Location = new System.Drawing.Point(13, 13);
			this.txtEditor.Multiline = true;
			this.txtEditor.Name = "txtEditor";
			this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtEditor.Size = new System.Drawing.Size(510, 337);
			this.txtEditor.TabIndex = 0;
			// 
			// btnÖffnen
			// 
			this.btnÖffnen.Location = new System.Drawing.Point(13, 357);
			this.btnÖffnen.Name = "btnÖffnen";
			this.btnÖffnen.Size = new System.Drawing.Size(75, 23);
			this.btnÖffnen.TabIndex = 1;
			this.btnÖffnen.Text = "Öffnen";
			this.btnÖffnen.UseVisualStyleBackColor = true;
			this.btnÖffnen.Click += new System.EventHandler(this.btnÖffnen_Click);
			// 
			// btnSpeichern
			// 
			this.btnSpeichern.Location = new System.Drawing.Point(95, 356);
			this.btnSpeichern.Name = "btnSpeichern";
			this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
			this.btnSpeichern.TabIndex = 2;
			this.btnSpeichern.Text = "Speichern";
			this.btnSpeichern.UseVisualStyleBackColor = true;
			this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
			// 
			// btnBeenden
			// 
			this.btnBeenden.Location = new System.Drawing.Point(448, 356);
			this.btnBeenden.Name = "btnBeenden";
			this.btnBeenden.Size = new System.Drawing.Size(75, 23);
			this.btnBeenden.TabIndex = 3;
			this.btnBeenden.Text = "Beenden";
			this.btnBeenden.UseVisualStyleBackColor = true;
			this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 391);
			this.Controls.Add(this.btnBeenden);
			this.Controls.Add(this.btnSpeichern);
			this.Controls.Add(this.btnÖffnen);
			this.Controls.Add(this.txtEditor);
			this.Name = "Form1";
			this.Text = "Ein einfacher Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEditor;
		private System.Windows.Forms.Button btnÖffnen;
		private System.Windows.Forms.Button btnSpeichern;
		private System.Windows.Forms.Button btnBeenden;
	}
}

