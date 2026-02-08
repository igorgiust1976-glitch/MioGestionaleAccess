namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Gestione_Eventi : Form
{
    private readonly EventiRepository eventiRepository = new();
    private DataTable? datiEventi;

    public Form_Gestione_Eventi()
    {
        InitializeComponent();
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        Text = "Gestione Eventi";
        
        ConfiguraDataGridView();
        CaricaEventi();

        // Wire degli eventi
        buttonAggiungi.Click += (s, ev) => buttonAggiungi_Click();
        buttonModifica.Click += (s, ev) => buttonModifica_Click();
        buttonElimina.Click += (s, ev) => buttonElimina_Click();
        buttonChiudi.Click += (s, ev) => buttonChiudi_Click();
        dataGridViewEventi.ColumnHeaderMouseClick += (s, ev) => Form_Principale.EvidenziaDatePassate(dataGridViewEventi);
    }

    private void ConfiguraDataGridView()
    {
        dataGridViewEventi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewEventi.MultiSelect = false;
        dataGridViewEventi.ReadOnly = true;
        dataGridViewEventi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    /// <summary>
    /// Carica tutti gli eventi dal repository
    /// </summary>
    /// <summary>
    /// Carica tutti gli eventi dal repository
    /// </summary>
    private void CaricaEventi()
    {
        try
        {
            datiEventi = eventiRepository.GetAll();
            dataGridViewEventi.DataSource = datiEventi;

            // Nascondi colonne non necessarie
            if (dataGridViewEventi.Columns.Contains("ID")) 
                dataGridViewEventi.Columns["ID"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("ID_Tipologia_noleggi")) 
                dataGridViewEventi.Columns["ID_Tipologia_noleggi"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("ID_evento_riga")) 
                dataGridViewEventi.Columns["ID_evento_riga"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("ID_Cliente")) 
                dataGridViewEventi.Columns["ID_Cliente"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("Rag_Soc")) 
                dataGridViewEventi.Columns["Rag_Soc"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("Descrizione")) 
                dataGridViewEventi.Columns["Descrizione"].Visible = false;

            // Configura i header
            if (dataGridViewEventi.Columns.Contains("Nome_Evento")) 
                dataGridViewEventi.Columns["Nome_Evento"]!.HeaderText = "Nome Evento";
            if (dataGridViewEventi.Columns.Contains("Data_inizio")) 
                dataGridViewEventi.Columns["Data_inizio"]!.HeaderText = "Data Inizio";
            if (dataGridViewEventi.Columns.Contains("Data_fine")) 
                dataGridViewEventi.Columns["Data_fine"]!.HeaderText = "Data Fine";

            // Configura format
            if (dataGridViewEventi.Columns.Contains("Data_inizio")) 
                dataGridViewEventi.Columns["Data_inizio"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dataGridViewEventi.Columns.Contains("Data_fine")) 
                dataGridViewEventi.Columns["Data_fine"]!.DefaultCellStyle.Format = "dd/MM/yyyy";

            dataGridViewEventi.AutoResizeColumns();
            dataGridViewEventi.AutoResizeRows();
            Form_Principale.EvidenziaDatePassate(dataGridViewEventi);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento degli eventi: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAggiungi_Click()
    {
        using (Form_EventoDettagli formDettagli = new Form_EventoDettagli(null))
        {
            if (formDettagli.ShowDialog(this) == DialogResult.OK)
            {
                CaricaEventi();
            }
        }
    }

    private void buttonModifica_Click()
    {
        if (dataGridViewEventi.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare un evento da modificare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewEventi.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int eventoId)
        {
            using (Form_EventoDettagli formDettagli = new Form_EventoDettagli(eventoId))
            {
                if (formDettagli.ShowDialog(this) == DialogResult.OK)
                {
                    CaricaEventi();
                }
            }
        }
    }

    private void buttonElimina_Click()
    {
        if (dataGridViewEventi.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selezionare un evento da eliminare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataGridViewRow selectedRow = dataGridViewEventi.SelectedRows[0];
        if (selectedRow.Cells["ID"].Value is int eventoId)
        {
            string nomeEvento = selectedRow.Cells["Nome_Evento"]?.Value?.ToString() ?? "Sconosciuto";

            DialogResult result = MessageBox.Show(
                $"Sei sicuro di voler eliminare l'evento:\n\n{nomeEvento}?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EliminaEvento(eventoId);
            }
        }
    }

    private void EliminaEvento(int eventoId)
    {
        try
        {
            eventiRepository.Delete(eventoId);
            MessageBox.Show("Evento eliminato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaEventi();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'eliminazione dell'evento: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonChiudi_Click()
    {
        this.Close();
    }
}


