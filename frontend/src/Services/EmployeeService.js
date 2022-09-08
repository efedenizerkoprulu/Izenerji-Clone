import axios from "axios"

export default class EmployeeService {
    getEmployee(){
    return axios.get("https://localhost:7005/gateway/Home/employee");
   
    }
}