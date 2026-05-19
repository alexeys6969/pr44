using praktika.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Schema = System.ComponentModel.DataAnnotations.Schema;

namespace praktika.Models
{
    public class Students : Notification
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

        private string course;
        public string Course
        {
            get { return course; }
            set
            {
                course = value;
                OnPropertyChanged("Course");
            }
        }

        private string speciality;
        public string Speciality
        {
            get { return speciality; }
            set
            {
                speciality = value;
                OnPropertyChanged("Speciality");
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        [Schema.NotMapped]
        private bool isEnable;
        [Schema.NotMapped]
        public bool IsEnable
        {
            get => isEnable;
            set
            {
                isEnable = value;
                OnPropertyChanged(nameof(IsEnable));
                // При изменении IsEnable обновляем зависимые свойства
                OnPropertyChanged(nameof(AddEditBthText));
                OnPropertyChanged(nameof(OnEditAddMainText));
            }
        }

        [NotMapped]
        public string AddEditBthText => IsEnable ? "Добавить" : "Изменить";

        [NotMapped]
        public string OnEditAddMainText => IsEnable ? "Добавить студента" : "Изменить студента";
        [Schema.NotMapped]
        public RealyCommand OnEdit
        {

        }
        [Schema.NotMapped]
        public RealyCommand OnDelete
        {

        }
    }
}
