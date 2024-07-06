namespace Chat.Contract
{
    public interface IChatClient
    {
        public Task ReceiveMessage(string userName, string message);
    }
}
