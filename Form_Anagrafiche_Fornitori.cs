namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Anagrafiche_Fornitori : Form
{
    private System.Data.DataTable? dtFornitori;
    private readonly FornitorIRepository fornitorIRepository = new();

    public Form_Anagrafiche_Fornitori()
    {
        InitializeComponent();
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        ConfiguraDataGridView();
        CaricaFornitori();

        // Wire events
        buttonAggiungi.Click += (s, ev) => buttonAggiungi_Click();
        buttonModifica.Click += (s, ev) => buttonModifica_Click();
        buttonElimina.Click += (s, ev) => buttonElimina_Click();
        buttonAnnulla.Click += (s, ev) => this.Close();
    }

    private void ConfiguraDataGridView()
    {
        dataGridViewFornitori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewFornitori.MultiSelect = false;
        dataGridViewFornitori.ReadOnly = true;
        dataGridViewFornitori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    /// <summary>
    /// Carica tutti i fornitori dal repository
    /// </summary>
    private void CaricaFornitori()
    {
        try
        {
            dtFornitori = fornitorIRepository.GetAll();
            dataGridViewFornitori.DataSource = dtFornitori;

            // Nascondi la colonna ID
            if (dataGridViewFornitori.Columns["ID"] != null)
            {
                dataGridViewFornitori.Columns["ID"]!.Visible = false;
            }

            // Configura i header
            var colonne = dtFornitori?.Columns;
            if (colonne != null)
            {
                foreach (System.Data.DataColumn col in colonne)
                {
                    if (dataGridViewFornitori.Columns[col.ColumnName] != null)
                    {
                        dataGridViewFornitori.Columns[col.ColumnName]!.HeaderText = col.ColumnName switch
                        {
                            "ID" => "ID",
                            "Rag_Soc" => "Ragione Sociale",
                            "Indirizzo" => "Indirizzo",
                            "Tel_1" => "Telefono 1",
                            "Tel_2" => "Telefono 2",
                            "Riferimento" => "Riferimento",
                            "Note" => "Note",
                            _ => col.ColumnName
                        };
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento dei fornitori: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAggiungi_Click()
    {
        using (Form_FornitoreDettagli formDettagli = new Form_FornitoreDettagli(null))
        {
            if (formDettagli.ShowDialog(this) == DialogResult.OK)
            {
                CaricaFornitori();
            }
        }
    }

    private void buttonModifica_Click()
    {
        if (dataGridViewFornitori.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare un fornitore da modificare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewFornitori.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int fornitoreId)
        {
            using (Form_FornitoreDettagli formDettagli = new Form_FornitoreDettagli(fornitoreId))
            {
                if (formDettagli.ShowDialog(this) == DialogResult.OK)
                {
                    CaricaFornitori();
                }
            }
        }
    }

    private void buttonElimina_Click()
    {
        if (dataGridViewFornitori.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare un fornitore da eliminare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewFornitori.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int fornitoreId)
        {
            string ragioneSociale = selectedRow.Cells["Rag_Soc"]?.Value?.ToString() ?? "Sconosciuto";

            DialogResult result = MessageBox.Show(
                $"Sei sicuro di voler eliminare il fornitore:\n\n{ragioneSociale}?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EliminaFornitore(fornitoreId);
            }
        }
    }

    private void EliminaFornitore(int fornitoreId)
    {
        try
        {
            fornitorIRepository.Delete(fornitoreId);
            MessageBox.Show("Fornitore eliminato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaFornitori();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'eliminazione del fornitore: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
