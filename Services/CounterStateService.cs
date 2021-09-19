using System;

namespace BlazorStore.Services
{
    public class CounterStateService
    {
        private int count;
        public event Action Onchange;
        public int CounterCount {
            get { return count; }
            set { count = value;
                NotifyChange();
             }
        }
        private void NotifyChange() => Onchange?.Invoke();
    }
}