namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Anagrafiche_Tipologie : Form
{
    private readonly TipologieRepository tipologieRepository = new();

    public Form_Anagrafiche_Tipologie()
    {
        InitializeComponent();
        Load += new EventHandler(Form_Anagrafiche_Tipologie_Load);
    }

    private void Form_Anagrafiche_Tipologie_Load(object? sender, EventArgs e)
    {
        Text = "Gestione Tipologie Articoli";
        
        // Wire dei click dei bottoni
        buttonAggiungi.Click += (s, ev) => buttonAggiungi_Click();
        buttonModifica.Click += (s, ev) => buttonModifica_Click();
        buttonElimina.Click += (s, ev) => buttonElimina_Click();
        buttonChiudi.Click += (s, ev) => buttonChiudi_Click();

        // Carica automaticamente le tipologie al load
        CaricaTipologie();
    }

    private void CaricaTipologie()
    {
        try
        {
            DataTable dt = tipologieRepository.GetAll();
            dataGridViewTipologie.DataSource = dt;

            // Configurazione colonne
            if (dataGridViewTipologie.Columns.Contains("ID")) dataGridViewTipologie.Columns["ID"]!.Visible = false;
            
            if (dataGridViewTipologie.Columns.Contains("Descrizione")) 
                dataGridViewTipologie.Columns["Descrizione"]!.HeaderText = "Descrizione";
            if (dataGridViewTipologie.Columns.Contains("Note")) 
                dataGridViewTipologie.Columns["Note"]!.HeaderText = "Note";
                
            dataGridViewTipologie.AutoResizeColumns();
            dataGridViewTipologie.AutoResizeRows();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento tipologie: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAggiungi_Click()
    {
        Form_TipologieDettagli formDettagli = new(null);
        if (formDettagli.ShowDialog(this) == DialogResult.OK)
        {
            CaricaTipologie();
        }
    }

    private void buttonModifica_Click()
    {
        if (dataGridViewTipologie.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleziona una tipologia da modificare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int id = Convert.ToInt32(dataGridViewTipologie.SelectedRows[0].Cells["ID"].Value);
        Form_TipologieDettagli formDettagli = new(id);
        if (formDettagli.ShowDialog(this) == DialogResult.OK)
        {
            CaricaTipologie();
        }
    }

    private void buttonElimina_Click()
    {
        if (dataGridViewTipologie.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleziona una tipologia da eliminare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show("Sei sicuro di voler eliminare questa tipologia?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;

        try
        {
            int id = Convert.ToInt32(dataGridViewTipologie.SelectedRows[0].Cells["ID"].Value);
            tipologieRepository.Delete(id);
            MessageBox.Show("Tipologia eliminata con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaTipologie();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'eliminazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonChiudi_Click()
    {
        Close();
    }
}
