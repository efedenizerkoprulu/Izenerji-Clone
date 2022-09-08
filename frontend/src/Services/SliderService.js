import axios from "axios";

export default class SliderService {
  getSliderInfo() {
    return axios.get("https://localhost:7005/gateway/Home/slider");
  }
  GetSliderById(id) {
    return axios.get(
      "https://localhost:7005/gateway/SliderDetail/GetSliderById?id=" + id
    );
  }
}
