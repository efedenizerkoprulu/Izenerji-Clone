import React, { useState, useEffect } from "react";
import "./slidebar.css";
import "./sliderbarMobile.css";
import SliderService from "../../Services/SliderService";
import {Button} from '@mui/material';
import { MdChevronLeft, MdChevronRight } from "react-icons/md";
import {Link } from "react-router-dom";

const sideleft = () => {
  var sileder = document.getElementById("slider");
  sileder.scrollLeft = sileder.scrollLeft - 800;
};

const sideright = () => {
  var sileder = document.getElementById("slider");
    sileder.scrollLeft = sileder.scrollLeft + 800;
  
};

export default function Slidebar() {
  const [Slider, setSlider] = useState([]);

  useEffect(()=> {
    let sliderService= new SliderService()
    sliderService
    .getSliderInfo()
    .then(result => setSlider(result.data.data))
  })


  return (
    <div>
    <div className= "slidebar-main">
    <h4> Neler yapıyoruz? </h4>
    <div className="slider">
      
    <MdChevronLeft className="carousel-control" onClick={sideleft} />
    <div className="slider-box" id="slider">
      
      {Slider.map((getslider)=> (
    <div className="item" key={getslider.id}>
      
        <h2> {getslider.title} </h2>
        <p> {getslider.sliderDetail.slice(0,84)} </p>
        <Button variant="outlined"><Link id="color" to={`/SliderDetail/${getslider.id}`}>Detayları Gör</Link></Button>
    </div>   ))}
    </div>
    <MdChevronRight className="carousel-control" onClick={sideright} />
      </div> 
     </div>
    </div>
  )
}
