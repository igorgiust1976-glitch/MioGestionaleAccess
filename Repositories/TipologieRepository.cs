namespace MioGestionaleAccess.Repositories;

using System.Data;
using System.Data.OleDb;
using MioGestionaleAccess.Services;

/// <summary>
/// Repository per la gestione delle Tipologie di noleggio
/// Centralizza tutte le query relative alla tabella Tipologia_noleggi
/// </summary>
public class TipologieRepository
{
    /// <summary>
    /// Recupera tutte le tipologie dal database
    /// </summary>
    public DataTable GetAll()
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Tipologia_noleggi ORDER BY Descrizione;";
                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento delle tipologie: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera una tipologia specifica per ID
    /// </summary>
    public DataTable GetById(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Tipologia_noleggi WHERE ID = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", id);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento della tipologia con ID {id}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiunge una nuova tipologia al database
    /// </summary>
    public void Add(DataRow tipologiaRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Tipologia_noleggi (Descrizione, Note)
                               VALUES (?, ?);";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Descrizione"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Note"] ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiunta della tipologia: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiorna una tipologia esistente
    /// </summary>
    public void Update(DataRow tipologiaRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"UPDATE Tipologia_noleggi SET 
                               Descrizione = ?, Note = ?
                               WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Descrizione"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Note"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["ID"]);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiornamento della tipologia: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Elimina una tipologia dal database per ID
    /// </summary>
    public void Delete(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Tipologia_noleggi WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'eliminazione della tipologia con ID {id}: {ex.Message}", ex);
        }
    }
}
