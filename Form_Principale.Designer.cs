namespace MioGestionaleAccess
{
    partial class Form_Principale
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
            // Form_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.Name = "MainForm";
            this.Text = "Gestionale Sagre";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            // 
            // Button_Eventi
            // 
            this.button_Eventi = new System.Windows.Forms.Button();
            this.button_Eventi.Location = new System.Drawing.Point(15, 15);
            this.button_Eventi.Name = "button_Eventi";
            this.button_Eventi.Size = new System.Drawing.Size(130, 25);
            this.button_Eventi.TabIndex = 0;
            this.button_Eventi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Eventi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Eventi.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.button_Eventi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Eventi.Text = "Gestione Eventi";
            this.Controls.Add(this.button_Eventi);
            // 
            // button_Sagre
            // 
            this.button_Sagre = new System.Windows.Forms.Button();
            this.button_Sagre.Location = new System.Drawing.Point(150, 15);
            this.button_Sagre.Name = "button_Sagre";
            this.button_Sagre.Size = new System.Drawing.Size(130, 25);
            this.button_Sagre.TabIndex = 0;
            this.button_Sagre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Sagre.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Sagre.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.button_Sagre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sagre.Text = "Gestione Sagre";
            this.Controls.Add(this.button_Sagre);
            //
            // button_Stampa
            // 
            this.button_Stampa = new System.Windows.Forms.Button();
            this.button_Stampa.Location = new System.Drawing.Point(285, 15);
            this.button_Stampa.Name = "button_Stampa";
            this.button_Stampa.Size = new System.Drawing.Size(130, 25);
            this.button_Stampa.TabIndex = 0;
            this.button_Stampa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Stampa.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Stampa.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.button_Stampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stampa.Text = "Stampa Eventi";
            this.Controls.Add(this.button_Stampa);
            //
            // button_Chiudi
            // 
            this.button_Chiudi = new System.Windows.Forms.Button();
            this.button_Chiudi.Location = new System.Drawing.Point(420, 15);
            this.button_Chiudi.Name = "button_Chiudi";
            this.button_Chiudi.Size = new System.Drawing.Size(130, 25);
            this.button_Chiudi.TabIndex = 0;
            this.button_Chiudi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Chiudi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Chiudi.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.button_Chiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Chiudi.Text = "Chiudi";
            this.Controls.Add(this.button_Chiudi);
            //
            // groupBox_Anagrafiche
            // 
            this.groupBox_Anagrafiche = new System.Windows.Forms.GroupBox();
            this.groupBox_Anagrafiche.Location = new System.Drawing.Point(15, 45);
            this.groupBox_Anagrafiche.Name = "groupBox_Anagrafiche";
            this.groupBox_Anagrafiche.Size = new System.Drawing.Size(770, 55);
            this.groupBox_Anagrafiche.TabIndex = 1;
            this.groupBox_Anagrafiche.TabStop = false;
            this.groupBox_Anagrafiche.Text = "Anagrafiche";
            this.groupBox_Anagrafiche.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.groupBox_Anagrafiche.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Controls.Add(this.groupBox_Anagrafiche);
            //
            // button_Anagrafiche clienti
            // 
            this.button_Anagrafiche = new System.Windows.Forms.Button();
            this.button_Anagrafiche.Location = new System.Drawing.Point(25, 18);
            this.button_Anagrafiche.Name = "button_Anagrafiche";
            this.button_Anagrafiche.Size = new System.Drawing.Size(130, 25);
            this.button_Anagrafiche.TabIndex = 0;
            this.button_Anagrafiche.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Anagrafiche.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Anagrafiche.BackColor = System.Drawing.Color.FromArgb(151, 151, 51);
            this.button_Anagrafiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Anagrafiche.Text = "Anagrafiche Clienti";
            this.groupBox_Anagrafiche.Controls.Add(this.button_Anagrafiche);
            //
            // button_Anagrafiche articoli
            // 
            this.button_Articoli = new System.Windows.Forms.Button();
            this.button_Articoli.Location = new System.Drawing.Point(165, 18);
            this.button_Articoli.Name = "button_Articoli";
            this.button_Articoli.Size = new System.Drawing.Size(130, 25);
            this.button_Articoli.TabIndex = 0;
            this.button_Articoli.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Articoli.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Articoli.BackColor = System.Drawing.Color.FromArgb(51, 151, 151);
            this.button_Articoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Articoli.Text = "Anagrafiche Articoli";
            this.groupBox_Anagrafiche.Controls.Add(this.button_Articoli);
            //
            // button_Anagrafiche Tipologie
            // 
            this.button_Tipologie = new System.Windows.Forms.Button();
            this.button_Tipologie.Location = new System.Drawing.Point(305, 18);
            this.button_Tipologie.Name = "button_Tipologie";
            this.button_Tipologie.Size = new System.Drawing.Size(130, 25);
            this.button_Tipologie.TabIndex = 0;
            this.button_Tipologie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Tipologie.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button_Tipologie.BackColor = System.Drawing.Color.FromArgb(205, 132, 143);
            this.button_Tipologie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tipologie.Text = "Anagrafiche Tipologie";
            this.groupBox_Anagrafiche.Controls.Add(this.button_Tipologie);
            //
            // datagridview1
            // 
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.datagridview1.Location = new System.Drawing.Point(15, 115);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.Size = new System.Drawing.Size(770, 485);
            this.datagridview1.TabIndex = 0;
            this.datagridview1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datagridview1.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.datagridview1.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.datagridview1.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.datagridview1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.datagridview1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.datagridview1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.datagridview1.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Controls.Add(this.datagridview1);
            // 
            // Form controls collection
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.button_Eventi,
                this.button_Sagre,
                this.button_Stampa,
                this.button_Chiudi,
                this.groupBox_Anagrafiche,
                this.datagridview1
            });
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Button button_Eventi;
        private System.Windows.Forms.Button button_Sagre;
        private System.Windows.Forms.Button button_Stampa;
        private System.Windows.Forms.Button button_Chiudi;
        private System.Windows.Forms.GroupBox groupBox_Anagrafiche;
        private System.Windows.Forms.Button button_Anagrafiche;
        private System.Windows.Forms.Button button_Articoli;
        private System.Windows.Forms.Button button_Tipologie;
        private System.Windows.Forms.DataGridView datagridview1;
    }
}