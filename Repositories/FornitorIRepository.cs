namespace MioGestionaleAccess.Repositories;

using System.Data;
using System.Data.OleDb;
using MioGestionaleAccess.Services;

/// <summary>
/// Repository per la gestione dei Fornitori
/// Centralizza tutte le query relative alla tabella Fornitori
/// </summary>
public class FornitorIRepository
{
    /// <summary>
    /// Recupera tutti i fornitori dal database, ordinati per Ragione Sociale
    /// </summary>
    public DataTable GetAll()
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Fornitori ORDER BY Rag_Soc;";
                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento dei fornitori: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera un fornitore specifico per ID
    /// </summary>
    public DataTable GetById(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Fornitori WHERE ID = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", id);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento del fornitore con ID {id}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiunge un nuovo fornitore al database
    /// </summary>
    public void Add(DataRow fornitoreRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Fornitori (Rag_Soc, Indirizzo, Tel_1, Tel_2, Riferimento, Note)
                               VALUES (?, ?, ?, ?, ?, ?);";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Rag_Soc"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Indirizzo"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Tel_1"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Tel_2"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Riferimento"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Note"] ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiunta del fornitore: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiorna un fornitore esistente
    /// </summary>
    public void Update(DataRow fornitoreRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"UPDATE Fornitori SET 
                               Rag_Soc = ?, Indirizzo = ?, Tel_1 = ?, Tel_2 = ?, Riferimento = ?, Note = ?
                               WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Rag_Soc"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Indirizzo"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Tel_1"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Tel_2"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Riferimento"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["Note"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", fornitoreRow["ID"]);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiornamento del fornitore: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Elimina un fornitore dal database per ID
    /// </summary>
    public void Delete(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Fornitori WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'eliminazione del fornitore con ID {id}: {ex.Message}", ex);
        }
    }
}
