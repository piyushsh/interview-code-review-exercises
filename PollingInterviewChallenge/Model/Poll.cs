namespace PollingInterviewChallenge.Model
{
    public class Poll
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PollOption> Options { get; set; }
    }
}
