import axios from "axios"

export default class ChartDataService {
    getChartData(){
    return axios.get("https://localhost:7005/gateway/Home/chartData");
   
    }
}