namespace EventNotification
{
    class Program
    {
        public delegate void EventNotification(string message)


    public class EventManager
        {
            public event EventNotification NotifyEvent;

            public void Subscrbe( EventNotification attendeeMethod)
            {
                NotifyEvent += attendeeMethod;
            }
            public void TriggerEvent(string eventname)
            {
                if (NotifyEvent != null)
                {
                    Console.WriteLine($"[Event Triggered]: {eventName}");
                    NotifyEvent($"You are invited to the {eventName}!");
                }
                else
                {
                    Console.WriteLine("No attendees have subscribed yet.");
                }
            }

        }
        public class Attendee
        {
            public string Name { get; set; }

            public Attendee(string name)
            {
                Name = name;
            }

            // Method to receive event notifications
            public void ReceiveNotification(string message)
            {
                Console.WriteLine($"{Name} received notification: {message}");
            }
        }
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();

            // Creating attendees
            Attendee attendee1 = new Attendee("Alice");
            Attendee attendee2 = new Attendee("Bob");
            Attendee attendee3 = new Attendee("Charlie");

            // Subscribing attendees to event notifications
            eventManager.Subscribe(attendee1.ReceiveNotification);
            eventManager.Subscribe(attendee2.ReceiveNotification);
            eventManager.Subscribe(attendee3.ReceiveNotification);

            eventManager.TriggerEvent("Tech Conference 2025");
        }
    }
}
