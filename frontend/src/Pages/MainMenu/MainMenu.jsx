import React from 'react'
import "./mainMenu.css"
import "./mainMenuMobile.css"
import {Navi,Footer} from "../../Layouts"
import image from "../../img/image.js";
import {Button} from '@mui/material';
import  {ImageList,Slidebar,Ability,Article,Chart,Employee}  from "../../Components"



export default function MainMenu() {
  return (
   
    <div> 
      <Navi/>
    <div className="main">
        <div className="video">
        <h1> Bügüne Kadar Neler Yaptık </h1>
        <h4>  At half-past eight the door opened, the policeman appeared, and, requesting them to follow him, led the way to an adjoining hall.</h4>
        <Button variant="outlined">Tanıtım Videosu</Button>
        
        <div className="browser-frame">
          <div className="browser-head">
          <ul className="menu-bar-browser" >
            <li>
            <Button>
            <img src={image.CloseIcon} alt="CloseIcon" id="browser-button-red"/>
            </Button>
            </li>
            <li>
            <Button>
            <img src={image.MinimizeIcon} alt="MinimizeIcon" id="browser-button-yellow"/>
            </Button>
            </li>
            <li> <Button>
            <img src={image.ExpandIcon} alt="ExpandIcon" id="browser-button-green"/>
            </Button></li>
          </ul>
          
          </div>
          <img src={image.IzmirLogo} alt="izmirlogo"/>
        </div>
        </div>
      <ImageList/>
      <Slidebar/>
      <Ability/>
      <Article/>
      <Chart/>

      <div className="refarence">
        <ul>
          <li>
          <img src={image.Asana} alt="AsanaLogo"/>
          </li>
          <li>
          <img src={image.Invision} alt="InvisionLogo"/>
          </li>
          <li>
          <img src={image.Designmodo} alt="DesignmodoLogo"/>
          </li>
          <li>
          <img src={image.Toptal} alt="ToptalLogo"/>
          </li>
          <li>
          <img src={image.Buffer} alt="BufferLogo"/>
          </li>
        </ul>
      </div>
      <Employee/>
      <Footer/>
    </div>
    </div>
  )
}
