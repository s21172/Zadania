using BlazorServerExample.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerExample.Pages.ComponentsExamples
{
    public partial class L10_PartialClass
    {
        private List<Student> students = new List<Student>();

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(4000);
            students.Add(new Student
            {
                FirstName = "John",
                LastName = "Smith",
                IdStudent = 1
            });
            students.Add(new Student
            {
                FirstName = "Anne",
                LastName = "Smith",
                IdStudent = 2
            });
        }

        private void DeleteStudent(Student st)
        {
            Console.WriteLine("Deleted student " + st.IdStudent);
        }
    }
}
