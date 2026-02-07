namespace MioGestionaleAccess
{
    public partial class Form_TipologiaArticoloDettagli
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

        private void InitializeComponent()
        {
            this.labelCodice = new System.Windows.Forms.Label();
            this.textBoxCodice = new System.Windows.Forms.TextBox();
            this.labelDescrizione = new System.Windows.Forms.Label();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label Codice
            this.labelCodice.AutoSize = true;
            this.labelCodice.Location = new System.Drawing.Point(12, 15);
            this.labelCodice.Name = "labelCodice";
            this.labelCodice.Size = new System.Drawing.Size(63, 13);
            this.labelCodice.TabIndex = 0;
            this.labelCodice.Text = "Codice *";
            this.labelCodice.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Codice
            this.textBoxCodice.Location = new System.Drawing.Point(12, 35);
            this.textBoxCodice.Name = "textBoxCodice";
            this.textBoxCodice.Size = new System.Drawing.Size(350, 20);
            this.textBoxCodice.TabIndex = 1;
            this.textBoxCodice.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxCodice.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Descrizione
            this.labelDescrizione.AutoSize = true;
            this.labelDescrizione.Location = new System.Drawing.Point(12, 65);
            this.labelDescrizione.Name = "labelDescrizione";
            this.labelDescrizione.Size = new System.Drawing.Size(72, 13);
            this.labelDescrizione.TabIndex = 2;
            this.labelDescrizione.Text = "Descrizione";
            this.labelDescrizione.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Descrizione
            this.textBoxDescrizione.Location = new System.Drawing.Point(12, 85);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(350, 20);
            this.textBoxDescrizione.TabIndex = 3;
            this.textBoxDescrizione.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxDescrizione.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Note
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(12, 115);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(36, 13);
            this.labelNote.TabIndex = 4;
            this.labelNote.Text = "Note";
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Note
            this.textBoxNote.Location = new System.Drawing.Point(12, 135);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(350, 100);
            this.textBoxNote.TabIndex = 5;
            this.textBoxNote.Multiline = true;
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxNote.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Button Salva
            this.buttonSalva.Location = new System.Drawing.Point(150, 250);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(100, 30);
            this.buttonSalva.TabIndex = 6;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonSalva.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.UseVisualStyleBackColor = false;

            // Button Annulla
            this.buttonAnnulla.Location = new System.Drawing.Point(260, 250);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(100, 30);
            this.buttonAnnulla.TabIndex = 7;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAnnulla.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAnnulla.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.buttonAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulla.UseVisualStyleBackColor = false;

            // Form_TipologiaArticoloDettagli
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.labelCodice);
            this.Controls.Add(this.textBoxCodice);
            this.Controls.Add(this.labelDescrizione);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.buttonAnnulla);
            this.Name = "Form_TipologiaArticoloDettagli";
            this.Text = "Dettagli Tipologia Articolo";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
