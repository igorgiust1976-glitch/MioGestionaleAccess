namespace MioGestionaleAccess.Repositories;

using System.Data;
using System.Data.OleDb;
using MioGestionaleAccess.Services;

/// <summary>
/// Repository per la gestione degli Eventi
/// Centralizza tutte le query relative alle tabelle Evento e Evento_riga
/// </summary>
public class EventiRepository
{
    /// <summary>
    /// Recupera tutti gli eventi dal database con informazioni cliente e tipologia
    /// </summary>
    public DataTable GetAll()
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = @"SELECT Evento.*, Cliente.Rag_Soc, Tipologia_noleggi.Descrizione 
                               FROM (Evento INNER JOIN Cliente ON Evento.ID_Cliente = Cliente.ID) 
                               INNER JOIN Tipologia_noleggi ON Evento.ID_Tipologia_noleggi = Tipologia_noleggi.ID
                               ORDER BY Evento.Data_inizio, Evento.Data_fine;";
                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento degli eventi: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera un evento specifico per ID
    /// </summary>
    public DataTable GetById(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = @"SELECT Evento.*, Cliente.Rag_Soc, Tipologia_noleggi.Descrizione 
                               FROM (Evento INNER JOIN Cliente ON Evento.ID_Cliente = Cliente.ID) 
                               INNER JOIN Tipologia_noleggi ON Evento.ID_Tipologia_noleggi = Tipologia_noleggi.ID
                               WHERE Evento.ID = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", id);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento dell'evento con ID {id}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera le righe dettagli di un evento specifico
    /// </summary>
    public DataTable GetEventoRighe(int idEvento)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = @"SELECT Evento_riga.* FROM Evento_riga WHERE ID_Evento = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", idEvento);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento delle righe dell'evento {idEvento}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiunge un nuovo evento al database
    /// </summary>
    public void Add(DataRow eventoRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                // Verifica se la colonna Note esiste nel database
                string query;
                OleDbCommand cmd;
                
                if (eventoRow.Table.Columns.Contains("Note"))
                {
                    query = @"INSERT INTO Evento (Nome_Evento, Data_inizio, Data_fine, ID_Cliente, ID_Tipologia_noleggi, Note)
                           VALUES (?, ?, ?, ?, ?, ?);";
                    cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("?", eventoRow["Nome_Evento"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_inizio"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_fine"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Cliente"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Tipologia_noleggi"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Note"] ?? DBNull.Value);
                }
                else
                {
                    query = @"INSERT INTO Evento (Nome_Evento, Data_inizio, Data_fine, ID_Cliente, ID_Tipologia_noleggi)
                           VALUES (?, ?, ?, ?, ?);";
                    cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("?", eventoRow["Nome_Evento"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_inizio"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_fine"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Cliente"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Tipologia_noleggi"] ?? DBNull.Value);
                }

                using (cmd)
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiunta dell'evento: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiorna un evento esistente
    /// </summary>
    public void Update(DataRow eventoRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                // Verifica se la colonna Note esiste nel database
                string query;
                OleDbCommand cmd;
                
                if (eventoRow.Table.Columns.Contains("Note"))
                {
                    query = @"UPDATE Evento SET 
                           Nome_Evento = ?, Data_inizio = ?, Data_fine = ?, 
                           ID_Cliente = ?, ID_Tipologia_noleggi = ?, Note = ?
                           WHERE ID = ?;";
                    cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("?", eventoRow["Nome_Evento"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_inizio"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_fine"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Cliente"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Tipologia_noleggi"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Note"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID"]);
                }
                else
                {
                    query = @"UPDATE Evento SET 
                           Nome_Evento = ?, Data_inizio = ?, Data_fine = ?, 
                           ID_Cliente = ?, ID_Tipologia_noleggi = ?
                           WHERE ID = ?;";
                    cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("?", eventoRow["Nome_Evento"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_inizio"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["Data_fine"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Cliente"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID_Tipologia_noleggi"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", eventoRow["ID"]);
                }

                using (cmd)
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiornamento dell'evento: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Elimina un evento dal database per ID
    /// </summary>
    public void Delete(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Evento WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'eliminazione dell'evento con ID {id}: {ex.Message}", ex);
        }
    }
}
