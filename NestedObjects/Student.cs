using System;
using System.Collections.Generic;
using System.Text;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// The students legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// List of course the student is enrolled in
        /// </summary>
        public List<Course> Schedule { get; set; }
    }
}