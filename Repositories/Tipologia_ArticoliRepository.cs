namespace MioGestionaleAccess.Repositories;

using System.Data;
using System.Data.OleDb;
using MioGestionaleAccess.Services;

/// <summary>
/// Repository per la gestione delle Tipologie di Articoli
/// Centralizza tutte le query relative alla tabella Tipologia_Articoli
/// </summary>
public class Tipologia_ArticoliRepository
{
    /// <summary>
    /// Recupera tutte le tipologie di articoli dal database
    /// </summary>
    public DataTable GetAll()
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Tipologia_Articoli ORDER BY [Codice];";
                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento delle tipologie di articoli: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera una tipologia di articoli specifica per ID
    /// </summary>
    public DataTable GetById(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Tipologia_Articoli WHERE [ID] = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", id);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento della tipologia di articoli con ID {id}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiunge una nuova tipologia di articoli al database
    /// </summary>
    public void Add(DataRow tipologiaRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Tipologia_Articoli ([Codice], [Descrizione], [Note])
                               VALUES (?, ?, ?)";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Codice"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Descrizione"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Note"] ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiunta della tipologia di articoli: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiorna una tipologia di articoli esistente
    /// </summary>
    public void Update(DataRow tipologiaRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"UPDATE Tipologia_Articoli SET 
                               [Codice] = ?, [Descrizione] = ?, [Note] = ?
                               WHERE [ID] = ?";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Codice"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Descrizione"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["Note"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", tipologiaRow["ID"]);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiornamento della tipologia di articoli: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Elimina una tipologia di articoli dal database per ID
    /// </summary>
    public void Delete(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Tipologia_Articoli WHERE [ID] = ?";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'eliminazione della tipologia di articoli con ID {id}: {ex.Message}", ex);
        }
    }
}
