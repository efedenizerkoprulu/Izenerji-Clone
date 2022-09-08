using Core.Utilities.Results;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<List<ArticleArticleDetailsCategoryDTO>> GetArticleList();
    }
}
