using System;
using System.Collections.Generic;

namespace wpf_mzc_app.Services
{
    public class Messenger
    {
        public static Messenger Default { get; } = new Messenger();

        private readonly Dictionary<Type, List<Delegate>> actions = new Dictionary<Type, List<Delegate>>();

        public void Register<T>(Action<T> action)
        {
            if (action is null)
                throw new ArgumentNullException(nameof(action));

            lock (actions) //Blocking list for any threads. Save accesses.
            {
                Type type = typeof(T);
                if (actions.TryGetValue(type, out List<Delegate> newList))
                {
                    if (!newList.Contains(action))
                        newList.Add(action);
                }
                else
                    actions.Add(type,new List<Delegate>(1){action});
            }
        }

        public void Unregister<T>(Action<T> action)
        {
            if (action is null)
                throw new ArgumentNullException(nameof(action));

            lock (actions)
            {
                Type type = typeof(T);
                if (actions.TryGetValue(type, out List<Delegate> newList))
                    newList.RemoveAll(act => (Action<T>) act == action);
            }
        }

        public void Send<T>(T message)
        {
            lock (actions)
            {
                Type type = typeof(T);
                if (actions.TryGetValue(type, out List<Delegate> newList))
                    newList.ForEach(d => ((Action<T>)d) (message));
            }
        }
    }
}