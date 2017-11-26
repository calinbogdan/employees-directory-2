using System;

namespace web_app.Models {
    public class Employee {
        public Employee (int id, string name, string email) {
            this.Id = id;
            this.Name = name;
            this.Email = email;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime HiredOn { get; set; }
    }
}