import axios from "axios"

export default class ArticleService {
    getArticleInfo(){
    return axios.get("https://localhost:7005/gateway/Home/article");
      
    }
}