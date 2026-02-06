namespace MioGestionaleAccess.Services;

/// <summary>
/// Classe statica per gestire la connessione al database Access.
/// Centralizza la stringa di connessione e il percorso del database.
/// </summary>
public static class DatabaseManager
{
    /// <summary>
    /// Ottiene il percorso del database (nella cartella di avvio dell'applicazione)
    /// </summary>
    public static string DbPath => Path.Combine(
        Application.StartupPath, 
        "Sagre_0.001.accdb");

    /// <summary>
    /// Ottiene la stringa di connessione per OleDb
    /// </summary>
    public static string ConnectionString => 
        $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DbPath};";

    /// <summary>
    /// Verifica se il file del database esiste
    /// </summary>
    public static bool DatabaseExists() => File.Exists(DbPath);

    /// <summary>
    /// Testa la connessione al database
    /// </summary>
    /// <returns>true se la connessione riesce, false altrimenti</returns>
    public static bool TestConnection()
    {
        try
        {
            using (var conn = new System.Data.OleDb.OleDbConnection(ConnectionString))
            {
                conn.Open();
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}
