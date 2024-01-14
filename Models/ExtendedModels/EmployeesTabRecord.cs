using System;

namespace HotelDesktop.Models.ExtendedModels;

public class EmployeesTabRecord
{
    public string LastName { get; set; }
    
    public string Name { get; set; }
    
    public string Patronymic { get; set; }
        
    public string UserLogin { get; set; }

    public string HireDate { get; set; }

    public string FireDate { get; set; }

    public bool IsFired { get; set; }

    public string Position { get; set; }

    public decimal Salary { get; set; }
}