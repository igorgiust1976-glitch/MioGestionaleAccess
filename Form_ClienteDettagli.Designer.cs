namespace MioGestionaleAccess
{
    public partial class Form_ClienteDettagli
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
            this.labelRagioneSociale = new System.Windows.Forms.Label();
            this.textBoxRagioneSociale = new System.Windows.Forms.TextBox();
            this.labelIndirizzo = new System.Windows.Forms.Label();
            this.textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this.labelReferente = new System.Windows.Forms.Label();
            this.textBoxReferente = new System.Windows.Forms.TextBox();
            this.labelTel1 = new System.Windows.Forms.Label();
            this.textBoxTel1 = new System.Windows.Forms.TextBox();
            this.labelTel2 = new System.Windows.Forms.Label();
            this.textBoxTel2 = new System.Windows.Forms.TextBox();
            this.labelNote1 = new System.Windows.Forms.Label();
            this.textBoxNote1 = new System.Windows.Forms.TextBox();
            this.labelNote2 = new System.Windows.Forms.Label();
            this.textBoxNote2 = new System.Windows.Forms.TextBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label Ragione Sociale
            this.labelRagioneSociale.AutoSize = true;
            this.labelRagioneSociale.Location = new System.Drawing.Point(12, 15);
            this.labelRagioneSociale.Name = "labelRagioneSociale";
            this.labelRagioneSociale.Size = new System.Drawing.Size(100, 13);
            this.labelRagioneSociale.TabIndex = 0;
            this.labelRagioneSociale.Text = "Ragione Sociale *";
            this.labelRagioneSociale.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Ragione Sociale
            this.textBoxRagioneSociale.Location = new System.Drawing.Point(12, 35);
            this.textBoxRagioneSociale.Name = "textBoxRagioneSociale";
            this.textBoxRagioneSociale.Size = new System.Drawing.Size(350, 20);
            this.textBoxRagioneSociale.TabIndex = 1;
            this.textBoxRagioneSociale.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxRagioneSociale.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Indirizzo
            this.labelIndirizzo.AutoSize = true;
            this.labelIndirizzo.Location = new System.Drawing.Point(12, 65);
            this.labelIndirizzo.Name = "labelIndirizzo";
            this.labelIndirizzo.Size = new System.Drawing.Size(54, 13);
            this.labelIndirizzo.TabIndex = 2;
            this.labelIndirizzo.Text = "Indirizzo";
            this.labelIndirizzo.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Indirizzo
            this.textBoxIndirizzo.Location = new System.Drawing.Point(12, 85);
            this.textBoxIndirizzo.Name = "textBoxIndirizzo";
            this.textBoxIndirizzo.Size = new System.Drawing.Size(350, 20);
            this.textBoxIndirizzo.TabIndex = 3;
            this.textBoxIndirizzo.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxIndirizzo.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Referente
            this.labelReferente.AutoSize = true;
            this.labelReferente.Location = new System.Drawing.Point(12, 115);
            this.labelReferente.Name = "labelReferente";
            this.labelReferente.Size = new System.Drawing.Size(57, 13);
            this.labelReferente.TabIndex = 4;
            this.labelReferente.Text = "Referente";
            this.labelReferente.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Referente
            this.textBoxReferente.Location = new System.Drawing.Point(12, 135);
            this.textBoxReferente.Name = "textBoxReferente";
            this.textBoxReferente.Size = new System.Drawing.Size(350, 20);
            this.textBoxReferente.TabIndex = 5;
            this.textBoxReferente.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxReferente.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Tel_1
            this.labelTel1.AutoSize = true;
            this.labelTel1.Location = new System.Drawing.Point(12, 165);
            this.labelTel1.Name = "labelTel1";
            this.labelTel1.Size = new System.Drawing.Size(65, 13);
            this.labelTel1.TabIndex = 6;
            this.labelTel1.Text = "Telefono 1";
            this.labelTel1.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Tel_1
            this.textBoxTel1.Location = new System.Drawing.Point(12, 185);
            this.textBoxTel1.Name = "textBoxTel1";
            this.textBoxTel1.Size = new System.Drawing.Size(150, 20);
            this.textBoxTel1.TabIndex = 7;
            this.textBoxTel1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxTel1.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Tel_2
            this.labelTel2.AutoSize = true;
            this.labelTel2.Location = new System.Drawing.Point(200, 165);
            this.labelTel2.Name = "labelTel2";
            this.labelTel2.Size = new System.Drawing.Size(65, 13);
            this.labelTel2.TabIndex = 8;
            this.labelTel2.Text = "Telefono 2";
            this.labelTel2.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Tel_2
            this.textBoxTel2.Location = new System.Drawing.Point(200, 185);
            this.textBoxTel2.Name = "textBoxTel2";
            this.textBoxTel2.Size = new System.Drawing.Size(150, 20);
            this.textBoxTel2.TabIndex = 9;
            this.textBoxTel2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxTel2.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Note_1
            this.labelNote1.AutoSize = true;
            this.labelNote1.Location = new System.Drawing.Point(12, 215);
            this.labelNote1.Name = "labelNote1";
            this.labelNote1.Size = new System.Drawing.Size(49, 13);
            this.labelNote1.TabIndex = 10;
            this.labelNote1.Text = "Note 1";
            this.labelNote1.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Note_1
            this.textBoxNote1.Location = new System.Drawing.Point(12, 235);
            this.textBoxNote1.Name = "textBoxNote1";
            this.textBoxNote1.Size = new System.Drawing.Size(350, 60);
            this.textBoxNote1.TabIndex = 11;
            this.textBoxNote1.Multiline = true;
            this.textBoxNote1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote1.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxNote1.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Label Note_2
            this.labelNote2.AutoSize = true;
            this.labelNote2.Location = new System.Drawing.Point(12, 305);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Size = new System.Drawing.Size(49, 13);
            this.labelNote2.TabIndex = 12;
            this.labelNote2.Text = "Note 2";
            this.labelNote2.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // TextBox Note_2
            this.textBoxNote2.Location = new System.Drawing.Point(12, 325);
            this.textBoxNote2.Name = "textBoxNote2";
            this.textBoxNote2.Size = new System.Drawing.Size(350, 60);
            this.textBoxNote2.TabIndex = 13;
            this.textBoxNote2.Multiline = true;
            this.textBoxNote2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote2.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.textBoxNote2.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);

            // Button Salva
            this.buttonSalva.Location = new System.Drawing.Point(150, 400);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(100, 30);
            this.buttonSalva.TabIndex = 14;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonSalva.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(51, 151, 51);
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.UseVisualStyleBackColor = false;

            // Button Annulla
            this.buttonAnnulla.Location = new System.Drawing.Point(260, 400);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(100, 30);
            this.buttonAnnulla.TabIndex = 15;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonAnnulla.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.buttonAnnulla.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.buttonAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulla.UseVisualStyleBackColor = false;

            // Form_ClienteDettagli
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 445);
            this.Controls.Add(this.labelRagioneSociale);
            this.Controls.Add(this.textBoxRagioneSociale);
            this.Controls.Add(this.labelIndirizzo);
            this.Controls.Add(this.textBoxIndirizzo);
            this.Controls.Add(this.labelReferente);
            this.Controls.Add(this.textBoxReferente);
            this.Controls.Add(this.labelTel1);
            this.Controls.Add(this.textBoxTel1);
            this.Controls.Add(this.labelTel2);
            this.Controls.Add(this.textBoxTel2);
            this.Controls.Add(this.labelNote1);
            this.Controls.Add(this.textBoxNote1);
            this.Controls.Add(this.labelNote2);
            this.Controls.Add(this.textBoxNote2);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.buttonAnnulla);
            this.Name = "Form_ClienteDettagli";
            this.Text = "Dettagli Cliente";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Icon = new System.Drawing.Icon(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", "app.ico"));
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelRagioneSociale;
        private System.Windows.Forms.TextBox textBoxRagioneSociale;
        private System.Windows.Forms.Label labelIndirizzo;
        private System.Windows.Forms.TextBox textBoxIndirizzo;
        private System.Windows.Forms.Label labelReferente;
        private System.Windows.Forms.TextBox textBoxReferente;
        private System.Windows.Forms.Label labelTel1;
        private System.Windows.Forms.TextBox textBoxTel1;
        private System.Windows.Forms.Label labelTel2;
        private System.Windows.Forms.TextBox textBoxTel2;
        private System.Windows.Forms.Label labelNote1;
        private System.Windows.Forms.TextBox textBoxNote1;
        private System.Windows.Forms.Label labelNote2;
        private System.Windows.Forms.TextBox textBoxNote2;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonAnnulla;
    }
}
