namespace Chat.Server.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public string UserName { get; set; }
        public string Body { get; set; }
        public DateTime SendTime { get; set; }
    }
}
