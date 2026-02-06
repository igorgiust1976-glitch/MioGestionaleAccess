namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_FornitoreDettagli : Form
{
    private int? fornitoreId;
    private readonly FornitorIRepository fornitorIRepository = new();

    public Form_FornitoreDettagli(int? id)
    {
        InitializeComponent();
        this.fornitoreId = id;
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        buttonSalva.Click += (s, ev) => buttonSalva_Click();
        buttonAnnulla.Click += (s, ev) => this.DialogResult = DialogResult.Cancel;

        if (fornitoreId.HasValue)
        {
            this.Text = "Modifica Fornitore";
            CaricaDatiFornitore(fornitoreId.Value);
        }
        else
        {
            this.Text = "Nuovo Fornitore";
            PulisciCampi();
        }
    }

    /// <summary>
    /// Carica i dati del fornitore dal repository
    /// </summary>
    private void CaricaDatiFornitore(int id)
    {
        try
        {
            var dt = fornitorIRepository.GetById(id);
            
            if (dt.Rows.Count > 0)
            {
                System.Data.DataRow row = dt.Rows[0];
                textBoxRagioneSociale.Text = row["Rag_Soc"]?.ToString() ?? "";
                textBoxIndirizzo.Text = row["Indirizzo"]?.ToString() ?? "";
                textBoxTel1.Text = row["Tel_1"]?.ToString() ?? "";
                textBoxTel2.Text = row["Tel_2"]?.ToString() ?? "";
                textBoxRiferimento.Text = row["Riferimento"]?.ToString() ?? "";
                textBoxNote.Text = row["Note"]?.ToString() ?? "";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento del fornitore: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PulisciCampi()
    {
        textBoxRagioneSociale.Clear();
        textBoxIndirizzo.Clear();
        textBoxTel1.Clear();
        textBoxTel2.Clear();
        textBoxRiferimento.Clear();
        textBoxNote.Clear();
    }

    private void buttonSalva_Click()
    {
        // Validazione
        if (string.IsNullOrWhiteSpace(textBoxRagioneSociale.Text))
        {
            MessageBox.Show("La Ragione Sociale è obbligatoria.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxRagioneSociale.Focus();
            return;
        }

        try
        {
            if (fornitoreId.HasValue)
            {
                // Modifica
                ModificaFornitore();
            }
            else
            {
                // Inserimento nuovo
                InserisciFornitore();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void InserisciFornitore()
    {
        var dt = new System.Data.DataTable();
        dt.Columns.Add("Rag_Soc", typeof(string));
        dt.Columns.Add("Indirizzo", typeof(string));
        dt.Columns.Add("Tel_1", typeof(string));
        dt.Columns.Add("Tel_2", typeof(string));
        dt.Columns.Add("Riferimento", typeof(string));
        dt.Columns.Add("Note", typeof(string));

        var row = dt.NewRow();
        row["Rag_Soc"] = textBoxRagioneSociale.Text;
        row["Indirizzo"] = textBoxIndirizzo.Text;
        row["Tel_1"] = textBoxTel1.Text;
        row["Tel_2"] = textBoxTel2.Text;
        row["Riferimento"] = textBoxRiferimento.Text;
        row["Note"] = textBoxNote.Text;
        dt.Rows.Add(row);

        fornitorIRepository.Add(dt.Rows[0]);
        MessageBox.Show("Fornitore aggiunto con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ModificaFornitore()
    {
        var dt = new System.Data.DataTable();
        dt.Columns.Add("ID", typeof(int));
        dt.Columns.Add("Rag_Soc", typeof(string));
        dt.Columns.Add("Indirizzo", typeof(string));
        dt.Columns.Add("Tel_1", typeof(string));
        dt.Columns.Add("Tel_2", typeof(string));
        dt.Columns.Add("Riferimento", typeof(string));
        dt.Columns.Add("Note", typeof(string));

        var row = dt.NewRow();
        if (fornitoreId.HasValue)
        {
            row["ID"] = fornitoreId.Value;
        }
        row["Rag_Soc"] = textBoxRagioneSociale.Text;
        row["Indirizzo"] = textBoxIndirizzo.Text;
        row["Tel_1"] = textBoxTel1.Text;
        row["Tel_2"] = textBoxTel2.Text;
        row["Riferimento"] = textBoxRiferimento.Text;
        row["Note"] = textBoxNote.Text;
        dt.Rows.Add(row);

        fornitorIRepository.Update(dt.Rows[0]);
        MessageBox.Show("Fornitore modificato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
