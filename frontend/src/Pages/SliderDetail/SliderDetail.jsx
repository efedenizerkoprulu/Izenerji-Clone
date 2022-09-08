import React, { useEffect, useState } from "react";
import { Navi, Footer } from "../../Layouts";
import { useParams } from "react-router-dom";
import {Button} from '@mui/material';
import SliderService from "../../Services/SliderService.js";
import image from "../../img/image.js";
import "./sliderDetailMobile.css";
import "./sliderDetail.css";

export default function SliderDetail() {
  let { id } = useParams();

  const [SliderDetail, setSliderDetail] = useState([]);

  useEffect(() => {
    let sliderDetailService = new SliderService();
    sliderDetailService
      .GetSliderById(id)
      .then((result) => setSliderDetail(result.data.data));
  },[]);

  return (
    <div>
      <Navi />
      <div className="sliderDetail-main">
        <img src={image.BasePicture} alt="BasePicture" />
        <div className="sliderDetail">
          <h1>{SliderDetail.title}</h1>
          <p>{SliderDetail.sliderDetail}</p>
        </div>
      </div>

      <div className="video-detail">
        <h1>Lorem Ipsum Dolor</h1>
        <p>
          At half-past eight the door opened, the policeman appeared, and,
          requesting them to follow him, led the way to an adjoining hall. It
          was evidently a court-room, and a crowd of Europeans and natives
          already occupied the rear of the apartment.
        </p>
        <img src={image.Play} alt="Play" id="play"/>
        <Button>Devamı</Button>
      </div>


      <div className= "list">
        <ul>
          <li>
            <h3>LOREM IPSUM</h3>
            <p>At half-past eight the door opened, the policeman appeared, and, requesting them to follow him, led the way to an adjoining hall. </p>
          </li>

          <li>
            <h3>LOREM IPSUM</h3>
            <p>At half-past eight the door opened, the policeman appeared, and, requesting them to follow him, led the way to an adjoining hall. </p>
          </li>

          <li>
            <h3>LOREM IPSUM</h3>
            <p>At half-past eight the door opened, the policeman appeared, and, requesting them to follow him, led the way to an adjoining hall. </p>
          </li>
        </ul>
      </div >

      <Footer />
    </div>
  );
}
