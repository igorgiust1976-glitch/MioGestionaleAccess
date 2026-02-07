namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_ArticoliDettagli : Form
{
    private int? idArticolo;
    private readonly ArticoliRepository articoliRepository = new();
    private readonly Tipologia_ArticoliRepository tipologiaArticoliRepository = new();
    private readonly FornitorIRepository fornitoriRepository = new();

    public Form_ArticoliDettagli(int? id)
    {
        InitializeComponent();
        idArticolo = id;
        Load += new EventHandler(Form_ArticoliDettagli_Load);
    }

    private void Form_ArticoliDettagli_Load(object? sender, EventArgs e)
    {
        Text = idArticolo == null ? "Nuovo Articolo" : "Modifica Articolo";
        
        // Wire dei click dei bottoni
        buttonSalva.Click += (s, ev) => buttonSalva_Click();
        buttonAnnulla.Click += (s, ev) => buttonAnnulla_Click();
        buttonAggiungiFornitore.Click += (s, ev) => buttonAggiungiFornitore_Click();
        buttonAggiungiTipologiaArticoli.Click += (s, ev) => buttonAggiungiTipologiaArticoli_Click();

        // Carica i dati dai combobox
        CaricaTipologiaArticoli();
        CaricaFornitori();

        // Se è modifica, carica i dati dell'articolo
        if (idArticolo != null)
        {
            CaricaDatiArticolo();
        }
    }

    private void buttonAggiungiTipologiaArticoli_Click()
    {
        Form_TipologieDettagli formDettagli = new(null);
        formDettagli.ShowDialog(this);
        // Ricarica le tipologie dopo aver chiuso il form dei dettagli
        CaricaTipologiaArticoli();
    }

    private void buttonAggiungiFornitore_Click()
    {
        Form_FornitoreDettagli formDettagli = new(null);
        formDettagli.ShowDialog(this);
        // Ricarica i fornitori dopo aver chiuso il form dei dettagli        CaricaFornitori();
        CaricaFornitori();
    }

    private void CaricaTipologiaArticoli()
    {
        try
        {
            DataTable dt = tipologiaArticoliRepository.GetAll();
            comboBoxTipologia.DataSource = dt;
            comboBoxTipologia.DisplayMember = "Descrizione";
            comboBoxTipologia.ValueMember = "ID";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento tipologie: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
private void CaricaFornitori()
    {
        try
        {
            DataTable dt = fornitoriRepository.GetAll();
            comboBoxFornitore.DataSource = dt;
            comboBoxFornitore.DisplayMember = "Rag_Soc";
            comboBoxFornitore.ValueMember = "ID";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento tipologie: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void CaricaDatiArticolo()
    {
        try
        {
            if (idArticolo.HasValue)
            {
                var dt = articoliRepository.GetById(idArticolo.Value);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    textBoxCodice.Text = row["Codice_interno"]?.ToString() ?? "";
                    textBoxDescrizione.Text = row["Articoli.Descrizione"]?.ToString() ?? "";
                    textBoxGiacenza.Text = row["Giacenza"]?.ToString() ?? "0";
                    textBoxNote.Text = row["Note"]?.ToString() ?? "";
                    
                    if (row["ID_Tipologia"] != DBNull.Value)
                        comboBoxTipologia.SelectedValue = Convert.ToInt32(row["ID_Tipologia"]);
                    if (row["ID_Fornitore"] != DBNull.Value)
                        comboBoxFornitore.SelectedValue = Convert.ToInt32(row["ID_Fornitore"]);
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
        if (string.IsNullOrWhiteSpace(textBoxCodice.Text))
        {
            MessageBox.Show("Codice Interno è obbligatorio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(textBoxDescrizione.Text))
        {
            MessageBox.Show("Descrizione è obbligatoria.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!decimal.TryParse(textBoxGiacenza.Text, out _))
        {
            MessageBox.Show("Giacenza deve essere un numero valido.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dt.Columns.Add("Codice_interno", typeof(string));
            dt.Columns.Add("Descrizione", typeof(string));
            dt.Columns.Add("Giacenza", typeof(decimal));
            dt.Columns.Add("ID_Fornitore", typeof(object));
            dt.Columns.Add("ID_Tipologia", typeof(object));
            dt.Columns.Add("Note", typeof(string));

            var row = dt.NewRow();
            if (idArticolo.HasValue)
                row["ID"] = idArticolo.Value;
            row["Codice_interno"] = textBoxCodice.Text;
            row["Descrizione"] = textBoxDescrizione.Text;
            row["Giacenza"] = decimal.Parse(textBoxGiacenza.Text);
            row["ID_Fornitore"] = comboBoxFornitore.SelectedValue ?? DBNull.Value;
            row["ID_Tipologia"] = comboBoxTipologia.SelectedValue ?? DBNull.Value;
            row["Note"] = textBoxNote.Text;
            dt.Rows.Add(row);

            if (idArticolo == null)
                articoliRepository.Add(dt.Rows[0]);
            else
                articoliRepository.Update(dt.Rows[0]);

            MessageBox.Show("Articolo salvato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
