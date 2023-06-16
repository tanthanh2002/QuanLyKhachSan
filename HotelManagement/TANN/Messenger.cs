using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.TANN
{
    public class Messenger
    {
        private static readonly Dictionary<Type, List<Action<object>>> _subscribers = new Dictionary<Type, List<Action<object>>>();

        public static void Subscribe<T>(Action<object> callback)
        {
            if (!_subscribers.ContainsKey(typeof(T)))
            {
                _subscribers[typeof(T)] = new List<Action<object>>();
            }

            _subscribers[typeof(T)].Add(callback);
        }

        public static void Publish<T>(object data)
        {
            if (_subscribers.ContainsKey(typeof(T)))
            {
                foreach (var callback in _subscribers[typeof(T)])
                {
                    callback(data);
                }
            }
        }
    }
}
