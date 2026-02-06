namespace MioGestionaleAccess;

using MioGestionaleAccess.Repositories;
using MioGestionaleAccess.Services;

public partial class Form_Principale : Form
{
    private readonly EventiRepository eventiRepository = new();

    public Form_Principale()
    {
        InitializeComponent();
        Load += new EventHandler(Form_Principale_Load);
    }
    private void Form_Principale_Load(object? sender, EventArgs e)
    {
        button_Eventi.Click += (s, ev) => button_Eventi_Click();
        button_Sagre.Click += (s, ev) => button_Sagre_Click();
        button_Anagrafiche.Click += (s, ev) => button_Anagrafiche_Click();
        button_Stampa.Click += (s, ev) => button_Stampa_Click();
        button_Articoli.Click += (s, ev) => button_Articoli_Click();
        button_Chiudi.Click += (s, ev) => button_Chiudi_Click();
        button_Tipologie.Click += (s, ev) => button_Anagrafiche_Tipologie_Click();
                
        // Richiama EvidenziaDatePassate al click su intestazioni di colonna
        datagridview1.ColumnHeaderMouseClick += (s, ev) => EvidenziaDatePassate(datagridview1);

        datagridview1.ReadOnly = true;


        CaricaTabella_Eventi();
    }

    private void button_Anagrafiche_Tipologie_Click()
    {
        Form_Anagrafiche_Tipologie formTipologie = new();
            formTipologie.ShowDialog(this);
            // Ricarica la tabella dopo aver chiuso Form_Anagrafiche_Tipologie (se sono state fatte modifiche)
            CaricaTabella_Eventi();
    }

    private void CaricaTabella_Eventi()
    {
        try
        {
            var dt = eventiRepository.GetAll();
            datagridview1.DataSource = dt;

            datagridview1.AutoResizeColumns();
            datagridview1.AutoResizeRows(); 
            datagridview1.Columns["ID"]!.Visible = false;
            datagridview1.Columns["Data_inizio"]!.HeaderText = "Data Inizio";
            datagridview1.Columns["Data_inizio"]!.DefaultCellStyle.Format = "dd/MM/yyyy ";
            datagridview1.Columns["Data_fine"]!.HeaderText = "Data Fine";
            datagridview1.Columns["Data_fine"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
            datagridview1.Columns["Nome_Evento"]!.HeaderText = "Nome Evento";
            datagridview1.Columns["ID_Tipologia_noleggi"]!.Visible = false;
            datagridview1.Columns["ID_evento_riga"]!.Visible = false;    
            datagridview1.Columns["ID_Cliente"]!.Visible = false;
            datagridview1.Columns["Rag_Soc"]!.HeaderText = "Cliente";
            datagridview1.Columns["Descrizione"]!.HeaderText = "Tipo Evento";
            
            // Evidenzia righe con data_inizio nel passato
            EvidenziaDatePassate(datagridview1);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore nel caricamento degli Eventi: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button_Eventi_Click()
    {
        // Apri Form_Gestione_Eventi per gestire gli eventi
        Form_Gestione_Eventi form_gestione_eventi = new()
        {
            Text = "Gestione Eventi"
        };
        form_gestione_eventi.ShowDialog(this);
        
        // Ricarica la tabella dopo aver chiuso Form_Gestione_Eventi (se sono state fatte modifiche)
        CaricaTabella_Eventi();
    }

    private void button_Sagre_Click()
    {
        // TODO: Implementare logica
    }

    private void button_Anagrafiche_Click()
    {
        // Apri Form_Anagrafiche_Clienti
        Form_Anagrafiche_Clienti formAnagrafiche = new();
        formAnagrafiche.ShowDialog(this);
    }

    private void button_Articoli_Click()
    {
        // Apri Form_Anagrafiche_Articoli
        Form_Anagrafiche_Articoli formArticoli = new();
        formArticoli.ShowDialog(this);
    }

    private void button_Stampa_Click()
    {
        // Recupera i dati attuali dal datagridview
        System.Data.DataTable? datiPerStampa = null;
        
        if (datagridview1.DataSource is System.Data.DataTable dt)
        {
            datiPerStampa = dt.Copy();
        }

        // Crea e configura Form_stampa con i dati attuali
        Form_stampa formStampa = new()
        {
            DatiEventi = datiPerStampa
        };
        formStampa.ShowDialog(this);
    }

    /// <summary>
    /// Metodo generico per stampare un DataTable parametrizzato con titolo personalizzato
    /// </summary>
    public static void StampaEventiParametrizzati(System.Data.DataTable datiDaStampare, string titolo, IWin32Window owner)
    {
        try
        {
            if (datiDaStampare == null || datiDaStampare.Rows.Count == 0)
            {
                MessageBox.Show("Nessun evento disponibile per la stampa.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea un nuovo documento di stampa
            System.Drawing.Printing.PrintDocument printDocument = new();
            printDocument.PrintPage += (s, e) => PrintDocument_PrintPageDataTable(s, e, datiDaStampare, titolo);

            // Apri la finestra di anteprima
            System.Windows.Forms.PrintPreviewDialog printPreview = new()
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            printPreview.ShowDialog(owner);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante la stampa: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Metodo per disegnare le pagine di stampa da un DataTable
    /// </summary>
    private static void PrintDocument_PrintPageDataTable(object sender, System.Drawing.Printing.PrintPageEventArgs e, System.Data.DataTable dt, string titolo)
    {
        try
        {
            System.Drawing.Font titleFont = new("Century Gothic", 14, System.Drawing.FontStyle.Bold);
            System.Drawing.Font headerFont = new("Century Gothic", 10, System.Drawing.FontStyle.Bold);
            System.Drawing.Font cellFont = new("Arial Narrow", 9);
            System.Drawing.Brush blackBrush = System.Drawing.Brushes.Black;

            int topMargin = 40;
            int leftMargin = 40;
            int y = topMargin;
            int lineHeight = 20;

            // Titolo personalizzato
            e.Graphics.DrawString(titolo, titleFont, blackBrush, leftMargin, y);
            y += lineHeight + 10;

            // Intestazioni colonne
            int columnX = leftMargin;
            int columnWidth = 120;

            // Disegna intestazioni
            foreach (System.Data.DataColumn col in dt.Columns)
            {
                string headerText;
                if ( (col.ColumnName == "ID_Cliente") || (col.ColumnName == "ID") || (col.ColumnName == "ID_Tipologia_noleggi") || (col.ColumnName == "ID_evento_riga"))
                        continue;
                if (col.ColumnName == "Rag_Soc")
                    headerText = "Cliente";
                else if (col.ColumnName == "Descrizione")
                    headerText = "Tipo Evento";
                else
                    headerText = col.ColumnName.Replace("_", " ");
                e.Graphics.DrawString(headerText, headerFont, blackBrush, columnX, y);
                columnX += columnWidth;
            }
            y += lineHeight + 5;

            // Linea separatrice
            e.Graphics.DrawLine(System.Drawing.Pens.Black, leftMargin, y, leftMargin + (columnWidth * dt.Columns.Count), y);
            y += 5;

            // Dati righe
            foreach (System.Data.DataRow row in dt.Rows)
            {
                columnX = leftMargin;
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    string cellValue = "";
                    if ( (col.ColumnName == "ID_Cliente") || (col.ColumnName == "ID") || (col.ColumnName == "ID_Tipologia_noleggi") || (col.ColumnName == "ID_evento_riga"))
                        continue;
                    
                    if (row[col.ColumnName] != null && row[col.ColumnName] != DBNull.Value)
                    {
                        if (row[col.ColumnName] is DateTime dateValue)
                        {
                            cellValue = dateValue.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            cellValue = row[col.ColumnName].ToString() ?? "";
                        }
                    }
                    
                    e.Graphics.DrawString(cellValue, cellFont, blackBrush, columnX, y);
                    columnX += columnWidth;
                }
                y += lineHeight;

                // Se abbiamo raggiunto il fondo della pagina, continua sulla prossima
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Errore durante la generazione del documento: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    

    private void button_Chiudi_Click()
    {
        this.Close();
    }

    public static void EvidenziaDatePassate(DataGridView dataGridView)
    {
        DateTime dataSistema = DateTime.Today;
        
        foreach (DataGridViewRow riga in dataGridView.Rows)
        {
            if ((riga.Cells["Data_inizio"].Value != null && riga.Cells["Data_inizio"].Value != DBNull.Value) || (riga.Cells["Data_fine"].Value != null
             && riga.Cells["Data_fine"].Value != DBNull.Value))
            {
                if (riga.Cells["Data_inizio"].Value is DateTime dataInizio && riga.Cells["Data_fine"].Value is DateTime dataFine)
                {
                    if (dataInizio <= dataSistema && dataFine > dataSistema)
                    {
                        // Colora la riga in verde chiaro se l'evento è in corso
                        riga.DefaultCellStyle.BackColor = Color.LightSeaGreen;
                        riga.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (dataFine < dataSistema)
                    {
                        // Colora la riga in rosso chiaro se l'evento è terminato
                        riga.DefaultCellStyle.BackColor = Color.LightCoral;
                        riga.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}

