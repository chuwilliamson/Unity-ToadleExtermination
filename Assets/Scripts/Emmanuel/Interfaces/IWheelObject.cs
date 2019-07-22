using UnityEngine;

namespace Emmanuel.Interfaces
{
    public interface IWheelObject
    {
        void Up();
        void Down();
        
        Object Current { get; }
        
        int Index { get; }
    }
}
