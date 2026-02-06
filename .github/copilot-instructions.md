# MioGestionaleAccess - AI Coding Agent Instructions

## Project Overview
**MioGestionaleAccess** is a Windows Forms desktop application (.NET 10) for managing event/facility data ("Sagre" = festivals/celebrations in Italian). It connects to a local Microsoft Access database (`Sagre_0.001.accdb`) to view and manipulate client and article records.

## Architecture & Key Components

### Database Layer
- **Technology**: OleDb with Microsoft Access (`System.Data.OleDb`)
- **Database File**: `Sagre_0.001.accdb` - copied to output directory at build time
- **Connection Pattern**: Instantiate `OleDbConnection` with connection string built from database path
- **Location Discovery**: Database lives in `Application.StartupPath` (same directory as .exe)
- **Key Tables**: `Cliente` (clients), and other tables for articles/events

```csharp
// Standard connection pattern in Form1.cs
string dbPath = Path.Combine(Application.StartupPath, "Sagre_0.001.accdb");
string connString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
using (OleDbConnection conn = new OleDbConnection(connString)) { ... }
```

### UI Framework
- **Single Form Application**: [Form1.cs](Form1.cs) is the main/only UI
- **Designer Generated Code**: [Form1.Designer.cs](Form1.Designer.cs) - auto-generated, contains control declarations
- **Controls**:
  - `button1` "Carica Tabella Articoli" (Load Articles Table) - triggers data loading
  - `button2` placeholder button
  - `datagridview1`, `datagridview2` - display query results and related data
  - `menustrip1` - placeholder for future menu items
- **Styling**: Dark theme (RGB 37,37,38 background, 204,204,204 text) with flat button style

### Entry Point
[Program.cs](Program.cs) - Standard Windows Forms template:
- `[STAThread]` required for WinForms COM interop (OleDb/Access compatibility)
- Single call: `Application.Run(new Form1())`

## Critical Developer Workflows

### Building
```powershell
dotnet build c:\Users\igorg\MioGestionaleAccess\MioGestionaleAccess.csproj
```
**Important**: Build copies `Sagre_0.001.accdb` to debug output directory (`bin/Debug/net10.0-windows/`) due to `CopyToOutputDirectory` directive in .csproj.

### Running
```powershell
dotnet run --project c:\Users\igorg\MioGestionaleAccess\MioGestionaleAccess.csproj
# or directly: bin/Debug/net10.0-windows/MioGestionaleAccess.exe
```

### Database Testing
The form automatically tests database connectivity on load via `TestConnessione()` - shows success/error dialog.

## Code Patterns & Conventions

### Data Access Pattern (OleDb)
1. Create connection string using `Application.StartupPath`
2. Use `using` blocks for automatic connection disposal
3. Wrap queries in try-catch blocks
4. Use `OleDbDataAdapter` for fetching data
5. Bind results directly to DataGridView via `DataSource` property

**Example from [Form1.cs](Form1.cs#L40-L55)**:
```csharp
using (OleDbConnection conn = new OleDbConnection(connString)) {
    string query = "SELECT * FROM Cliente WHERE ID = 2";
    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
    System.Data.DataTable dt = new System.Data.DataTable();
    conn.Open();
    adapter.Fill(dt);
    this.datagridview1.DataSource = dt;
}
```

### Event Handling
Events are wired dynamically in constructor rather than designer:
```csharp
this.Load += new EventHandler(Form1_Load);
button1.Click += (s, ev) => CaricaTabellaArticoli_Click();
```

### Language
- Code comments and string literals use Italian (e.g., "Connessione al database Access riuscita!")
- Variable names use Italian context ("Cliente" = client, "Articoli" = articles)
- Maintain this convention for consistency

## Dependencies & Integration Points
- **System.Data.OleDb** (v10.0.2) - database access
- **Microsoft.NET.Sdk** - targets net10.0-windows with WindowsForms
- **No external business logic libraries** - all logic currently in Form1.cs

## Common Tasks

### Adding New Query/Data Load Button
1. Add button control in Designer ([Form1.Designer.cs](Form1.Designer.cs))
2. Create handler method in [Form1.cs](Form1.cs) following `CaricaTabellaArticoli_Click()` pattern
3. Wire event in `Form1_Load()` constructor section
4. Use `OleDbDataAdapter` + DataGridView binding pattern

### Modifying Database Queries
- Edit SQL strings in [Form1.cs](Form1.cs) methods (currently hardcoded, no parameterized queries yet)
- Test via dialog buttons - errors appear in `MessageBox` dialogs
- Remember to match table/column names from `Sagre_0.001.accdb` schema

### Styling Changes
- Colors defined in [Form1.Designer.cs](Form1.Designer.cs) as `Color.FromArgb()` values
- Maintain dark theme consistency: background RGB(37,37,38), text RGB(204,204,204), buttons RGB(51,51,51)
