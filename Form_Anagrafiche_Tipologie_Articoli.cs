namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Anagrafiche_Tipologie_Articoli : Form
{
    private System.Data.DataTable? dtTipologie;
    private readonly Tipologia_ArticoliRepository tipologiaRepository = new();

    public Form_Anagrafiche_Tipologie_Articoli()
    {
        InitializeComponent();
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        ConfiguraDataGridView();
        CaricaTipologie();

        // Wire events
        buttonAggiungi.Click += (s, ev) => buttonAggiungi_Click();
        buttonModifica.Click += (s, ev) => buttonModifica_Click();
        buttonElimina.Click += (s, ev) => buttonElimina_Click();
        buttonAnnulla.Click += (s, ev) => this.Close();
    }

    private void ConfiguraDataGridView()
    {
        dataGridViewTipologie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewTipologie.MultiSelect = false;
        dataGridViewTipologie.ReadOnly = true;
        dataGridViewTipologie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    /// <summary>
    /// Carica tutte le tipologie di articoli dal repository
    /// </summary>
    private void CaricaTipologie()
    {
        try
        {
            dtTipologie = tipologiaRepository.GetAll();
            dataGridViewTipologie.DataSource = dtTipologie;

            // Nascondi la colonna ID
            if (dataGridViewTipologie.Columns["ID"] != null)
            {
                dataGridViewTipologie.Columns["ID"]!.Visible = false;
            }

            // Configura i header
            var colonne = dtTipologie?.Columns;
            if (colonne != null)
            {
                foreach (System.Data.DataColumn col in colonne)
                {
                    if (dataGridViewTipologie.Columns[col.ColumnName] != null)
                    {
                        dataGridViewTipologie.Columns[col.ColumnName]!.HeaderText = col.ColumnName switch
                        {
                            "ID" => "ID",
                            "Codice" => "Codice",
                            "Descrizione" => "Descrizione",
                            "Note" => "Note",
                            _ => col.ColumnName
                        };
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento delle tipologie: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAggiungi_Click()
    {
        using (Form_TipologiaArticoloDettagli formDettagli = new Form_TipologiaArticoloDettagli(null))
        {
            if (formDettagli.ShowDialog(this) == DialogResult.OK)
            {
                CaricaTipologie();
            }
        }
    }

    private void buttonModifica_Click()
    {
        if (dataGridViewTipologie.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare una tipologia da modificare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewTipologie.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int tipologiaId)
        {
            using (Form_TipologiaArticoloDettagli formDettagli = new Form_TipologiaArticoloDettagli(tipologiaId))
            {
                if (formDettagli.ShowDialog(this) == DialogResult.OK)
                {
                    CaricaTipologie();
                }
            }
        }
    }

    private void buttonElimina_Click()
    {
        if (dataGridViewTipologie.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare una tipologia da eliminare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewTipologie.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int tipologiaId)
        {
            string codice = selectedRow.Cells["Codice"]?.Value?.ToString() ?? "Sconosciuto";

            DialogResult result = MessageBox.Show(
                $"Sei sicuro di voler eliminare la tipologia:\n\n{codice}?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EliminaTipologia(tipologiaId);
            }
        }
    }

    private void EliminaTipologia(int tipologiaId)
    {
        try
        {
            tipologiaRepository.Delete(tipologiaId);
            MessageBox.Show("Tipologia eliminata con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaTipologie();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'eliminazione della tipologia: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
