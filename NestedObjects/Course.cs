using System;
using System.Collections.Generic;
using System.Text;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual course
    /// </summary>
    class Course
    {
        /// <summary>
        /// The title of the course
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The official course description from course catalog
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of the credits earned for passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor for the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// A list of students that are taking the course
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}