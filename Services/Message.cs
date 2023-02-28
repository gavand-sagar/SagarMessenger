namespace SagarMessenger.Services
{
    public class Message
    {
        public string? From { get; set; }
        public string? MessageText { get; set; }
        public DateTime SentTime { get; private set; }

        public Message()
        {
            this.SentTime = DateTime.Now;
        }
    }
}