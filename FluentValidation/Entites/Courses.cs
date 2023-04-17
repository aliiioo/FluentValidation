namespace FluentValidationing.Entites
{
    public class Courses
    {
        public int courseid { get; set; }

        public string CourseName { get; set; }


        #region Relation

        public int Studentid { get; set; }
        public Students students { get; set; }
        #endregion



    }
}
