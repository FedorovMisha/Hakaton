namespace EdibleInedible
{
    public enum EdibleInedibleStatus
    {
        Edible = 0,
        Inedible
    }
    
    public class State
    {
        public static EdibleInedibleStatus EdibleState { get; set; } 
    }
}