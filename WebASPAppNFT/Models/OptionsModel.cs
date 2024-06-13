

using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class OptionsModel
    {
        private readonly NFTSiteDbContext _context;

        public OptionsModel(NFTSiteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Option> GetOptions()
        {        
            return _context.Options.ToList();       
        }
        public IEnumerable<Option> GetSystemOptions()
        {
            return _context.Options.Where(o => o.IsSystem).ToList();
        }
        public IEnumerable<Option> GetOptionsByRelation(string relation)
        {
            return _context.Options.Where(o => o.Relation == relation).OrderBy(o => o.Order).ToList();
        }

        public Option GetOptionByName(string name)
        {
            return _context.Options.FirstOrDefault(o => o.Name == name);
        }
    }
}
