using MovieManager.Models;

namespace MovieManager.Services
{
    public abstract class BaseService
    {
        protected ApiContext _context {  get; set; }

        public BaseService()
        {
            _context = new ApiContext();
        }

        protected void SaveContext()
        {
            try
            {
                _context.SaveChanges();
            } catch {
                throw new Exception("Encountered error while saving changes");
            }
        }
    }
}
