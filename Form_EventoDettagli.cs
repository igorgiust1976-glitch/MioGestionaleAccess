namespace MioGestionaleAccess;

using System.Data;
using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_EventoDettagli : Form
{
    private int? eventoId;
    private readonly EventiRepository eventiRepository = new();
    private readonly ClientiRepository clientiRepository = new();
    private readonly TipologieRepository tipologieRepository = new();

    public Form_EventoDettagli(int? id)
    {
        InitializeComponent();
        this.eventoId = id;
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        CaricaComboBoxes();
        
        buttonSalva.Click += (s, ev) => buttonSalva_Click();
        buttonAnnulla.Click += (s, ev) => this.DialogResult = DialogResult.Cancel;

        if (eventoId.HasValue)
        {
            this.Text = "Modifica Evento";
            CaricaDatiEvento(eventoId.Value);
        }
        else
        {
            this.Text = "Nuovo Evento";
            PulisciCampi();
        }
    }

    private void CaricaComboBoxes()
    {
        try
        {
            var clientiTable = clientiRepository.GetAll();
            comboBoxCliente.DataSource = clientiTable;
            comboBoxCliente.DisplayMember = "Rag_Soc";
            comboBoxCliente.ValueMember = "ID";
            comboBoxCliente.SelectedIndex = -1;

            var tipologieTable = tipologieRepository.GetAll();
            comboBoxTipologia.DataSource = tipologieTable;
            comboBoxTipologia.DisplayMember = "Descrizione";
            comboBoxTipologia.ValueMember = "ID";
            comboBoxTipologia.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Carica i dati dell'evento dal repository
    /// </summary>
    private void CaricaDatiEvento(int id)
    {
        try
        {
            var dt = eventiRepository.GetById(id);
            
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                textBoxNomeEvento.Text = row["Nome_Evento"]?.ToString() ?? "";
                
                if (row["Data_inizio"] is DateTime dataInizio)
                    dateTimePickerInizio.Value = dataInizio;
                
                if (row["Data_fine"] is DateTime dataFine)
                    dateTimePickerFine.Value = dataFine;
                
                if (row["ID_Cliente"] is int idCliente)
                    comboBoxCliente.SelectedValue = idCliente;
                
                if (row["ID_Tipologia_noleggi"] is int idTipologia)
                    comboBoxTipologia.SelectedValue = idTipologia;
                
                // Leggi Note solo se la colonna esiste nello schema
                if (dt.Columns.Contains("Note"))
                {
                    textBoxNote.Text = row["Note"]?.ToString() ?? "";
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento dell'evento: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PulisciCampi()
    {
        textBoxNomeEvento.Clear();
        dateTimePickerInizio.Value = DateTime.Today;
        dateTimePickerFine.Value = DateTime.Today;
        comboBoxCliente.SelectedIndex = -1;
        comboBoxTipologia.SelectedIndex = -1;
        textBoxNote.Clear();
    }

    private void buttonSalva_Click()
    {
        // Validazione
        if (string.IsNullOrWhiteSpace(textBoxNomeEvento.Text))
        {
            MessageBox.Show("Il Nome Evento è obbligatorio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxNomeEvento.Focus();
            return;
        }

        if (comboBoxCliente.SelectedIndex < 0)
        {
            MessageBox.Show("Selezionare un Cliente.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            comboBoxCliente.Focus();
            return;
        }

        if (comboBoxTipologia.SelectedIndex < 0)
        {
            MessageBox.Show("Selezionare una Tipologia.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            comboBoxTipologia.Focus();
            return;
        }

        if (dateTimePickerFine.Value < dateTimePickerInizio.Value)
        {
            MessageBox.Show("La data fine deve essere successiva alla data inizio.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dateTimePickerFine.Focus();
            return;
        }

        try
        {
            // Recupera lo schema dal repository per creare una DataRow con le colonne corrette
            var dtSchema = eventiRepository.GetAll();
            DataRow dataRow = dtSchema.NewRow();
            dataRow["Nome_Evento"] = textBoxNomeEvento.Text;
            dataRow["Data_inizio"] = dateTimePickerInizio.Value;
            dataRow["Data_fine"] = dateTimePickerFine.Value;
            dataRow["ID_Cliente"] = comboBoxCliente.SelectedValue;
            dataRow["ID_Tipologia_noleggi"] = comboBoxTipologia.SelectedValue;
            
            // Assegna Note solo se la colonna esiste nello schema
            if (dtSchema.Columns.Contains("Note"))
            {
                dataRow["Note"] = textBoxNote.Text;
            }

            if (eventoId.HasValue)
            {
                dataRow["ID"] = eventoId.Value;
                eventiRepository.Update(dataRow);
                MessageBox.Show("Evento modificato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                eventiRepository.Add(dataRow);
                MessageBox.Show("Evento aggiunto con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel salvataggio dell'evento: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
