using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IDataResult<List<ArticleArticleDetailsCategoryDTO>> GetArticleList()
        {
           return new SuccessDataResult<List<ArticleArticleDetailsCategoryDTO>>(_articleDal.GetArticle());
        }
    }
}
