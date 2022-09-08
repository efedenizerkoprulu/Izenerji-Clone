import React,{useEffect,useState} from 'react'
import ChartDataService from "../../Services/ChartDataService";
import "./chart.css"
import "./chartMobile.css"
import {AreaChart,Area,XAxis,YAxis,ResponsiveContainer,Tooltip} from "recharts";

export default function Chart() {

  const [Chart,setChart] = useState([]);

  useEffect(() => {
    let chartDataService = new ChartDataService();
    chartDataService
      .getChartData()
      .then((result) => setChart(result.data.data));
  });

  
  return (
   
    <div className ="chart-main">
      <div className ="chart">
      <h1>Kullanıcı Faliyetleri</h1>
      <h3> At half-past eight the door opened, the policeman appeared, and, requesting them to follow him, led the way to an adjoining hall.</h3>
      </div>
      <div className="chart-item">
      <ResponsiveContainer>
      <AreaChart data={Chart}>
        <Tooltip/>
 <XAxis dataKey= "dayName"/>
        <YAxis dataKey="data"/>  
        <Area type="monotone" dataKey="data" fill="#41cb83" />
       </AreaChart>
       </ResponsiveContainer>
       </div>
  
      
     </div>
  )
}
