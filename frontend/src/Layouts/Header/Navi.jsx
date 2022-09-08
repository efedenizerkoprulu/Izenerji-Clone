import React, { useState } from "react";
import image from "../../img/image.js";
import "./navi.css";
import "./naviMobile.css";
import { Button } from "@mui/material";


export default function Navi() {
const [Click, setClick] = useState(false);

const handleclick=()=> {
  setClick(!Click)
}
  return (
    <div>
    <header className="header">
      <img src={image.logo} alt="Logo" className="logo" />
        <ul>
          <li>Hakkımızda</li>
          <li>Harita</li>
          <li>Galari</li>
          <li>S.S.S</li>
          <li>İletişim</li>
          <li>
            <Button variant="outlined">
    Giriş Yap
      </Button></li>
        </ul>

    </header>
    <div className="toggle-button" onClick={handleclick} >
        <span className="bar"></span>
        <span className="bar"></span>
        <span className="bar"></span>
      </div>
     <header className ="mobile">
     <img src={image.logo} alt="Logo" className="logo" />
     <Button variant="outlined">
    Giriş Yap
      </Button>
     
     
        <ul className= {Click? "mobile ul":"close" }>
           <hr className="line" />
          <li>Hakkımızda</li>
          <li>Harita</li>
          <li>Galari</li>
          <li>S.S.S</li>
          <li>İletişim</li>
      </ul>
     </header>
    </div>
  );
}
