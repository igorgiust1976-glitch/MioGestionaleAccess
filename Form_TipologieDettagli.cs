namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_TipologieDettagli : Form
{
    private int? idTipologia;
    private readonly TipologieRepository tipologieRepository = new();

    public Form_TipologieDettagli(int? id)
    {
        InitializeComponent();
        idTipologia = id;
        Load += new EventHandler(Form_TipologieDettagli_Load);
    }

    private void Form_TipologieDettagli_Load(object? sender, EventArgs e)
    {
        Text = idTipologia == null ? "Nuovo Tipologia" : "Modifica Tipologia";
        
        // Wire dei click dei bottoni
        buttonSalva.Click += (s, ev) => buttonSalva_Click();
        buttonAnnulla.Click += (s, ev) => buttonAnnulla_Click();
        
        // Se è modifica, carica i dati della tipologia
        if (idTipologia != null)
        {
            CaricaDatiTipologia();
        }
    }

    private void CaricaDatiTipologia()
    {
        try
        {
            if (idTipologia.HasValue)
            {
                var dt = tipologieRepository.GetById(idTipologia.Value);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    textBoxDescrizione.Text = row["Descrizione"]?.ToString() ?? "";
                    textBoxNote.Text = row["Note"]?.ToString() ?? "";
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidaForm()
    {
        if (string.IsNullOrWhiteSpace(textBoxDescrizione.Text))
        {
            MessageBox.Show("Descrizione obbligatoria.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void buttonSalva_Click()
    {
        if (!ValidaForm())
            return;

        try
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descrizione", typeof(string));
            dt.Columns.Add("Note", typeof(string));

            var row = dt.NewRow();
            if (idTipologia.HasValue)
                row["ID"] = idTipologia.Value;
            row["Descrizione"] = textBoxDescrizione.Text;
            row["Note"] = textBoxNote.Text;
            dt.Rows.Add(row);

            if (idTipologia == null)
                tipologieRepository.Add(dt.Rows[0]);
            else
                tipologieRepository.Update(dt.Rows[0]);

            MessageBox.Show("Tipologia salvata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAnnulla_Click()
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
