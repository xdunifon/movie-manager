using MovieManager.Models;

namespace MovieManager.Services
{
    public interface IBaseService
    {
        void SaveContext();
        Task SaveContextAsync();
    }

    public class BaseService : IBaseService
    {
        protected ApiContext _context {  get; set; }

        public BaseService()
        {
            _context = new ApiContext();
        }

        public void SaveContext()
        {
            try
            {
                _context.SaveChanges();
            } 
            catch {
                throw new Exception("Encountered error while saving changes");
            }
        }

        public async Task SaveContextAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new Exception("Encountered error while saving changes");
            }
        }
    }
}
