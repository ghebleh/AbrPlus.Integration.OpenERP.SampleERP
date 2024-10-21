namespace Noyan.Repository2
{
    public interface ITrackingRepository<TEntity>
    {
        void EnableTableTracking();
        void DisableTableTracking();
        long GetCurrentTrackingVersion();
        List<ChangeTrackingRecord> GetTrackingChanges(long afterVersion);
    }
}