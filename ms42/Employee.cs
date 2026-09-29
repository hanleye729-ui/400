using System;
using InnManager.Enums;

namespace InnManager.Employees
{
    // all comments written by Github Copilot
    /// <summary>
    /// Represents an employee who works at the hotel.
    /// </summary>
    public class Employee
    {
        public string EmployeeID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Employee position.
        /// </summary>
        public EmployeePosition Position { get; set; } = EmployeePosition.FrontDesk;

        public bool IsActive { get; set; } = true;
    }
}
