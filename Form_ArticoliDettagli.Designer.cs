namespace MioGestionaleAccess
{
    partial class Form_ArticoliDettagli
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
            // Form_ArticoliDettagli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.Name = "Form_ArticoliDettagli";
            this.Text = "Dettagli Articolo";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            
            // Label Codice
            this.labelCodice = new System.Windows.Forms.Label();
            this.labelCodice.Text = "Codice Interno:";
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
            this.textBoxDescrizione.Size = new System.Drawing.Size(260, 80);
            this.textBoxDescrizione.Multiline = true;
            this.textBoxDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescrizione.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBoxDescrizione.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.textBoxDescrizione.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.textBoxDescrizione);
            
            // Label Giacenza
            this.labelGiacenza = new System.Windows.Forms.Label();
            this.labelGiacenza.Text = "Giacenza:";
            this.labelGiacenza.Location = new System.Drawing.Point(15, 135);
            this.labelGiacenza.Size = new System.Drawing.Size(100, 20);
            this.labelGiacenza.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelGiacenza);
            
            // TextBox Giacenza
            this.textBoxGiacenza = new System.Windows.Forms.TextBox();
            this.textBoxGiacenza.Location = new System.Drawing.Point(120, 135);
            this.textBoxGiacenza.Size = new System.Drawing.Size(260, 20);
            this.textBoxGiacenza.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBoxGiacenza.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.textBoxGiacenza.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.textBoxGiacenza);
            
            // Label Fornitore
            this.labelFornitore = new System.Windows.Forms.Label();
            this.labelFornitore.Text = "Fornitore:";
            this.labelFornitore.Location = new System.Drawing.Point(15, 165);
            this.labelFornitore.Size = new System.Drawing.Size(100, 20);
            this.labelFornitore.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelFornitore);
            
            // ComboBox Fornitore
            this.comboBoxFornitore = new System.Windows.Forms.ComboBox();
            this.comboBoxFornitore.Location = new System.Drawing.Point(120, 165);
            this.comboBoxFornitore.Size = new System.Drawing.Size(260, 25);
            this.comboBoxFornitore.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comboBoxFornitore.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.comboBoxFornitore.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.comboBoxFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controls.Add(this.comboBoxFornitore);

            // Button + Fornitore
            this.buttonAggiungiFornitore = new System.Windows.Forms.Button();
            this.buttonAggiungiFornitore.Location = new System.Drawing.Point(385, 165);
            this.buttonAggiungiFornitore.Size = new System.Drawing.Size(20, 20);
            this.buttonAggiungiFornitore.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAggiungiFornitore.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAggiungiFornitore.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonAggiungiFornitore.Text = "+";
            this.buttonAggiungiFornitore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Controls.Add(this.buttonAggiungiFornitore);
            
            // Label Tipologia
            this.labelTipologia = new System.Windows.Forms.Label();
            this.labelTipologia.Text = "Tipologia:";
            this.labelTipologia.Location = new System.Drawing.Point(15, 195);
            this.labelTipologia.Size = new System.Drawing.Size(100, 20);
            this.labelTipologia.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelTipologia);
            
            // ComboBox Tipologia
            this.comboBoxTipologia = new System.Windows.Forms.ComboBox();
            this.comboBoxTipologia.Location = new System.Drawing.Point(120, 195);
            this.comboBoxTipologia.Size = new System.Drawing.Size(260, 25);
            this.comboBoxTipologia.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comboBoxTipologia.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.comboBoxTipologia.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.comboBoxTipologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controls.Add(this.comboBoxTipologia);

            // Button + Tipologia
            this.buttonAggiungiTipologiaArticoli = new System.Windows.Forms.Button();
            this.buttonAggiungiTipologiaArticoli.Location = new System.Drawing.Point(385, 195);
            this.buttonAggiungiTipologiaArticoli.Size = new System.Drawing.Size(20, 20);
            this.buttonAggiungiTipologiaArticoli.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAggiungiTipologiaArticoli.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAggiungiTipologiaArticoli.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonAggiungiTipologiaArticoli.Text = "+";
            this.buttonAggiungiTipologiaArticoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Controls.Add(this.buttonAggiungiTipologiaArticoli);   
            
            // Label Note
            this.labelNote = new System.Windows.Forms.Label();
            this.labelNote.Text = "Note:";
            this.labelNote.Location = new System.Drawing.Point(15, 225);
            this.labelNote.Size = new System.Drawing.Size(100, 20);
            this.labelNote.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Controls.Add(this.labelNote);
            
            // TextBox Note
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxNote.Location = new System.Drawing.Point(120, 225);
            this.textBoxNote.Size = new System.Drawing.Size(260, 150);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.textBoxNote.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.textBoxNote);
            
            // Button Salva
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonSalva.Location = new System.Drawing.Point(120, 385);
            this.buttonSalva.Size = new System.Drawing.Size(120, 30);
            this.buttonSalva.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonSalva.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Text = "Salva";
            this.Controls.Add(this.buttonSalva);
            
            // Button Annulla
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonAnnulla.Location = new System.Drawing.Point(260, 385);
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
        private System.Windows.Forms.Label labelGiacenza;
        private System.Windows.Forms.TextBox textBoxGiacenza;
        private System.Windows.Forms.Label labelFornitore;
        private System.Windows.Forms.ComboBox comboBoxFornitore;
        private System.Windows.Forms.Label labelTipologia;
        private System.Windows.Forms.ComboBox comboBoxTipologia;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Button buttonAggiungiFornitore;
        private System.Windows.Forms.Button buttonAggiungiTipologiaArticoli;
    }
}
