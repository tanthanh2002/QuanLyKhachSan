using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.TANN
{
    public class EventAggregator
    {
        private static EventAggregator _instance;
        private readonly Dictionary<Type, List<Action<object>>> _subscribers;

        private EventAggregator()
        {
            _subscribers = new Dictionary<Type, List<Action<object>>>();
        }

        public static EventAggregator Instance => _instance ?? (_instance = new EventAggregator());

        public void Subscribe<TEvent>(Action<TEvent> handler)
        {
            var eventType = typeof(TEvent);
            if (!_subscribers.ContainsKey(eventType))
            {
                _subscribers[eventType] = new List<Action<object>>();
            }

            _subscribers[eventType].Add(obj => handler((TEvent)obj));
        }

        public void Publish<TEvent>(TEvent @event)
        {
            var eventType = typeof(TEvent);
            if (_subscribers.ContainsKey(eventType))
            {
                var handlers = _subscribers[eventType];
                foreach (var handler in handlers)
                {
                    handler(@event);
                }
            }
        }

    }
}
