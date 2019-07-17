using UnityEngine;

namespace Emmanuel.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Turret/TurretDisplay Data")]
    public class TurretDisplayData : ScriptableObject
    {
        public TurretData td; 
        public  Sprite turretIcon;
    }
}
