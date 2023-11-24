﻿namespace Peskit.Models
{
    public class Department
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
