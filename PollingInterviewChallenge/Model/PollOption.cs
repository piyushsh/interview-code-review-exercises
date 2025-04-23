namespace PollingInterviewChallenge.Model
{
    public class PollOption
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
