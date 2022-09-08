using Core.DataAccess;
using Entities;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IArticleDal: IEntityRepository<Article>
    {
        public List<ArticleArticleDetailsCategoryDTO> GetArticle();
    }
}
