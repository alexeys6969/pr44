using praktika.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace praktika.Models
{
    public class Courses : Notification
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
