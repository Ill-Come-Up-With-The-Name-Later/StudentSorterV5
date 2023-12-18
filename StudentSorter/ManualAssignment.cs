using Newtonsoft.Json;

namespace StudentSorter
{
    public class ManualAssignment : Serializeable
    {
        public int StudentHashCode {  get; set; }
        public int GroupHashCode { get; set; }

        /// <summary>
        /// Represents a manual assignment of a student to a group
        /// </summary>
        /// <param name="studentHashCode">
        /// The student's hash code
        /// </param>
        /// <param name="groupHashCode">
        /// The hash code of the assigned group
        /// </param>
        [JsonConstructor]
        public ManualAssignment(int studentHashCode, int groupHashCode)
        {
            StudentHashCode = studentHashCode;
            GroupHashCode = groupHashCode;

            Sorter.GlobalInstance().Assignments.Add(this);
        }
    }
}
