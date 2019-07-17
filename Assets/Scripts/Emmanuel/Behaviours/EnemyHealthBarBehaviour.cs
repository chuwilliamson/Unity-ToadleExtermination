using Steffan;
using UnityEngine;
using UnityEngine.UI;

namespace Emmanuel.Behaviours
{
    public class EnemyHealthBarBehaviour : MonoBehaviour
    {
        public EnemyDataBehaviour edBehaviour;
    
        public float health;
        public float maxHealth;

    
        public GameObject healthBarUI;
        public Slider slider;

        void start()
        {
            maxHealth = edBehaviour.ed.Health;
            health = maxHealth;
            slider.value = CalculateHealth();
        }

        void Update()
        {
            slider.value = CalculateHealth();

            if ( health < maxHealth )
            {
                healthBarUI.SetActive(true);
            }
        }
    
        float CalculateHealth()
        {
            return health / maxHealth;
        }
    
    }
}
