namespace MioGestionaleAccess.Repositories;

using System.Data;
using System.Data.OleDb;
using MioGestionaleAccess.Services;

/// <summary>
/// Repository per la gestione dei Clienti
/// Centralizza tutte le query relative alla tabella Cliente
/// </summary>
public class ClientiRepository
{
    /// <summary>
    /// Recupera tutti i clienti dal database, ordinati per Ragione Sociale
    /// </summary>
    public DataTable GetAll()
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Cliente ORDER BY Rag_Soc;";
                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento dei clienti: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Recupera un cliente specifico per ID
    /// </summary>
    public DataTable GetById(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                string query = "SELECT * FROM Cliente WHERE ID = ?;";
                OleDbDataAdapter adapter = new(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", id);
                DataTable dt = new();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nel caricamento del cliente con ID {id}: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiunge un nuovo cliente al database
    /// </summary>
    public void Add(DataRow clienteRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Cliente ([Rag_Soc], [Cognome], [Nome], [Indirizzo], [CAP], [Città], [Provincia], [Telefono], [Email], [Note1], [Note2])
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", clienteRow["Rag_Soc"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Cognome"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Nome"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Indirizzo"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["CAP"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Città"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Provincia"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Telefono"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Email"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Note1"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Note2"] ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiunta del cliente: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Aggiorna un cliente esistente
    /// </summary>
    public void Update(DataRow clienteRow)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = @"UPDATE Cliente SET 
                               Rag_Soc = ?, Cognome = ?, Nome = ?, Indirizzo = ?, CAP = ?, 
                               Città = ?, Provincia = ?, Telefono = ?, Email = ?, Note1 = ?, Note2 = ?
                               WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", clienteRow["Rag_Soc"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Cognome"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Nome"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Indirizzo"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["CAP"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Città"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Provincia"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Telefono"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Email"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Note1"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["Note2"] ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("?", clienteRow["ID"]);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'aggiornamento del cliente: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Elimina un cliente dal database per ID
    /// </summary>
    public void Delete(int id)
    {
        try
        {
            using (OleDbConnection conn = new(DatabaseManager.ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Cliente WHERE ID = ?;";

                using (OleDbCommand cmd = new(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Errore nell'eliminazione del cliente con ID {id}: {ex.Message}", ex);
        }
    }
}
