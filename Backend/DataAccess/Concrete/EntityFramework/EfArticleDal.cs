using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, İzenerjiContext>, IArticleDal
    {
        public List<ArticleArticleDetailsCategoryDTO> GetArticle()
        {
            using (var context = new İzenerjiContext())
            {
                var getArticle = (from article in context.Articles
                                  join category in context.Categories
                                  on article.CategoryId equals category.Id
                                  join articleDetail in context.ArticleDetails
                                  on article.Id equals articleDetail.ArticleID
                                  select new ArticleArticleDetailsCategoryDTO
                                  {
                                      Id = article.Id,
                                      CategoryName = category.Name,
                                      Title = article.Title,
                                      Date = article.Date,
                                      ArticleDetail = articleDetail.Explanation

                                  }).ToList();
                return getArticle;
            }
        }
    }
}
