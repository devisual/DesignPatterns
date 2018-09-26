namespace Mediator
{
    public interface IColleague
    {
        void Send(string message);
        void Receive(string message);
        string GetName();
    }
}