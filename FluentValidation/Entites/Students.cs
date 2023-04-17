namespace FluentValidationing.Entites
{
    public class Students
    {
        public int Studentid { get; set; }

        public string Name { get; set; }

        public string Familty { get; set; }

        public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public DateTime BearthDay { get; set; }


        #region Relation

        public List<Courses> Courses { get; set; }

        #endregion


    }
}
