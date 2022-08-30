namespace TestProject_MyClassLib
{
    internal class emp
    {
        internal DateOnly doj;
        private int v1;
        private string v2;
        private DateOnly dateOnly;

        public emp(int v1, string v2, DateOnly dateOnly)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateOnly = dateOnly;
        }

        internal int GetYearsofExp()
        {
            throw new NotImplementedException();
        }
    }
}