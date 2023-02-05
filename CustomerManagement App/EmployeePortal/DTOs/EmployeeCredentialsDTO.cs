﻿namespace EmployeePortal.DTOs
{
    public class EmployeeCredentialsDTO
    {
        public EmployeeCredentialsDTO(string employeeID, string employeePassword)
        {
            EmployeeID = employeeID;
            EmployeePassword = employeePassword;
        }

        public string EmployeeID { get; set; }
        public string EmployeePassword { get; set; }
    }
}