
namespace Noyan.Repository
{
    public interface ITrackingRepository
    {
        void EnableTableTracking();
        long GetCurrentTrackingVersion();
        List<ChangeTrackingRecord> GetTrackingChanges(long afterVersion);
    }
}