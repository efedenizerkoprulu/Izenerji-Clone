import axios from "axios"

export default class ImageItemService {
    getImageInfo(){
    return axios.get("https://localhost:7005/gateway/Home/imagelist");
   
    }
}