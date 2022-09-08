import axios from "axios"

export default class TwitterService {
    getTwitterInfo(){
    return axios.get("https://localhost:7005/gateway/Home/twitter");
   
    }
}