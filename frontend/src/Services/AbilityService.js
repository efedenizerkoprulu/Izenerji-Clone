import axios from "axios"

export default class AbilityService {
    getAbilityInfo(){
    return axios.get("https://localhost:7005/gateway/Home/ability");
      
    }
}