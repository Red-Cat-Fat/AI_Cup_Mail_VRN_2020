using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Utilities
{
    public class DisposebleEvent : IDisposable
    {
        private Action _callback;

        public DisposebleEvent(Action callback)
        {
            _callback = callback;
        }

        public void Invoke()
        {
            _callback?.Invoke();
        }

        public void Dispose()
        {
            _callback = null;
        }
    }

    public class DisposebleEvent<T> : IDisposable
    {
        private Action<T> _callback;

        public DisposebleEvent(Action<T> callback)
        {
            _callback = callback;
        }

        public void Invoke(T value)
        {
            _callback?.Invoke(value);
        }

        public void Dispose()
        {
            _callback = null;
        }
    }
    public class DisposebleEvent<T1, T2> : IDisposable
    {
        private Action<T1, T2> _callback;

        public DisposebleEvent(Action<T1, T2> callback)
        {
            _callback = callback;
        }

        public void Invoke(T1 value1, T2 value2)
        {
            _callback?.Invoke(value1, value2);
        }

        public void Dispose()
        {
            _callback = null;
        }
    }
}
