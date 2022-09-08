import React, { useState, useEffect } from "react";
import "./imageList.css";
import "./imageListMobile.css";
import image from "../../img/image.js";
import ImageItemService from "../../Services/ImageItemService";

export default function ImageList() {
  const [imageitem, setImageItem] = useState([]);

  useEffect(()=> {
    let imageItemService= new ImageItemService()
    imageItemService
    .getImageInfo()
    .then(result => setImageItem(result.data.data))
  })

  return (
    <div>
      <div className="ImageList">
        <h1> Lorem Ipsum </h1>
        <h4>

          At half-past eight the door opened, the policeman appeared, and,
          requesting them to follow him, led the way to an adjoining hall.
        </h4>
        <div >
            
          <ul >
            {imageitem.map((imageitem) => (
              <li >
                <img src={image.BasePicture} alt="BasePicture" />
                <h3 id="image"> {imageitem.title} </h3>
                <p id="image"> {imageitem.explanation} </p>
              </li>
            ))}
          </ul>
        </div>
      </div>
    </div>
  );
}
