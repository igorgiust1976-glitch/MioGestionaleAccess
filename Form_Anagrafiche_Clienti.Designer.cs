namespace MioGestionaleAccess
{
    public partial class Form_Anagrafiche_Clienti
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
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewClienti.TabIndex = 0;
            this.dataGridViewClienti.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewClienti.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewClienti.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dataGridViewClienti.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.dataGridViewClienti.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.dataGridViewClienti.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridViewClienti.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Button Aggiungi
            this.buttonAggiungi.Location = new System.Drawing.Point(12, 370);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(100, 30);
            this.buttonAggiungi.TabIndex = 1;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAggiungi.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAggiungi.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggiungi.UseVisualStyleBackColor = false;

            // Button Modifica
            this.buttonModifica.Location = new System.Drawing.Point(120, 370);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(100, 30);
            this.buttonModifica.TabIndex = 2;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonModifica.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonModifica.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifica.UseVisualStyleBackColor = false;

            // Button Elimina
            this.buttonElimina.Location = new System.Drawing.Point(228, 370);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(100, 30);
            this.buttonElimina.TabIndex = 3;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonElimina.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonElimina.BackColor = System.Drawing.Color.FromArgb(200, 70, 70);
            this.buttonElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimina.UseVisualStyleBackColor = false;

            // Button Annulla
            this.buttonAnnulla.Location = new System.Drawing.Point(672, 370);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(100, 30);
            this.buttonAnnulla.TabIndex = 4;
            this.buttonAnnulla.Text = "Chiudi";
            this.buttonAnnulla.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAnnulla.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAnnulla.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.buttonAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulla.UseVisualStyleBackColor = false;

            // Form_Anagrafiche_Clienti
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAnnulla);
            this.Name = "Form_Anagrafiche_Clienti";
            this.Text = "Gestione Clienti";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonAnnulla;
    }
}
