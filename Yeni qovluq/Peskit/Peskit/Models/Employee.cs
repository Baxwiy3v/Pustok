namespace Peskit.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Twitter { get; set; }

        public string LinkedIn { get; set; }

        public Position Position { get; set; }

        public int PositionId { get; set; }

        public string DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
