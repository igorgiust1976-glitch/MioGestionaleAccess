namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_ClienteDettagli : Form
{
    private int? clienteId;
    private readonly ClientiRepository clientiRepository = new();

    public Form_ClienteDettagli(int? id)
    {
        InitializeComponent();
        this.clienteId = id;
        Load += (s, e) => Form_Load(s, e);
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        buttonSalva.Click += (s, ev) => buttonSalva_Click();
        buttonAnnulla.Click += (s, ev) => this.DialogResult = DialogResult.Cancel;

        if (clienteId.HasValue)
        {
            this.Text = "Modifica Cliente";
            CaricaDatiCliente(clienteId.Value);
        }
        else
        {
            this.Text = "Nuovo Cliente";
            PulisciCampi();
        }
    }

    /// <summary>
    /// Carica i dati del cliente dal repository
    /// </summary>
    private void CaricaDatiCliente(int id)
    {
        try
        {
            var dt = clientiRepository.GetById(id);
            
            if (dt.Rows.Count > 0)
            {
                System.Data.DataRow row = dt.Rows[0];
                textBoxRagioneSociale.Text = row["Rag_Soc"]?.ToString() ?? "";
                textBoxIndirizzo.Text = row["Indirizzo"]?.ToString() ?? "";
                textBoxReferente.Text = row["Referente"]?.ToString() ?? "";
                textBoxTel1.Text = row["Tel_1"]?.ToString() ?? "";
                textBoxTel2.Text = row["Tel_2"]?.ToString() ?? "";
                textBoxNote1.Text = row["Note_1"]?.ToString() ?? "";
                textBoxNote2.Text = row["Note_2"]?.ToString() ?? "";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento del cliente: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PulisciCampi()
    {
        textBoxRagioneSociale.Clear();
        textBoxIndirizzo.Clear();
        textBoxReferente.Clear();
        textBoxTel1.Clear();
        textBoxTel2.Clear();
        textBoxNote1.Clear();
        textBoxNote2.Clear();
    }

    private void buttonSalva_Click()
    {
        // Validazione
        if (string.IsNullOrWhiteSpace(textBoxRagioneSociale.Text))
        {
            MessageBox.Show("La Ragione Sociale è obbligatoria.", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxRagioneSociale.Focus();
            return;
        }

        try
        {
            if (clienteId.HasValue)
            {
                // Modifica
                ModificaCliente();
            }
            else
            {
                // Inserimento nuovo
                InserisciCliente();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void InserisciCliente()
    {
        var dt = new System.Data.DataTable();
        dt.Columns.Add("Rag_Soc", typeof(string));
        dt.Columns.Add("Indirizzo", typeof(string));
        dt.Columns.Add("Referente", typeof(string));
        dt.Columns.Add("Tel_1", typeof(string));
        dt.Columns.Add("Tel_2", typeof(string));
        dt.Columns.Add("Note_1", typeof(string));
        dt.Columns.Add("Note_2", typeof(string));

        var row = dt.NewRow();
        row["Rag_Soc"] = textBoxRagioneSociale.Text;
        row["Indirizzo"] = textBoxIndirizzo.Text;
        row["Referente"] = textBoxReferente.Text;
        row["Tel_1"] = textBoxTel1.Text;
        row["Tel_2"] = textBoxTel2.Text;
        row["Note_1"] = textBoxNote1.Text;
        row["Note_2"] = textBoxNote2.Text;
        dt.Rows.Add(row);

        clientiRepository.Add(dt.Rows[0]);
        MessageBox.Show("Cliente aggiunto con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ModificaCliente()
    {
        var dt = new System.Data.DataTable();
        dt.Columns.Add("ID", typeof(int));
        dt.Columns.Add("Rag_Soc", typeof(string));
        dt.Columns.Add("Indirizzo", typeof(string));
        dt.Columns.Add("Referente", typeof(string));
        dt.Columns.Add("Tel_1", typeof(string));
        dt.Columns.Add("Tel_2", typeof(string));
        dt.Columns.Add("Note_1", typeof(string));
        dt.Columns.Add("Note_2", typeof(string));

        var row = dt.NewRow();
        if (clienteId.HasValue)
        {
            row["ID"] = clienteId.Value;
        }
        row["Rag_Soc"] = textBoxRagioneSociale.Text;
        row["Indirizzo"] = textBoxIndirizzo.Text;
        row["Referente"] = textBoxReferente.Text;
        row["Tel_1"] = textBoxTel1.Text;
        row["Tel_2"] = textBoxTel2.Text;
        row["Note_1"] = textBoxNote1.Text;
        row["Note_2"] = textBoxNote2.Text;
        dt.Rows.Add(row);

        clientiRepository.Update(dt.Rows[0]);
        MessageBox.Show("Cliente modificato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
