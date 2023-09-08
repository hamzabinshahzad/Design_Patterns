using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public interface IMediator
    {
        void SendMessage(Colleague colleague, string message);
    }


    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }


    // Implement objects which need to communicate with each other:
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            Console.WriteLine($"'A' sent a message: {msg}");
            _mediator.SendMessage(this, msg); // Notify mediator to send message to other colleagues.
        }

        public void Receive(string msg)
        {
            Console.WriteLine($"'A' received a message: {msg}");
        }
    }


    public class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            Console.WriteLine($"'B' sent a message: {msg}");
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine($"'B' received a message: {msg}");
        }
    }


    // Now implement the concrete Mediator object that handles all the communications between objects
    public class ConcreteMediator : IMediator
    {
        // Mediator object always contains the list of objects which need communication:
        public ConcreteColleagueA colleague1 { get; set; }
        public ConcreteColleagueB colleague2 { get; set; }

        public void SendMessage(Colleague caller, string msg)
        {
            if(caller == colleague1) colleague2.Receive(msg);
            else colleague1.Receive(msg);
        }
    }


}
