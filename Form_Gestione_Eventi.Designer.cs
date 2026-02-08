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
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Name = "Form_Gestione_Eventi";
            
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonAggiungi.Location = new System.Drawing.Point(12, 12);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(100, 25);
            this.buttonAggiungi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAggiungi.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggiungi.Text = "Aggiungi";
            this.Controls.Add(this.buttonAggiungi);
            
            // 
            // buttonModifica
            // 
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonModifica.Location = new System.Drawing.Point(118, 12);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(100, 25);
            this.buttonModifica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifica.TabIndex = 1;
            this.buttonModifica.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonModifica.BackColor = System.Drawing.Color.FromArgb(200, 150, 51);
            this.buttonModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifica.Text = "Modifica";
            this.Controls.Add(this.buttonModifica);
            
            // 
            // buttonElimina
            // 
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonElimina.Location = new System.Drawing.Point(224, 12);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(100, 25);
            this.buttonElimina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElimina.TabIndex = 2;
            this.buttonElimina.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonElimina.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.buttonElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimina.Text = "Elimina";
            this.Controls.Add(this.buttonElimina);
            
            // 
            // buttonChiudi
            // 
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.buttonChiudi.Location = new System.Drawing.Point(330, 12);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(100, 25);
            this.buttonChiudi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChiudi.TabIndex = 3;
            this.buttonChiudi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonChiudi.BackColor = System.Drawing.Color.FromArgb(151, 51, 51);
            this.buttonChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiudi.Text = "Chiudi";
            this.Controls.Add(this.buttonChiudi);
            
            // 
            // dataGridViewEventi
            // 
            this.dataGridViewEventi = new System.Windows.Forms.DataGridView();
            this.dataGridViewEventi.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewEventi.Name = "dataGridViewEventi";
            this.dataGridViewEventi.Size = new System.Drawing.Size(780, 470);
            this.dataGridViewEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEventi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEventi.TabIndex = 4;
            this.dataGridViewEventi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewEventi.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewEventi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewEventi.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dataGridViewEventi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dataGridViewEventi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewEventi.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewEventi.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.Controls.Add(this.dataGridViewEventi);
            
            // 
            // Form controls collection
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.buttonAggiungi,
                this.buttonModifica,
                this.buttonElimina,
                this.buttonChiudi,
                this.dataGridViewEventi
            });
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.DataGridView dataGridViewEventi;
    }
}
