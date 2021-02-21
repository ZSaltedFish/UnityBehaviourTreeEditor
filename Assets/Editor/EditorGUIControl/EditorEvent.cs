using UnityEngine;

namespace Model
{
    public class EditorEvent
    {
        public Event Event;
        private bool _isUse = false;

        public EditorEvent(Event e)
        {
            Event = e;
        }

        public void Use()
        {
            _isUse = true;
        }

        public bool IsUsed()
        {
            return _isUse;
        }
    }
}
