namespace BilgeAdam.Events.Models
{
    public class Parent
    {
        public event MatchedHandler onMatched;
        public event DisruptMatchedHandler onDisruptMatching;
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

        public void DisruptMatching(Parent spouse)
        {
            Spouse = null;
            spouse.onDisruptMatching.Invoke(spouse);
        }
    }

    public delegate void MatchedHandler(Parent self, Parent spouse);
    public delegate void DisruptMatchedHandler(Parent self);
    public enum Gender
    {
        Female,
        Male
    }
}