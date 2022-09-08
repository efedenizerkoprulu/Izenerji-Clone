import React, { useEffect, useState } from "react";
import "./article.css";
import "./articleMobile.css"
import image from "../../img/image.js";
import ArticleService from "../../Services/ArticleService";


export default function Article() {
  const [Article, setArticle] = useState([]);

  useEffect(() => {
    let articleService = new ArticleService();
    articleService
      .getArticleInfo()
      .then((result) => setArticle(result.data.data));
  });
  return (
    <div className="article-main">
      <img src={image.BasePicture2} alt="BasePicture2" />

      {Article.map((article)=>(
              <div className="article-item">
              <ul>
                <li>{article.categoryName}</li>
                <li>{article.date.slice(0,10)}</li>
              </ul>
              <div>
                <div className="article-writing">
                <h3>{article.title.trim()}</h3>
                <br/>
                <p id="article-detail"> {article.articleDetail.slice(0,84)} </p>
                <br/>
                <a href="jabjba">
                  <h3 id="article-link">oku</h3>
                </a> 
              </div>
              </div>
            </div>
           
      ))}

    </div>
  );
}
