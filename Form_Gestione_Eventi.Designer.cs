namespace MioGestionaleAccess
{
    partial class Form_Gestione_Eventi
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
            // Form_Gestione_Eventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.Name = "Form2";
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            // 
            // buttonCarica
            // 
            this.buttonCarica = new System.Windows.Forms.Button();
            this.buttonCarica.Location = new System.Drawing.Point(12, 12);
            this.buttonCarica.Name = "buttonCarica";
            this.buttonCarica.Size = new System.Drawing.Size(120, 30);
            this.buttonCarica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCarica.TabIndex = 0;
            this.buttonCarica.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonCarica.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.buttonCarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarica.Text = "Carica Eventi";
            this.Controls.Add(this.buttonCarica);
            // 
            // buttonSalva
            // 
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonSalva.Location = new System.Drawing.Point(140, 12);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(120, 30);
            this.buttonSalva.TabIndex = 0;
            this.buttonSalva.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Text = "Salva Eventi";
            this.Controls.Add(this.buttonSalva);
            // 
            // buttonNuovo
            // 
            this.buttonNuovo = new System.Windows.Forms.Button();
            this.buttonNuovo.Location = new System.Drawing.Point(268, 12);
            this.buttonNuovo.Name = "buttonNuovo";
            this.buttonNuovo.Size = new System.Drawing.Size(120, 30);
            this.buttonNuovo.TabIndex = 1;
            this.buttonNuovo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNuovo.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonNuovo.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.buttonNuovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuovo.Text = "Nuovo Evento";
            this.Controls.Add(this.buttonNuovo);
            // 
            // dataGridViewEventi
            // 
            this.dataGridViewEventi = new System.Windows.Forms.DataGridView();
            this.dataGridViewEventi.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewEventi.Name = "dataGridViewEventi_Riga";
            this.dataGridViewEventi.Size = new System.Drawing.Size(760, 220);
            this.dataGridViewEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEventi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEventi.TabIndex = 3;
            this.dataGridViewEventi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewEventi.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewEventi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewEventi.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dataGridViewEventi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dataGridViewEventi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewEventi.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewEventi.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            //this.dataGridViewEventi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom))));
            this.Controls.Add(this.dataGridViewEventi);
            // 
            // dataGridViewEventi_Riga
            // 
            this.dataGridViewEventi_Riga = new System.Windows.Forms.DataGridView();
            this.dataGridViewEventi_Riga.Location = new System.Drawing.Point(770, 50);
            this.dataGridViewEventi_Riga.Name = "dataGridViewEventi_Riga";
            this.dataGridViewEventi_Riga.Size = new System.Drawing.Size(776, 450);
            this.dataGridViewEventi_Riga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEventi_Riga.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEventi_Riga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewEventi_Riga.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewEventi_Riga.TabIndex = 3;
            this.dataGridViewEventi_Riga.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewEventi_Riga.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dataGridViewEventi_Riga.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dataGridViewEventi_Riga.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewEventi_Riga.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewEventi_Riga.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            //this.dataGridViewEventi_Riga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom))));
            this.Controls.Add(this.dataGridViewEventi_Riga);
            //
            // monthCalendar
            //
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4; // Assicurati che il TabIndex sia unico
            this.monthCalendar.Visible = false; // Nascondilo all'avvio
            this.Controls.Add(this.monthCalendar);            // 
            // buttonChiudi
            // 
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.buttonChiudi.Location = new System.Drawing.Point(396, 12);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(120, 30);
            this.buttonChiudi.TabIndex = 0;
            this.buttonChiudi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonChiudi.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.buttonChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiudi.Text = "Chiudi";
            this.Controls.Add(this.buttonChiudi);            // 
            // Form controls collection
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.buttonCarica,
                this.buttonSalva,
                this.buttonNuovo,
                this.buttonChiudi,
                this.dataGridViewEventi,
                this.dataGridViewEventi_Riga,
                this.monthCalendar
            });
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Button buttonCarica;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonNuovo;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.DataGridView dataGridViewEventi;
        private System.Windows.Forms.DataGridView dataGridViewEventi_Riga;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}
