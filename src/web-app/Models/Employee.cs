using System;

namespace web_app.Models {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime HiredOn { get; set; }
    }
}