namespace MioGestionaleAccess
{
    public partial class Form_EventoDettagli
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
            this.labelNomeEvento = new System.Windows.Forms.Label();
            this.textBoxNomeEvento = new System.Windows.Forms.TextBox();
            this.labelDataInizio = new System.Windows.Forms.Label();
            this.dateTimePickerInizio = new System.Windows.Forms.DateTimePicker();
            this.labelDataFine = new System.Windows.Forms.Label();
            this.dateTimePickerFine = new System.Windows.Forms.DateTimePicker();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelTipologia = new System.Windows.Forms.Label();
            this.comboBoxTipologia = new System.Windows.Forms.ComboBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label Nome Evento
            this.labelNomeEvento.AutoSize = true;
            this.labelNomeEvento.Location = new System.Drawing.Point(12, 15);
            this.labelNomeEvento.Name = "labelNomeEvento";
            this.labelNomeEvento.Size = new System.Drawing.Size(90, 13);
            this.labelNomeEvento.TabIndex = 0;
            this.labelNomeEvento.Text = "Nome Evento *";
            this.labelNomeEvento.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Nome Evento
            this.textBoxNomeEvento.Location = new System.Drawing.Point(12, 35);
            this.textBoxNomeEvento.Name = "textBoxNomeEvento";
            this.textBoxNomeEvento.Size = new System.Drawing.Size(350, 20);
            this.textBoxNomeEvento.TabIndex = 1;
            this.textBoxNomeEvento.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxNomeEvento.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Data Inizio
            this.labelDataInizio.AutoSize = true;
            this.labelDataInizio.Location = new System.Drawing.Point(12, 65);
            this.labelDataInizio.Name = "labelDataInizio";
            this.labelDataInizio.Size = new System.Drawing.Size(85, 13);
            this.labelDataInizio.TabIndex = 2;
            this.labelDataInizio.Text = "Data Inizio *";
            this.labelDataInizio.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // DateTimePicker Data Inizio
            this.dateTimePickerInizio.Location = new System.Drawing.Point(12, 85);
            this.dateTimePickerInizio.Name = "dateTimePickerInizio";
            this.dateTimePickerInizio.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerInizio.TabIndex = 3;
            this.dateTimePickerInizio.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Label Data Fine
            this.labelDataFine.AutoSize = true;
            this.labelDataFine.Location = new System.Drawing.Point(200, 65);
            this.labelDataFine.Name = "labelDataFine";
            this.labelDataFine.Size = new System.Drawing.Size(80, 13);
            this.labelDataFine.TabIndex = 4;
            this.labelDataFine.Text = "Data Fine *";
            this.labelDataFine.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // DateTimePicker Data Fine
            this.dateTimePickerFine.Location = new System.Drawing.Point(200, 85);
            this.dateTimePickerFine.Name = "dateTimePickerFine";
            this.dateTimePickerFine.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerFine.TabIndex = 5;
            this.dateTimePickerFine.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Label Cliente
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 115);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(59, 13);
            this.labelCliente.TabIndex = 6;
            this.labelCliente.Text = "Cliente *";
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // ComboBox Cliente
            this.comboBoxCliente.Location = new System.Drawing.Point(12, 135);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(350, 21);
            this.comboBoxCliente.TabIndex = 7;
            this.comboBoxCliente.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.comboBoxCliente.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Tipologia
            this.labelTipologia.AutoSize = true;
            this.labelTipologia.Location = new System.Drawing.Point(12, 165);
            this.labelTipologia.Name = "labelTipologia";
            this.labelTipologia.Size = new System.Drawing.Size(83, 13);
            this.labelTipologia.TabIndex = 8;
            this.labelTipologia.Text = "Tipo Evento *";
            this.labelTipologia.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // ComboBox Tipologia
            this.comboBoxTipologia.Location = new System.Drawing.Point(12, 185);
            this.comboBoxTipologia.Name = "comboBoxTipologia";
            this.comboBoxTipologia.Size = new System.Drawing.Size(350, 21);
            this.comboBoxTipologia.TabIndex = 9;
            this.comboBoxTipologia.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.comboBoxTipologia.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Note
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(12, 215);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(35, 13);
            this.labelNote.TabIndex = 10;
            this.labelNote.Text = "Note";
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Note
            this.textBoxNote.Location = new System.Drawing.Point(12, 235);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(350, 60);
            this.textBoxNote.TabIndex = 11;
            this.textBoxNote.Multiline = true;
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxNote.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Button Salva
            this.buttonSalva.Location = new System.Drawing.Point(196, 310);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(80, 25);
            this.buttonSalva.TabIndex = 12;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.buttonSalva.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Button Annulla
            this.buttonAnnulla.Location = new System.Drawing.Point(282, 310);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(80, 25);
            this.buttonAnnulla.TabIndex = 13;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.buttonAnnulla.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Form_EventoDettagli
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ClientSize = new System.Drawing.Size(375, 350);
            this.Controls.Add(this.labelNomeEvento);
            this.Controls.Add(this.textBoxNomeEvento);
            this.Controls.Add(this.labelDataInizio);
            this.Controls.Add(this.dateTimePickerInizio);
            this.Controls.Add(this.labelDataFine);
            this.Controls.Add(this.dateTimePickerFine);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.labelTipologia);
            this.Controls.Add(this.comboBoxTipologia);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.buttonAnnulla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_EventoDettagli";
            this.Text = "Evento Dettagli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelNomeEvento;
        private System.Windows.Forms.TextBox textBoxNomeEvento;
        private System.Windows.Forms.Label labelDataInizio;
        private System.Windows.Forms.DateTimePicker dateTimePickerInizio;
        private System.Windows.Forms.Label labelDataFine;
        private System.Windows.Forms.DateTimePicker dateTimePickerFine;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelTipologia;
        private System.Windows.Forms.ComboBox comboBoxTipologia;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonAnnulla;
    }
}
