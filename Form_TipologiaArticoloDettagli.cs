namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_TipologiaArticoloDettagli : Form
{
    private int? tipologiaId;
    private readonly Tipologia_ArticoliRepository tipologiaRepository = new();

    public Form_TipologiaArticoloDettagli(int? id)
    {
        InitializeComponent();
        this.tipologiaId = id;
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        buttonSalva.Click += (s, ev) => buttonSalva_Click();
        buttonAnnulla.Click += (s, ev) => this.DialogResult = DialogResult.Cancel;

        if (tipologiaId.HasValue)
        {
            this.Text = "Modifica Tipologia Articolo";
            CaricaDatiTipologia(tipologiaId.Value);
        }
        else
        {
            this.Text = "Nuova Tipologia Articolo";
            PulisciCampi();
        }
    }

    /// <summary>
    /// Carica i dati della tipologia dal repository
    /// </summary>
    private void CaricaDatiTipologia(int id)
    {
        try
        {
            var dt = tipologiaRepository.GetById(id);
            
            if (dt.Rows.Count > 0)
            {
                System.Data.DataRow row = dt.Rows[0];
                textBoxCodice.Text = row["Codice"]?.ToString() ?? "";
                textBoxDescrizione.Text = row["Descrizione"]?.ToString() ?? "";
                textBoxNote.Text = row["Note"]?.ToString() ?? "";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento della tipologia: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PulisciCampi()
    {
        textBoxCodice.Clear();
        textBoxDescrizione.Clear();
        textBoxNote.Clear();
    }

    private void buttonSalva_Click()
    {
        // Validazione
        if (string.IsNullOrWhiteSpace(textBoxCodice.Text))
        {
            MessageBox.Show("Il Codice è obbligatorio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxCodice.Focus();
            return;
        }

        try
        {
            if (tipologiaId.HasValue)
            {
                // Modifica
                ModificaTipologia();
            }
            else
            {
                // Inserimento nuovo
                InserisciTipologia();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void InserisciTipologia()
    {
        var dt = new System.Data.DataTable();
        dt.Columns.Add("Codice", typeof(string));
        dt.Columns.Add("Descrizione", typeof(string));
        dt.Columns.Add("Note", typeof(string));

        var row = dt.NewRow();
        row["Codice"] = textBoxCodice.Text;
        row["Descrizione"] = textBoxDescrizione.Text;
        row["Note"] = textBoxNote.Text;
        dt.Rows.Add(row);

        tipologiaRepository.Add(dt.Rows[0]);
        MessageBox.Show("Tipologia aggiunta con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ModificaTipologia()
    {
        var dt = new System.Data.DataTable();
        dt.Columns.Add("ID", typeof(int));
        dt.Columns.Add("Codice", typeof(string));
        dt.Columns.Add("Descrizione", typeof(string));
        dt.Columns.Add("Note", typeof(string));

        var row = dt.NewRow();
        if (tipologiaId.HasValue)
        {
            row["ID"] = tipologiaId.Value;
        }
        row["Codice"] = textBoxCodice.Text;
        row["Descrizione"] = textBoxDescrizione.Text;
        row["Note"] = textBoxNote.Text;
        dt.Rows.Add(row);

        tipologiaRepository.Update(dt.Rows[0]);
        MessageBox.Show("Tipologia modificata con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
