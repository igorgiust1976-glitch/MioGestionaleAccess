namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Gestione_Eventi : Form
{
    private readonly EventiRepository eventiRepository = new();
    private readonly ClientiRepository clientiRepository = new();
    private readonly TipologieRepository tipologieRepository = new();
    
    private DataGridViewCell? activeDateCell;
    private DataTable? datiEventi;

    public Form_Gestione_Eventi()
    {
        InitializeComponent();
        Load += new EventHandler(Form_Gestione_Eventi_Load);
    }

    private void Form_Gestione_Eventi_Load(object? sender, EventArgs e)
    {
        Text = "Gestione Eventi";
        
        buttonCarica.Click += (s, ev) => CaricaEventi(true);
        buttonSalva.Click += (s, ev) => SalvaEventi();
        buttonNuovo.Click += (s, ev) => AggiungiNuovoEvento();
        buttonChiudi.Click += (s, ev) => buttonChiudi_Click();
        dataGridViewEventi.CellClick += DataGridViewEventi_CellClick;
        monthCalendar.DateSelected += MonthCalendar_DateSelected;
        monthCalendar.Leave += MonthCalendar_Leave;
        dataGridViewEventi.ColumnHeaderMouseClick += (s, ev) => Form_Principale.EvidenziaDatePassate(dataGridViewEventi);
        
        CaricaEventi(false);
    }

    private void DataGridViewEventi_CellClick(object? s, DataGridViewCellEventArgs ev)
    {
        if (ev.RowIndex < 0 || ev.ColumnIndex < 0) return;
        
        try
        {
            DataGridViewRow row = dataGridViewEventi.Rows[ev.RowIndex];
            
            if (dataGridViewEventi.Columns.Contains("ID") && row.Cells["ID"].Value != null)
            {
                if (int.TryParse(row.Cells["ID"].Value.ToString() ?? "", out int idEvento))
                {
                    var dtRighe = eventiRepository.GetEventoRighe(idEvento);
                    dataGridViewEventi_Riga.DataSource = dtRighe;
                }
            }
            
            if (ev.ColumnIndex >= 0 && ev.ColumnIndex < dataGridViewEventi.Columns.Count)
            {
                string? colName = dataGridViewEventi.Columns[ev.ColumnIndex]?.Name;
                if (colName == "Data_inizio" || colName == "Data_fine")
                {
                    activeDateCell = dataGridViewEventi.Rows[ev.RowIndex].Cells[ev.ColumnIndex];
                    var cellDisplayRect = dataGridViewEventi.GetCellDisplayRectangle(ev.ColumnIndex, ev.RowIndex, false);
                    monthCalendar.Location = new Point(cellDisplayRect.Left, cellDisplayRect.Bottom);
                    monthCalendar.SetDate(activeDateCell.Value as DateTime? ?? DateTime.Now);
                    monthCalendar.Visible = true;
                    monthCalendar.BringToFront();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante il caricamento dei dati della riga: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void MonthCalendar_DateSelected(object? sender, DateRangeEventArgs e)
    {
        if (activeDateCell != null)
        {
            activeDateCell.Value = e.Start;
            monthCalendar.Visible = false;
        }
    }

    private void MonthCalendar_Leave(object? sender, EventArgs e)
    {
        monthCalendar.Visible = false;
    }

    private void buttonChiudi_Click()
    {
        this.Close();
    }

    private bool ValidaRiga(DataGridViewRow row)
    {
        if (row.Cells["Nome_Evento"]?.Value == null || string.IsNullOrWhiteSpace(row.Cells["Nome_Evento"].Value.ToString()))
        {
            MessageBox.Show("Nome Evento è obbligatorio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        
        if (row.Cells["Data_inizio"]?.Value == null || row.Cells["Data_inizio"].Value == DBNull.Value)
        {
            MessageBox.Show("Data Inizio è obbligatoria.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        
        if (row.Cells["Data_fine"]?.Value == null || row.Cells["Data_fine"].Value == DBNull.Value)
        {
            MessageBox.Show("Data Fine è obbligatoria.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        
        if (row.Cells["ComboCliente"]?.Value == null || row.Cells["ComboCliente"].Value == DBNull.Value)
        {
            MessageBox.Show("Cliente è obbligatorio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        
        if (row.Cells["ComboTipologia"]?.Value == null || row.Cells["ComboTipologia"].Value == DBNull.Value)
        {
            MessageBox.Show("Tipo Evento è obbligatorio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        
        return true;
    }

    private void AggiungiNuovoEvento()
    {
        try
        {
            if (datiEventi == null || datiEventi.Rows.Count == 0)
            {
                MessageBox.Show("Carica prima i dati cliccando su 'Carica Eventi'.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DataRow newRow = datiEventi!.NewRow();
            newRow["Nome_Evento"] = "";
            newRow["Data_inizio"] = DateTime.Now;
            newRow["Data_fine"] = DateTime.Now;
            newRow["ID_Cliente"] = DBNull.Value;
            newRow["ID_Tipologia_noleggi"] = DBNull.Value;
            newRow["ID_evento_riga"] = DBNull.Value;
            newRow["Rag_Soc"] = "";
            newRow["Descrizione"] = "";
            
            datiEventi.Rows.Add(newRow);
            MessageBox.Show("Nuova riga aggiunta. Compila i dati e salva.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nell'aggiunta della nuova riga: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CaricaEventi(bool refresh)
    {
        try
        {
            datiEventi = eventiRepository.GetAll();
            dataGridViewEventi.DataSource = datiEventi;
            
            if (dataGridViewEventi.Columns.Contains("ID")) dataGridViewEventi.Columns["ID"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("ID_Tipologia_noleggi")) dataGridViewEventi.Columns["ID_Tipologia_noleggi"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("ID_evento_riga")) dataGridViewEventi.Columns["ID_evento_riga"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("ID_Cliente")) dataGridViewEventi.Columns["ID_Cliente"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("Rag_Soc")) dataGridViewEventi.Columns["Rag_Soc"].Visible = false;
            if (dataGridViewEventi.Columns.Contains("Descrizione")) dataGridViewEventi.Columns["Descrizione"].Visible = false;

if (dataGridViewEventi.Columns.Contains("Nome_Evento")) dataGridViewEventi.Columns["Nome_Evento"]!.HeaderText = "Nome Evento";
                if (dataGridViewEventi.Columns.Contains("Data_inizio")) dataGridViewEventi.Columns["Data_inizio"]!.HeaderText = "Data Inizio";
                if (dataGridViewEventi.Columns.Contains("Data_fine")) dataGridViewEventi.Columns["Data_fine"]!.HeaderText = "Data Fine";

                if (dataGridViewEventi.Columns.Contains("Data_inizio")) dataGridViewEventi.Columns["Data_inizio"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
                if (dataGridViewEventi.Columns.Contains("Data_fine")) dataGridViewEventi.Columns["Data_fine"]!.DefaultCellStyle.Format = "dd/MM/yyyy";

            if (!refresh)
            {
                if (!dataGridViewEventi.Columns.Contains("ComboCliente"))
                {
                    var clientiTable = clientiRepository.GetAll();
                    DataGridViewComboBoxColumn comboCliente = new()
                    {
                        Name = "ComboCliente",
                        HeaderText = "Cliente",
                        DataPropertyName = "ID_Cliente",
                        DataSource = clientiTable,
                        DisplayMember = "Rag_Soc",
                        ValueMember = "ID"
                    };
                    dataGridViewEventi.Columns.Add(comboCliente);
                }
                
                if (!dataGridViewEventi.Columns.Contains("ComboTipologia"))
                {
                    var tipologieTable = tipologieRepository.GetAll();
                    DataGridViewComboBoxColumn comboTipologia = new()
                    {
                        Name = "ComboTipologia",
                        HeaderText = "Tipo Evento",
                        DataPropertyName = "ID_Tipologia_noleggi",
                        DataSource = tipologieTable,
                        DisplayMember = "Descrizione",
                        ValueMember = "ID"
                    };
                    dataGridViewEventi.Columns.Add(comboTipologia);
                }
            }
            
            dataGridViewEventi.AutoResizeColumns();
            dataGridViewEventi.AutoResizeRows();
            Form_Principale.EvidenziaDatePassate(dataGridViewEventi);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SalvaEventi()
    {
        try
        {
            foreach (DataGridViewRow row in dataGridViewEventi.Rows)
            {
                if (row.IsNewRow) continue;
                
                if (!ValidaRiga(row))
                {
                    continue;
                }
                
                object idObj = row.Cells["ID"]?.Value;
                string nomeEvento = row.Cells["Nome_Evento"].Value?.ToString() ?? "";
                DateTime dataInizio = Convert.ToDateTime(row.Cells["Data_inizio"].Value);
                DateTime dataFine = Convert.ToDateTime(row.Cells["Data_fine"].Value);
                int idCliente = Convert.ToInt32(row.Cells["ComboCliente"].Value);
                int idTipologia = Convert.ToInt32(row.Cells["ComboTipologia"].Value);
                
                DataRow dataRow = datiEventi!.NewRow();
                dataRow["Nome_Evento"] = nomeEvento;
                dataRow["Data_inizio"] = dataInizio;
                dataRow["Data_fine"] = dataFine;
                dataRow["ID_Cliente"] = idCliente;
                dataRow["ID_Tipologia_nolegzi"] = idTipologia;
                
                if (idObj != null && idObj != DBNull.Value && int.TryParse(idObj.ToString() ?? "", out int id))
                {
                    dataRow["ID"] = id;
                    eventiRepository.Update(dataRow);
                }
                else
                {
                    eventiRepository.Add(dataRow);
                }
            }
            
            MessageBox.Show("Modifiche salvate con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CaricaEventi(true);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


