namespace Mmu.Mlh.DataAccess.FileSystem.Areas.IdGeneration.Models
{
    public class ControlFile
    {
        public long CurrentId { get; private set; }

        public ControlFile(long currentId)
        {
            CurrentId = currentId;
        }

        public long GetNextId()
        {
            CurrentId++;
            return CurrentId;
        }
    }
}