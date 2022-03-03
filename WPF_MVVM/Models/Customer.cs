using System;

namespace WPF_MVVM.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FistName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public bool IsEnable { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
