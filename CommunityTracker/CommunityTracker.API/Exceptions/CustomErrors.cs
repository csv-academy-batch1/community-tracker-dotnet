namespace CommunityTracker.API.Exceptions
{
    public class CustomErrors
    {
        public Result result { get; set; }
    }
    public class Result
    {
        public string message { get; set; } = "failed";
    }
}