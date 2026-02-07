namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Anagrafiche_Articoli : Form
{
    private readonly ArticoliRepository articoliRepository = new();

    public Form_Anagrafiche_Articoli()
    {
        InitializeComponent();
        Load += new EventHandler(Form_Anagrafiche_Articoli_Load);
    }

    private void Form_Anagrafiche_Articoli_Load(object? sender, EventArgs e)
    {
        Text = "Gestione Articoli";
        
        // Wire dei click dei bottoni
        buttonAggiungi.Click += (s, ev) => buttonAggiungi_Click();
        buttonModifica.Click += (s, ev) => buttonModifica_Click();
        buttonElimina.Click += (s, ev) => buttonElimina_Click();
        buttonChiudi.Click += (s, ev) => buttonChiudi_Click();

        // Carica automaticamente gli articoli al load
        CaricaArticoli();
    }

    private void CaricaArticoli()
    {
        try
        {
            DataTable dt = articoliRepository.GetAll();
            dataGridViewArticoli.DataSource = dt;

            // Configurazione colonne
            if (dataGridViewArticoli.Columns.Contains("ID")) dataGridViewArticoli.Columns["ID"]!.Visible = false;
            if (dataGridViewArticoli.Columns.Contains("ID_Fornitore")) dataGridViewArticoli.Columns["ID_Fornitore"]!.Visible = false;
            if (dataGridViewArticoli.Columns.Contains("ID_Tipologia")) dataGridViewArticoli.Columns["ID_Tipologia"]!.Visible = false;   
            
            if (dataGridViewArticoli.Columns.Contains("Codice_interno")) 
                dataGridViewArticoli.Columns["Codice_interno"]!.HeaderText = "Codice";
            dataGridViewArticoli.Columns["Codice_interno"]!.DisplayIndex = 0;
            if (dataGridViewArticoli.Columns.Contains("Articoli.Descrizione")) 
                dataGridViewArticoli.Columns["Articoli.Descrizione"]!.HeaderText = "Descrizione";
            dataGridViewArticoli.Columns["Articoli.Descrizione"]!.DisplayIndex = 1;
            if (dataGridViewArticoli.Columns.Contains("Giacenza")) 
                dataGridViewArticoli.Columns["Giacenza"]!.HeaderText = "Giacenza";
            dataGridViewArticoli.Columns["Giacenza"]!.DisplayIndex = 2;
            if (dataGridViewArticoli.Columns.Contains("Rag_Soc")) 
                dataGridViewArticoli.Columns["Rag_Soc"]!.HeaderText = "Fornitore";
            dataGridViewArticoli.Columns["Rag_Soc"]!.DisplayIndex = 3;
            if (dataGridViewArticoli.Columns.Contains("Tipologia_Articoli.Descrizione") ) 
                dataGridViewArticoli.Columns["Tipologia_Articoli.Descrizione"]!.HeaderText = "Tipologia";
            dataGridViewArticoli.Columns["Tipologia_Articoli.Descrizione"]!.DisplayIndex = 4;

            dataGridViewArticoli.AutoResizeColumns();
            dataGridViewArticoli.AutoResizeRows();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento articoli: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAggiungi_Click()
    {
        Form_ArticoliDettagli formDettagli = new(null);
        if (formDettagli.ShowDialog(this) == DialogResult.OK)
        {
            CaricaArticoli();
        }
    }

    private void buttonModifica_Click()
    {
        if (dataGridViewArticoli.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleziona un articolo da modificare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int id = Convert.ToInt32(dataGridViewArticoli.SelectedRows[0].Cells["ID"].Value);
        Form_ArticoliDettagli formDettagli = new(id);
        if (formDettagli.ShowDialog(this) == DialogResult.OK)
        {
            CaricaArticoli();
        }
    }

    private void buttonElimina_Click()
    {
        if (dataGridViewArticoli.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleziona un articolo da eliminare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show("Sei sicuro di voler eliminare questo articolo?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        try
        {
            int id = Convert.ToInt32(dataGridViewArticoli.SelectedRows[0].Cells["ID"].Value);
            articoliRepository.Delete(id);
            MessageBox.Show("Articolo eliminato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaArticoli();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'eliminazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonChiudi_Click()
    {
        this.Close();
    }
}
