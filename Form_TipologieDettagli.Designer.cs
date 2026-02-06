namespace MioGestionaleAccess
{
    partial class Form_TipologieDettagli
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form_TipologieDettagli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 300);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.Name = "Form_TipologieDettagli";
            this.Text = "Dettagli Tipologia";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            
            // Label Codice
            this.labelCodice = new System.Windows.Forms.Label();
            this.labelCodice.Text = "Codice:";
            this.labelCodice.Location = new System.Drawing.Point(15, 15);
            this.labelCodice.Size = new System.Drawing.Size(100, 20);
            this.labelCodice.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelCodice);
            
            // TextBox Codice
            this.textBoxCodice = new System.Windows.Forms.TextBox();
            this.textBoxCodice.Location = new System.Drawing.Point(120, 15);
            this.textBoxCodice.Size = new System.Drawing.Size(260, 20);
            this.textBoxCodice.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBoxCodice.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.textBoxCodice.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.textBoxCodice);
            
            // Label Descrizione
            this.labelDescrizione = new System.Windows.Forms.Label();
            this.labelDescrizione.Text = "Descrizione:";
            this.labelDescrizione.Location = new System.Drawing.Point(15, 45);
            this.labelDescrizione.Size = new System.Drawing.Size(100, 20);
            this.labelDescrizione.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelDescrizione);
            
            // TextBox Descrizione
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.textBoxDescrizione.Location = new System.Drawing.Point(120, 45);
            this.textBoxDescrizione.Size = new System.Drawing.Size(260, 20);
            this.textBoxDescrizione.Multiline = false;
            this.textBoxDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescrizione.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBoxDescrizione.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.textBoxDescrizione.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.textBoxDescrizione);
            
            // Label Note
            this.labelNote = new System.Windows.Forms.Label();
            this.labelNote.Text = "Note:";
            this.labelNote.Location = new System.Drawing.Point(15, 75);
            this.labelNote.Size = new System.Drawing.Size(100, 20);
            this.labelNote.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelNote);
            
            // TextBox Note
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxNote.Location = new System.Drawing.Point(120, 75);
            this.textBoxNote.Size = new System.Drawing.Size(260, 150);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.textBoxNote.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.textBoxNote);
            
            // Button Salva
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonSalva.Location = new System.Drawing.Point(120, 245);
            this.buttonSalva.Size = new System.Drawing.Size(120, 30);
            this.buttonSalva.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonSalva.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Text = "Salva";
            this.Controls.Add(this.buttonSalva);
            
            // Button Annulla
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonAnnulla.Location = new System.Drawing.Point(260, 245);
            this.buttonAnnulla.Size = new System.Drawing.Size(120, 30);
            this.buttonAnnulla.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAnnulla.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAnnulla.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.buttonAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulla.Text = "Annulla";
            this.Controls.Add(this.buttonAnnulla);
            
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Label labelCodice;
        private System.Windows.Forms.TextBox textBoxCodice;
        private System.Windows.Forms.Label labelDescrizione;
        private System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonAnnulla;

    }
}
