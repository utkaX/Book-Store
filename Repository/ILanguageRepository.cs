using System.Collections.Generic;
using System.Threading.Tasks;
using Book_Store.Models;


namespace Book_Store.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();

    }
}
