import React, {useState,useEffect} from 'react'
import {CircularProgressbar, buildStyles} from "react-circular-progressbar";
import "react-circular-progressbar/dist/styles.css";
import AbilityService from "../../Services/AbilityService";
import "./ability.css"
import "./abilityMobile.css"


export default function Ability() {
    const [Ability, setAbility] = useState([]);

    useEffect(()=> {
      let abilityService= new AbilityService()
      abilityService
      .getAbilityInfo()
      .then(result => setAbility(result.data.data))
    })
  return (
    <div className="ability-main">
        <h1> Yeteneklerlerimiz </h1>
        <h3> At half-past eight the door opened, the policeman appeared, and, requesting them to follow him, led the way to an adjoining hall.</h3>
        {Ability.map((ability)=> (
            <ul className="inline">
                <li>
                <CircularProgressbar className="size"
            value={ability.succsessPercentage}
            text={ability.name}
            styles={buildStyles({
                textColor: "black",
                pathColor: "#41CB83",
                trailColor: "lightgray",
                textSize: "12px"
               
            })}
          />
                </li>
                 </ul>
        ))}
    </div>
  )
}
