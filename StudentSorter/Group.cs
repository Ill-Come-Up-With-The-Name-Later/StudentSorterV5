﻿using Newtonsoft.Json;

namespace StudentSorter
{
    public class Group
    {
        public string Name { get; set; }

        public int MinDeterminant { get; set; }

        public int MaxDeterminant { get; set;}

        public int Capacity { get; set; }

        [JsonIgnore]
        public int Size { get { return Students.Count; } }

        [JsonIgnore]
        public List<Student> Students { get; private set; }

        [JsonConstructor]
        public Group(string name, int minDeterminant, int maxDeterminant, int capacity)
        {
            Name = name;
            MinDeterminant = minDeterminant;
            MaxDeterminant = maxDeterminant;
            Capacity = capacity;

            Students = new();

            Sorter.GlobalInstance().AllGroups.Add(this);
        }
        
        /// <summary>
        /// Determines if the group is full
        /// </summary>
        /// <returns>
        /// Whether or not the group is full
        /// </returns>
        public bool IsFull()
        {
            return Size >= Capacity;
        }

        /// <summary>
        /// Determines if a student is already in the group
        /// </summary>
        /// <param name="student">
        /// The student to look for
        /// </param>
        /// <returns>
        /// If the student is in the group
        /// </returns>
        public bool Contains(Student student)
        {
            return Students.Contains(student);
        }

        /// <summary>
        /// Adds a student to the group if the group has space
        /// and they aren't in a group
        /// </summary>
        /// <param name="student">
        /// The student to add
        /// </param>
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        /// <summary>
        /// Removes a student from the group if they're in it
        /// </summary>
        /// <param name="student">
        /// The student to remove
        /// </param>
        public void RemoveStudent(Student student)
        {
            if(Contains(student)) Students.Remove(student);
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) throw new ArgumentNullException("object was null");
            if(obj.GetType() != typeof(Group)) return false;
            Group objGroup = (Group)obj;
            return objGroup.Name.Equals(Name) && objGroup.Capacity == Capacity && 
                objGroup.MinDeterminant == MinDeterminant && objGroup.MaxDeterminant == MaxDeterminant;
        }

        public string SerializeJSON() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
