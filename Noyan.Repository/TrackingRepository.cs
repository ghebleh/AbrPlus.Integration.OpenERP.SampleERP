using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Noyan.Repository.Models;
namespace Noyan.Repository;

public class TrackingRepository<TEntity>
{
    private DbContext _context;

    public TrackingRepository(NoyanDbContext context)
    {
        _context = context;
    }
    public void EnableTableTracking()
    {
        string initialCatalog = _context.Database.GetDbConnection().Database;
        IEntityType entityType = _context.Model.FindEntityType(typeof(TEntity)) ?? throw new Exception();
        //string arg = $"[{entityType.GetSchema()}].[{entityType.GetTableName()}]";
        string arg = entityType.GetSchemaQualifiedTableName() ?? throw new Exception();
        string query = $"SELECT Count(*) AS [Value] FROM sys.change_tracking_databases WHERE database_id = DB_ID('{initialCatalog}')";

        
        var isDbEnabled = _context.Database.SqlQueryRaw<int>(query).First() > 0;

        if (!isDbEnabled)
        {
            try
            {
                string query2 = $"ALTER DATABASE {initialCatalog} SET CHANGE_TRACKING = ON (CHANGE_RETENTION = 5 DAYS, AUTO_CLEANUP = ON)";
                _context.Database.ExecuteSqlRaw(query2);
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        string query3 = $"SELECT Count(*) AS [Value] FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID('{arg}')";
        var isTableEnabled = (_context.Database.SqlQueryRaw<int>(query3).First()) > 0;
        if (!isTableEnabled)
        {
            try
            {
                string query4 = $"ALTER TABLE {arg} ENABLE CHANGE_TRACKING WITH(TRACK_COLUMNS_UPDATED = OFF)";
                _context.Database.ExecuteSqlRaw(query4);
            }
            catch (Exception exception2)
            {
                throw;
            }
        }
        
    }

    /*
    public void DisableTableTracking()
    {
        string initialCatalog = new SqlConnectionStringBuilder(_context.Database.GetConnectionString()).InitialCatalog;
        IEntityType entityType = _context.Model.FindEntityType(typeof(TEntity));
        string arg = $"[{entityType.GetSchema()}].[{entityType.GetTableName()}]";
        string query = $"SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID('{initialCatalog}')";
        if (_context.GetDataTable(query).Rows.Count != 0)
        {
            string query2 = $"SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID('{arg}')";
            if (_context.GetDataTable(query2).Rows.Count != 0)
            {
                string query3 = $"ALTER TABLE {arg} DISABLE CHANGE_TRACKING";
                _context.ExecuteSqlCommand(query3);
            }
        }
    }
    */
    public long GetCurrentTrackingVersion()
    {
        var connection = _context.Database.GetDbConnection() as SqlConnection;
        if(connection.State != ConnectionState.Open)
            connection.Open();
        SqlCommand sqlCommand = new SqlCommand("SELECT NewTableVersion = CHANGE_TRACKING_CURRENT_VERSION()", connection);
        var result = sqlCommand.ExecuteScalar();

        return (long)result;
    }

    /*
    public async Task<long> GetCurrentTrackingVersionAsync()
    {
        return await _context.GetSingleValueAsync<long>("SELECT NewTableVersion = CHANGE_TRACKING_CURRENT_VERSION()", Array.Empty<object>());
    }
    */
    public List<ChangeTrackingRecord> GetTrackingChanges(long afterVersion)
    {
        var connection = _context.Database.GetDbConnection() as SqlConnection;
        if (connection.State != ConnectionState.Open)
            connection.Open();

        string initialCatalog = _context.Database.GetDbConnection().Database;
        IEntityType entityType = _context.Model.FindEntityType(typeof(TEntity)) ?? throw new Exception();
        //string arg = $"[{entityType.GetSchema()}].[{entityType.GetTableName()}]";
        string arg = entityType.GetSchemaQualifiedTableName() ?? throw new Exception();

        SqlCommand sqlCommand = new SqlCommand($"select * from  CHANGETABLE(CHANGES {arg},{afterVersion}) as vvv", connection);

        var result = new List<ChangeTrackingRecord>();
        using (SqlDataReader oReader = sqlCommand.ExecuteReader())
        {
            while (oReader.Read())
            {
                var t1 = oReader["SYS_CHANGE_VERSION"].ToString() ?? "";
                var t2 = oReader["SYS_CHANGE_CREATION_VERSION"].ToString() ?? "";
                var t3 = oReader["SYS_CHANGE_OPERATION"].ToString() ?? "";
                var t4 = oReader["SYS_CHANGE_COLUMNS"].ToString() ?? "";
                var t5 = oReader["SYS_CHANGE_CONTEXT"].ToString() ?? "";
                var t6 = oReader["id_clt"].ToString() ?? "";
                result.Add((t1, t2, t3, t4, t5, t6));
                
            }
        }

        return result;
    }
    /*
    public async Task<DataTable> GetTrackingChangesAsync(long afterVersion)
    {
        string initialCatalog = new SqlConnectionStringBuilder(_context.Database.GetConnectionString()).InitialCatalog;
        IEntityType entityType = _context.Model.FindEntityType(typeof(TEntity));
        string value = $"[{entityType.GetSchema()}].[{entityType.GetTableName()}]";
        return await _dbContext.GetDataTableAsync($"select * from  CHANGETABLE(CHANGES {initialCatalog}.{value},{afterVersion}) AS ChTbl");
    }

    public async Task EnableIdentityInsertAsync()
    {
        IEntityType entityType = _context.Model.FindEntityType(typeof(TEntity));
        string text = $"[{entityType.GetSchema()}].[{entityType.GetTableName()}]";
        await _dbContext.ExecuteSqlCommandAsync("SET IDENTITY_INSERT " + text + " ON");
    }

    public async Task DisableIdentityInsertAsync()
    {
        IEntityType entityType = _context.Model.FindEntityType(typeof(TEntity));
        string text = $"[{entityType.GetSchema()}].[{entityType.GetTableName()}]";
        await _dbContext.ExecuteSqlCommandAsync("SET IDENTITY_INSERT " + text + " OFF");
    }
    */
}

public record struct ChangeTrackingRecord(string ChangeVersion, string ChangeCreationVersion, string ChangeOperation, string ChangeColumns, string ChangeContext, string IdClt)
{
    public static implicit operator (string ChangeVersion, string ChangeCreationVersion, string ChangeOperation, string ChangeColumns, string ChangeContext, string IdClt)(ChangeTrackingRecord value)
    {
        return (value.ChangeVersion, value.ChangeCreationVersion, value.ChangeOperation, value.ChangeColumns, value.ChangeContext, value.IdClt);
    }

    public static implicit operator ChangeTrackingRecord((string ChangeVersion, string ChangeCreationVersion, string ChangeOperation, string ChangeColumns, string ChangeContext, string IdClt) value)
    {
        return new ChangeTrackingRecord(value.ChangeVersion, value.ChangeCreationVersion, value.ChangeOperation, value.ChangeColumns, value.ChangeContext, value.IdClt);
    }
}