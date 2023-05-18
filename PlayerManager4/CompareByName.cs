using System;

namespace PlayerManager4
{
    public class CompareByName : IComparable<Player>
    {
        private bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int CompareTo(Player other)
        {
            if (other == null)
                return 1;

            if (ascending)
                return string.Compare(Name, other.Name);
            else
                return string.Compare(other.Name, Name);
        }
    }
}
