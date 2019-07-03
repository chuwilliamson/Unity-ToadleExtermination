using UnityEngine;

namespace Matthew
{
    public interface IListener
    {
        void Subscribe();
        void Unsubscribe();
        void OnEventRaised(params Object[] obj);
        void OnEventRaised();
    }
}