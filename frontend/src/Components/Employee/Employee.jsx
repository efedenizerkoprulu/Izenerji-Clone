import React, { useEffect, useState } from "react";
import "./employee.css";
import "./employeeMobile.css";
import {Button} from '@mui/material';
import EmployeeService from "../../Services/EmployeeService";

export default function Employee() {
  const [Employee, setEmployee] = useState([]);

  useEffect(() => {
    let employeeService = new EmployeeService();
    employeeService
      .getEmployee()
      .then((result) => setEmployee(result.data.data));
  });

  return (
    <div className="employee-main">
      <ul>
        {Employee.map((getEmployee) => (
          <li>
            <h4>
              {getEmployee.firstname}
              <h4 id="join-nameSurname">{getEmployee.lastname}</h4>
            </h4>
            <p id="position">{getEmployee.position}</p>
            <p id="explanation">{getEmployee.explanation}</p>
          </li>
        ))}
      </ul>
      <Button variant="outlined">Daha Fazla</Button>
    </div>
  );
}
