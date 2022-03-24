namespace BilgeAdam.Events.Models
{
    public class Parent
    {
        public event MatchedHandler onMatched;
        // DisruptMatchedHandler event olacak
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Parent Spouse { get; set; }
        public override string ToString()
        {
            return FullName;
        }

        public void SetSpouse(Parent spouse)
        {
            Spouse = spouse;
            spouse.onMatched.Invoke(spouse, this);
        }
    }

    public delegate void MatchedHandler(Parent self, Parent spouse);
    public enum Gender
    {
        Female,
        Male
    }
}