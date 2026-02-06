namespace MioGestionaleAccess
{
    public partial class Form_stampa
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
            // Form_stampa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 160);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.Name = "Form_stampa";
            this.Text = "Stampa Documenti";
            this.BackColor = System.Drawing.Color.FromArgb(30, 90, 60);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Load += new System.EventHandler(this.Form_stampa_Load);
            this.ResumeLayout(false);
            // Label selezione per datazione intervallo
            this.labelIntervallo = new System.Windows.Forms.Label();
            this.labelIntervallo.Location = new System.Drawing.Point(20, 20);
            this.labelIntervallo.Name = "labelIntervallo";
            this.labelIntervallo.Size = new System.Drawing.Size(200, 25);
            this.labelIntervallo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIntervallo.ForeColor = System.Drawing.Color.Black;
            this.labelIntervallo.BackColor = Form_stampa.DefaultBackColor;
            this.labelIntervallo.BorderStyle = BorderStyle.FixedSingle;
            this.labelIntervallo.Text = "Seleziona intervallo date:";
            // DateTimePicker selezione data inizio
            this.dataInizio = new System.Windows.Forms.DateTimePicker();
            this.dataInizio.Location = new System.Drawing.Point(230, 20);
            this.dataInizio.Name = "dateTimePickerInizio";
            this.dataInizio.Size = new System.Drawing.Size(150, 20);
            this.dataInizio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInizio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataInizio.ForeColor = System.Drawing.Color.Black;
            this.dataInizio.BackColor = Form_stampa.DefaultBackColor;
             // DateTimePicker selezione data fine
            this.dataFine = new System.Windows.Forms.DateTimePicker();
            this.dataFine.Location = new System.Drawing.Point(390, 20);
            this.dataFine.Name = "dateTimePickerFine";
            this.dataFine.Size = new System.Drawing.Size(150, 20);
            this.dataFine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFine.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataFine.ForeColor = System.Drawing.Color.Black;
            this.dataFine.BackColor = System.Drawing.Color.BlanchedAlmond;
            // Label selezione stato eventi
            this.labelStato = new System.Windows.Forms.Label();
            this.labelStato.Location = new System.Drawing.Point(20, 60);
            this.labelStato.Name = "labelStato";
            this.labelStato.Size = new System.Drawing.Size(200, 25);
            this.labelStato.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStato.ForeColor = System.Drawing.Color.Black;
            this.labelStato.BackColor = Form_stampa.DefaultBackColor;
            this.labelStato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStato.Text = "Filtra per stato evento:";
            // RadioButton Tutti
            this.radiobuttonTutti = new System.Windows.Forms.RadioButton();
            this.radiobuttonTutti.Location = new System.Drawing.Point(230, 65);
            this.radiobuttonTutti.Name = "radiobuttonTutti";
            this.radiobuttonTutti.Size = new System.Drawing.Size(70, 20);
            this.radiobuttonTutti.Text = "Tutti";
            this.radiobuttonTutti.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiobuttonTutti.ForeColor = System.Drawing.Color.Black;
            this.radiobuttonTutti.Checked = true;
            // RadioButton In corso
            this.radiobuttonIncorso = new System.Windows.Forms.RadioButton();
            this.radiobuttonIncorso.Location = new System.Drawing.Point(310, 65);
            this.radiobuttonIncorso.Name = "radiobuttonIncorso";
            this.radiobuttonIncorso.Size = new System.Drawing.Size(80, 20);
            this.radiobuttonIncorso.Text = "In corso";
            this.radiobuttonIncorso.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiobuttonIncorso.ForeColor = System.Drawing.Color.Black;
            // RadioButton Non iniziati
            this.radiobuttonNonInziati = new System.Windows.Forms.RadioButton();
            this.radiobuttonNonInziati.Location = new System.Drawing.Point(400, 65);
            this.radiobuttonNonInziati.Name = "radiobuttonNonInziati";
            this.radiobuttonNonInziati.Size = new System.Drawing.Size(100, 20);
            this.radiobuttonNonInziati.Text = "Non iniziati";
            this.radiobuttonNonInziati.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiobuttonNonInziati.ForeColor = System.Drawing.Color.Black;
            // RadioButton Terminati
            this.radiobuttonTerminati = new System.Windows.Forms.RadioButton();
            this.radiobuttonTerminati.Location = new System.Drawing.Point(510, 65);
            this.radiobuttonTerminati.Name = "radiobuttonTerminati";
            this.radiobuttonTerminati.Size = new System.Drawing.Size(90, 20);
            this.radiobuttonTerminati.Text = "Terminati";
            this.radiobuttonTerminati.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiobuttonTerminati.ForeColor = System.Drawing.Color.Black;
            // Button Stampa
            this.buttonStampa = new System.Windows.Forms.Button();
            this.buttonStampa.Location = new System.Drawing.Point(20, 100);
            this.buttonStampa.Name = "buttonStampa";
            this.buttonStampa.Size = new System.Drawing.Size(120, 30);
            this.buttonStampa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStampa.TabIndex = 0;
            this.buttonStampa.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonStampa.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStampa.Text = "Stampa";
            
            // Froms_stampa Controls
            this.Controls.Add(this.labelIntervallo);
            this.Controls.Add(this.dataInizio);
            this.Controls.Add(this.dataFine);
            this.Controls.Add(this.labelStato);
            this.Controls.Add(this.radiobuttonTutti);
            this.Controls.Add(this.radiobuttonIncorso);
            this.Controls.Add(this.radiobuttonNonInziati);
            this.Controls.Add(this.radiobuttonTerminati);
            this.Controls.Add(this.buttonStampa);
           
            this.ResumeLayout(false);


        }
        #endregion
        // Controlli Form_stampa
        private System.Windows.Forms.Label labelIntervallo;
        private System.Windows.Forms.DateTimePicker dataInizio;
        private System.Windows.Forms.DateTimePicker dataFine;
        private System.Windows.Forms.Label labelStato;
        private System.Windows.Forms.RadioButton radiobuttonTutti;
        private System.Windows.Forms.RadioButton radiobuttonIncorso;
        private System.Windows.Forms.RadioButton radiobuttonNonInziati;
        private System.Windows.Forms.RadioButton radiobuttonTerminati;
        private System.Windows.Forms.Button buttonStampa;
        
    }
}
