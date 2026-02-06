namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Anagrafiche_Clienti : Form
{
    private System.Data.DataTable? dtClienti;
    private readonly ClientiRepository clientiRepository = new();

    public Form_Anagrafiche_Clienti()
    {
        InitializeComponent();
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        ConfiguraDataGridView();
        CaricaClienti();

        // Wire events
        buttonAggiungi.Click += (s, ev) => buttonAggiungi_Click();
        buttonModifica.Click += (s, ev) => buttonModifica_Click();
        buttonElimina.Click += (s, ev) => buttonElimina_Click();
        buttonAnnulla.Click += (s, ev) => this.Close();
    }

    private void ConfiguraDataGridView()
    {
        dataGridViewClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewClienti.MultiSelect = false;
        dataGridViewClienti.ReadOnly = true;
        dataGridViewClienti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    /// <summary>
    /// Carica tutti i clienti dal repository
    /// </summary>
    private void CaricaClienti()
    {
        try
        {
            dtClienti = clientiRepository.GetAll();
            dataGridViewClienti.DataSource = dtClienti;

            // Nascondi la colonna ID
            if (dataGridViewClienti.Columns["ID"] != null)
            {
                dataGridViewClienti.Columns["ID"]!.Visible = false;
            }

            // Configura i header
            var colonne = dtClienti?.Columns;
            if (colonne != null)
            {
                foreach (System.Data.DataColumn col in colonne)
                {
                    if (dataGridViewClienti.Columns[col.ColumnName] != null)
                    {
                        dataGridViewClienti.Columns[col.ColumnName]!.HeaderText = col.ColumnName switch
                        {
                            "ID" => "ID",
                            "Rag_Soc" => "Ragione Sociale",
                            "Cognome" => "Cognome",
                            "Nome" => "Nome",
                            "Indirizzo" => "Indirizzo",
                            "CAP" => "CAP",
                            "Città" => "Città",
                            "Provincia" => "Provincia",
                            "Telefono" => "Telefono",
                            "Email" => "Email",
                            _ => col.ColumnName
                        };
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento dei clienti: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAggiungi_Click()
    {
        using (Form_ClienteDettagli formDettagli = new Form_ClienteDettagli(null))
        {
            if (formDettagli.ShowDialog(this) == DialogResult.OK)
            {
                CaricaClienti();
            }
        }
    }

    private void buttonModifica_Click()
    {
        if (dataGridViewClienti.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare un cliente da modificare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewClienti.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int clienteId)
        {
            using (Form_ClienteDettagli formDettagli = new Form_ClienteDettagli(clienteId))
            {
                if (formDettagli.ShowDialog(this) == DialogResult.OK)
                {
                    CaricaClienti();
                }
            }
        }
    }

    private void buttonElimina_Click()
    {
        if (dataGridViewClienti.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare un cliente da eliminare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewClienti.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int clienteId)
        {
            string ragioneSociale = selectedRow.Cells["Rag_Soc"]?.Value?.ToString() ?? "Sconosciuto";

            DialogResult result = MessageBox.Show(
                $"Sei sicuro di voler eliminare il cliente:\n\n{ragioneSociale}?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EliminaCliente(clienteId);
            }
        }
    }

    private void EliminaCliente(int clienteId)
    {
        try
        {
            clientiRepository.Delete(clienteId);
            MessageBox.Show("Cliente eliminato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaClienti();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'eliminazione del cliente: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
