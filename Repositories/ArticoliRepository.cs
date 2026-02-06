namespace MioGestionaleAccess.Repositories;

using System.Data;
using System.Data.OleDb;
using MioGestionaleAccess.Services;

/// <summary>
/// Repository per la gestione degli Articoli
/// Centralizza tutte le query relative alla tabella Articoli
/// </summary>
public class ArticoliRepository
{
    /// <summary>
    /// Recupera tutti gli articoli dal database
    /// </summary>
    public DataTable GetAll()
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = @"SELECT Articoli.*, Cliente.Rag_Soc, Tipologia_noleggi.Descrizione 
                               FROM (Articoli LEFT JOIN Cliente ON Articoli.ID_Fornitore = Cliente.ID) 
                               LEFT JOIN Tipologia_noleggi ON Articoli.ID_Tipologia = Tipologia_noleggi.ID
                               ORDER BY Articoli.Codice_interno;";
                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento degli articoli: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera un articolo specifico per ID
    /// </summary>
    public DataTable GetById(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = @"SELECT Articoli.*, Cliente.Rag_Soc, Tipologia_noleggi.Descrizione 
                               FROM (Articoli LEFT JOIN Cliente ON Articoli.ID_Fornitore = Cliente.ID) 
                               LEFT JOIN Tipologia_noleggi ON Articoli.ID_Tipologia = Tipologia_noleggi.ID
                               WHERE Articoli.ID = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", id);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento dell'articolo con ID {id}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiunge un nuovo articolo al database
    /// </summary>
    public void Add(DataRow articoloRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Articoli (Codice_interno, Descrizione, Giacenza, ID_Fornitore, ID_Tipologia, Note)
                               VALUES (?, ?, ?, ?, ?, ?);";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", articoloRow["Codice_interno"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["Descrizione"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["Giacenza"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["ID_Fornitore"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["ID_Tipologia"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["Note"] ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiunta dell'articolo: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiorna un articolo esistente
    /// </summary>
    public void Update(DataRow articoloRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"UPDATE Articoli SET 
                               Codice_interno = ?, Descrizione = ?, Giacenza = ?, 
                               ID_Fornitore = ?, ID_Tipologia = ?, Note = ?
                               WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", articoloRow["Codice_interno"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["Descrizione"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["Giacenza"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["ID_Fornitore"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["ID_Tipologia"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["Note"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", articoloRow["ID"]);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiornamento dell'articolo: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Elimina un articolo dal database per ID
    /// </summary>
    public void Delete(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Articoli WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'eliminazione dell'articolo con ID {id}: {ex.Message}", ex);
        }
    }
}
