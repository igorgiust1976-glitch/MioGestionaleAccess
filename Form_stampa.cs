namespace MioGestionaleAccess;

using System.ComponentModel;
using MioGestionaleAccess.Services;
public partial class Form_stampa : Form
{
    private System.Data.DataTable? datiEventi;

    public Form_stampa()
    {
        InitializeComponent();
        Load += (s, e) => Form_stampa_Load(s, e);
    }

    /// <summary>
    /// Imposta i dati degli eventi da stampare (DataTable originale da Form_Principale)
    /// </summary>
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public System.Data.DataTable? DatiEventi
    {
        get { return datiEventi; }
        set { datiEventi = value; }
    }

    public void Form_stampa_Load(object sender, EventArgs e)
    {   
        // Imposta le date di default (ultimi 30 giorni e oggi)
        dataFine.Value = DateTime.Today;
        dataInizio.Value = DateTime.Today.AddDays(-30);

        // Evento click del pulsante Stampa
        buttonStampa.Click += (s, ev) => buttonStampa_Click();
    }

    private void buttonStampa_Click()
    {
        try
        {
            // Se non è stato fornito un DataTable, carica i dati direttamente dal database
            if (datiEventi == null)
            {
                datiEventi = CaricaDatiDaDatabase();
            }

            if (datiEventi == null || datiEventi.Rows.Count == 0)
            {
                MessageBox.Show("Nessun evento disponibile per la stampa.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtra i dati in base ai parametri selezionati
            System.Data.DataTable datiFiltrati = FiltraDati(datiEventi);

            if (datiFiltrati.Rows.Count == 0)
            {
                MessageBox.Show("Nessun evento corrisponde ai criteri selezionati.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea il titolo personalizzato con i filtri applicati
            string statoFiltro = radiobuttonTutti.Checked ? "Tutti" : 
                                 radiobuttonIncorso.Checked ? "In corso" :
                                 radiobuttonNonInziati.Checked ? "Non iniziati" : "Terminati";
            string titolo = $"Elenco Eventi ({statoFiltro}) - Dal {dataInizio.Value:dd/MM/yyyy} al {dataFine.Value:dd/MM/yyyy}";

            // Chiama il metodo generico di stampa da Form_Principale
            Form_Principale.StampaEventiParametrizzati(datiFiltrati, titolo, this);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante la stampa: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Carica i dati degli eventi dal database (se non vengono passati da Form_Principale)
    /// </summary>
    private System.Data.DataTable CaricaDatiDaDatabase()
    {
        try
        {
            using System.Data.OleDb.OleDbConnection conn = new(DatabaseManager.ConnectionString);
            string query = @"SELECT Evento.*, Cliente.Rag_Soc, Tipologia_noleggi.Descrizione 
                            FROM (Evento INNER JOIN Cliente ON Evento.ID_Cliente = Cliente.ID) 
                            INNER JOIN Tipologia_noleggi ON Evento.ID_Tipologia_noleggi = Tipologia_noleggi.ID
                            ORDER BY Evento.Data_inizio, Evento.Data_fine;";
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(query, conn);
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento dei dati: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new System.Data.DataTable();
        }
    }

    /// <summary>
    /// Filtra il DataTable in base ai parametri selezionati (date e stato)
    /// </summary>
    private System.Data.DataTable FiltraDati(System.Data.DataTable datiOriginali)
    {
        System.Data.DataTable dtFiltrato = datiOriginali.Copy();
        
        // Filtra per intervallo di date
        List<System.Data.DataRow> righeDaRimuovere = [];
        
        foreach (System.Data.DataRow row in dtFiltrato.Rows)
        {
            DateTime? dataInizioEvento = row["Data_inizio"] != DBNull.Value ? (DateTime)row["Data_inizio"] : null;
            DateTime? dataFineEvento = row["Data_fine"] != DBNull.Value ? (DateTime?)row["Data_fine"] : null;

            // Controlla se l'evento rientra nell'intervallo di date selezionato
            if (dataInizioEvento == null || dataInizioEvento > dataFine.Value || dataFineEvento < dataInizio.Value)
            {
                righeDaRimuovere.Add(row);
                continue;
            }

            // Filtra per stato evento
            if (radiobuttonTutti.Checked)
            {
                // Includi tutti gli eventi
            }
            else if (radiobuttonIncorso.Checked)
            {
                // Evento in corso: data_inizio <= oggi < data_fine
                if (!(dataInizioEvento <= DateTime.Today && dataFineEvento > DateTime.Today))
                {
                    righeDaRimuovere.Add(row);
                }
            }
            else if (radiobuttonNonInziati.Checked)
            {
                // Evento non iniziato: data_inizio > oggi
                if (!(dataInizioEvento > DateTime.Today))
                {
                    righeDaRimuovere.Add(row);
                }
            }
            else if (radiobuttonTerminati.Checked)
            {
                // Evento terminato: data_fine < oggi
                if (!(dataFineEvento < DateTime.Today))
                {
                    righeDaRimuovere.Add(row);
                }
            }
        }

        // Rimuovi le righe che non soddisfano i criteri
        foreach (System.Data.DataRow row in righeDaRimuovere)
        {
            dtFiltrato.Rows.Remove(row);
        }

        return dtFiltrato;
    }
}
