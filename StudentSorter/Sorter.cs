using GrapeCity.Documents.Pdf;
using StudentSorter.Debug;

namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents = new();
        public List<Group> AllGroups = new();

        public List<IllegalPair> IllegalPairs = new();

        private readonly static Sorter Instance = new();

        public List<SorterConfig> SortConfigs = new();

        public List<ManualAssignment> Assignments = new();

        public static Sorter GlobalInstance() => Instance;

        public int DeterminantRange { get; set; }

        /// <summary>
        /// Creates the sorter
        /// </summary>
        public Sorter()
        {
            DeterminantRange = int.MaxValue;
        }

        /// <summary>
        /// Shuffles the groups.
        /// 
        /// The shuffle is first by determinant, then by if 
        /// the group has space
        /// </summary>
        public void ShuffleGroups()
        {
            int sortedStudents = 0;

            AllStudents.Sort(new StudentComparer()); // Shuffle master list

            ManuallyAssign(); // Do all manual assignments first

            foreach (Group AnalysisGroup in AllGroups) // Loop over groups and sort by determinant
            {                                          // and group capacity
                foreach (Student AnalysisStudent in AllStudents)
                {
                    if (AnalysisStudent.CanJoinGroup(AnalysisGroup))
                    {
                        AnalysisGroup.AddStudent(AnalysisStudent);
                        sortedStudents++;
                        Debugger.Log($"(Round 1) Added {AnalysisStudent.Name} to {AnalysisGroup.Name}");
                        Debugger.Log($"Sorted Students: {sortedStudents}");
                    }
                }
            }

            foreach (Group AnalysisGroup in AllGroups) // sort by capacity
            {
                if(AnalysisGroup.IsFull())
                {
                    continue;
                }

                foreach (Student AnalysisStudent in AllStudents)
                {
                    if (!AnalysisGroup.IsFull() && !AnalysisStudent.InGroup())
                    {
                        AnalysisGroup.AddStudent(AnalysisStudent);
                        sortedStudents++;
                        Debugger.Log($"(Round 2) Added {AnalysisStudent.Name} to {AnalysisGroup.Name}");
                        Debugger.Log($"Sorted Students: {sortedStudents}");
                    }
                }
            }
            Debugger.Log($"Sorted {sortedStudents}/{AllStudents.Count} students");

            if (IllegalPairs.Count > 0)
            {
                ReviseSort();
            }
        }

        /// <summary>
        /// Assigns students to groups manually if
        /// selected
        /// </summary>
        public void ManuallyAssign()
        {
            foreach(ManualAssignment assignment in Assignments)
            {
                try
                {
                    Student student = GetStudentByHashCode(assignment.StudentHashCode);
                    Group group = GetGroupByHashCode(assignment.GroupHashCode);

                    group.AddStudent(student);
                    Debugger.Log($"Assigned {student.Name} to {group.Name}");
                }
                catch(Exception) 
                {
                    Debugger.Log("Couldn't find student or group.");
                }
            }
        }

        /// <summary>
        /// Revises the sort by attempting to fix illegal pairs
        /// </summary>
        public void ReviseSort()
        {
            foreach(IllegalPair pair in IllegalPairs)
            {
                foreach(Group group in AllGroups)
                {
                    if(group.Contains(pair.AsList()))
                    {
                        Debugger.Log($"{pair} found in {group.Name}");
                        int groupIndex = new Random().Next(0, AllGroups.Count);

                        // Ensure the picked group isn't the group currently being looked at
                        while (AllGroups[groupIndex] == group)
                        {
                            groupIndex = new Random().Next(0, AllGroups.Count);
                        }

                        // Pick random student from the other group
                        int studentIndex = new Random().Next(0, AllGroups[groupIndex].Size);

                        // Student in the IllegalPair
                        Student student1 = pair.Student1;

                        // The other student
                        Student other = AllGroups[groupIndex].Students[studentIndex];

                        // Make sure that the randomly picked student the students in the pair
                        // aren't themselves an illegal pair
                        while(pair.Contains(other) && PairExists(other, pair.Student2))
                        {
                            other = AllGroups[groupIndex].Students[studentIndex];
                            Debugger.Log($"New group also has disallowed pair.");
                        }

                        // Swap the student from the pair with the other
                        SwapStudents(student1, other);
                        Debugger.Log($"Swapped {student1.Name} and {other.Name}");
                    }
                }
            }
        }

        /// <summary>
        /// Checks if an illegal pair exists with 2 students
        /// </summary>
        /// <param name="s1">
        /// The first student
        /// </param>
        /// <param name="s2">
        /// The second student
        /// </param>
        /// <returns>
        /// Whether the illegal pair exists
        /// </returns>
        public bool PairExists(Student s1, Student s2)
        {
            foreach(IllegalPair pair in IllegalPairs)
            {
                if(pair.Student1 == s1 && pair.Student2 == s2) 
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Swaps the groups of two students
        /// </summary>
        /// <param name="student1">
        /// The first student
        /// </param>
        /// <param name="student2">
        /// The second student
        /// </param>
        public void SwapStudents(Student student1, Student student2)
        {
            Group? firstGroup = FindStudent(student1);
            Group? secondGroup = FindStudent(student2);

            if(firstGroup is null || secondGroup is null) 
            {
                Debugger.Log("At least one of the students is not in a group");
                return;
            }

            if (firstGroup == secondGroup)
            {
                Debugger.Log("Students were in the same group");
                return;
            }

            secondGroup.RemoveStudent(student2);
            secondGroup.AddStudent(student1);

            firstGroup.RemoveStudent(student1);
            firstGroup.AddStudent(student2);
        }

        /// <summary>
        /// Finds the group of a student if they're in one
        /// </summary>
        /// <param name="student">
        /// The student to find
        /// </param>
        /// <returns>
        /// The group the student is in or null
        /// </returns>
        public Group? FindStudent(Student student)
        {
            foreach(Group group in AllGroups)
            {
                if(group.Contains(student))
                {
                    return group;
                }
            }
            Debugger.Log("Couldn't find student anywhere!");
            return null;
        }

        /// <summary>
        /// Resets the groups an students to be shuffled again
        /// </summary>
        public void Reset()
        {
            foreach (Group g in AllGroups) g.Clear();
            RandomizeDeterminants();
            Debugger.Log("Reset Sorter");
        }

        /// <summary>
        /// Randomizes each student's determinant
        /// </summary>
        public void RandomizeDeterminants()
        {
            foreach (var student in AllStudents)
                if(!student.DeterminiantSet)
                    student.Determinant = new Random().Next(1, MaxDeterminant(DeterminantRange));
        }

        /// <summary>
        /// Calculates the maximum determinant a student can have.
        /// The maximum is the Determinant Range times number of groups.
        /// </summary>
        /// <param name="DeterRange">
        /// The range of determinants accepted (i.e. 8, from 1 to 8 or 9 to 16)
        /// </param>
        /// <returns>
        /// The maximum determinant
        /// </returns>
        public int MaxDeterminant(int DeterRange)
        {
            return DeterRange * AllGroups.Count;
        }

        /// <summary>
        /// Adds an illegal pair to the list of illegal pairs
        /// </summary>
        /// <param name="pair">
        /// The pair to add
        /// </param>
        public void AddIllegalPair(IllegalPair pair)
        {
            IllegalPairs.Add(pair);
        }

        /// <summary>
        /// Gets a student by their HashCode
        /// </summary>
        /// <param name="code">
        /// The hash code to search for
        /// </param>
        /// <returns>
        /// The student or null if no one has the hash code
        /// </returns>
        public Student? GetStudentByHashCode(int code)
        {
            foreach(Student student in AllStudents)
                if(student.GetHashCode() == code)
                    return student;

            Debugger.Log($"No student exists with the HashCode {code}!");
            return null;
        }

        /// <summary>
        /// Finds a group by its hashcode
        /// </summary>
        /// <param name="code">
        /// The code to look for
        /// </param>
        /// <returns>
        /// The group with a matching hashcode or nul
        /// if it doesn't exist
        /// </returns>
        public Group? GetGroupByHashCode(int code)
        {
            foreach (Group group in AllGroups)
                if(group.GetHashCode() == code) 
                    return group;

            Debugger.Log($"No group exists with the HashCode {code}");
            return null;
        }

        /// <summary>
        /// Gets a student by their name
        /// </summary>
        /// <param name="name">
        /// The name to search for
        /// </param>
        /// <returns>
        /// The student with the searched name, or
        /// null if they don't exist
        /// </returns>
        public Student? GetStudentByName(string name)
        {
            foreach (Student student in AllStudents)
                if (student.Name.Equals(name))
                    return student;

            return null;
        }

        /// <summary>
        /// Gets a group by its name
        /// </summary>
        /// <param name="name">
        /// The name of the group to search for
        /// </param>
        /// <returns>
        /// The group or null if a group with the
        /// searched name doesn't exist
        /// </returns>
        public Group? GetGroupByName(string name)
        {
            foreach(Group group in AllGroups)
                if(group.Name.Equals(name))
                    return group;

            return null;
        }
        
        /// <summary>
        /// Checks if a group already has
        /// a given name
        /// </summary>
        /// <param name="name">
        /// The name to check
        /// </param>
        /// <returns>
        /// If a group with the name of
        /// name exists
        /// </returns>
        public bool IsGroupNameDuplicate(string name)
        {
            foreach(Group group in AllGroups)
                if(group.Name.Equals(name))
                    return true;

            return false;
        }

        /// <summary>
        /// Finds if a student's name is a duplicate
        /// </summary>
        /// <param name="name">
        /// The name to search
        /// </param>
        /// <returns>
        /// If name is a duplicate
        /// </returns>
        public bool IsStudentNameDuplicate(string name)
        {
            int occurences = 0;

            foreach(Student student in AllStudents)
                if(student.Name.Equals(name))
                    occurences++;

            return occurences > 1;
        }

        /// <summary>
        /// Returns if there is a student already
        /// that has a certain name
        /// </summary>
        /// <param name="name">
        /// A name
        /// </param>
        /// <returns>
        /// If the name already belongs to someone
        /// </returns>
        public bool StudentNameExists(string name)
        {
            foreach(Student student in AllStudents)
                if(student.Name.Equals(name)) 
                    return true;

            return false;
        }

        /// <summary>
        /// Finds if two students are already in a
        /// pair together
        /// </summary>
        /// <param name="s1">
        /// The first student
        /// </param>
        /// <param name="s2">
        /// The second student
        /// </param>
        /// <returns>
        /// If the students have an illegal pair already
        /// </returns>
        public bool IllegalPairExists(Student s1, Student s2)
        {
            foreach(IllegalPair pair in IllegalPairs)
            {
                if(pair.Student1 ==  s1 && pair.Student2 == s2) 
                    return true;
                else if(pair.Student2 == s1 && pair.Student1 == s2)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Returns names of students out of
        /// an uploaded pdf
        /// </summary>
        /// <param name="filePath">
        /// The path to the PDF roster
        /// </param>
        /// <returns>
        /// A list of names in the format
        /// last, first
        /// </returns>
        public static List<string> GetNamesFromPDF(string filePath, int startPage, int pageLimit)
        {
            using var file = File.OpenRead($@"{filePath}");
            GcPdfDocument document = new();
            document.Load(file); // open the PDF document

            List<string> names = new();

            pageLimit = Math.Min(pageLimit, document.Pages.Count);
            startPage = Math.Min(Math.Max(startPage, 0), document.Pages.Count);

            for (int i = startPage; i <= pageLimit; i++) // read all pages from startPage to pageLimit
            {
                var PageText = document.Pages[i].GetText();

                string[] splitTxt = PageText.Split(new char[] { '\n' });

                for (int j = 0; j < splitTxt.Length; j++)
                {
                    // Remove teacher's name and filter for only names
                    if (splitTxt[j].Contains(',') && splitTxt[j].Split(new char[] { ' ' }).Length == 2)
                    {
                        if (splitTxt[j].Split(' ')[0].ToUpper().Equals(splitTxt[j].Split(' ')[0]))
                            continue;
                        names.Add(splitTxt[j]);
                        Debugger.Log($"{splitTxt[j]} added from ${filePath}");
                    }
                }
            }

            return names;
        }
    }
}
