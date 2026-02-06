namespace MioGestionaleAccess
{
    partial class Form_Anagrafiche_Tipologie
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
            // Form_Anagrafiche_Tipologie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.Name = "Form_Anagrafiche_Tipologie";
            this.Text = "Gestione Tipologie Articoli";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonAggiungi.Location = new System.Drawing.Point(12, 12);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(100, 30);
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
            this.buttonModifica.Size = new System.Drawing.Size(100, 30);
            this.buttonModifica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifica.TabIndex = 0;
            this.buttonModifica.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonModifica.BackColor = System.Drawing.Color.FromArgb(151, 151, 51);
            this.buttonModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifica.Text = "Modifica";
            this.Controls.Add(this.buttonModifica);
            
            // 
            // buttonElimina
            // 
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonElimina.Location = new System.Drawing.Point(224, 12);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(100, 30);
            this.buttonElimina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElimina.TabIndex = 0;
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
            this.buttonChiudi.Size = new System.Drawing.Size(100, 30);
            this.buttonChiudi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChiudi.TabIndex = 0;
            this.buttonChiudi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonChiudi.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.buttonChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiudi.Text = "Chiudi";
            this.Controls.Add(this.buttonChiudi);
            
            // 
            // dataGridViewTipologie
            // 
            this.dataGridViewTipologie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTipologie.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewTipologie.Name = "dataGridViewTipologie";
            this.dataGridViewTipologie.Size = new System.Drawing.Size(876, 438);
            this.dataGridViewTipologie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTipologie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTipologie.TabIndex = 1;
            this.dataGridViewTipologie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewTipologie.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewTipologie.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewTipologie.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dataGridViewTipologie.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dataGridViewTipologie.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewTipologie.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewTipologie.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewTipologie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.dataGridViewTipologie);
            
            // 
            // Form controls collection
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.buttonAggiungi,
                this.buttonModifica,
                this.buttonElimina,
                this.buttonChiudi,
                this.dataGridViewTipologie
            });
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.DataGridView dataGridViewTipologie;
    }
}
