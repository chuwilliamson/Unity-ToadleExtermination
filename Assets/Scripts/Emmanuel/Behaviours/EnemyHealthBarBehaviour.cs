using Steffan;
using Steffan.Behaviours;
using UnityEngine;
using UnityEngine.UI;

namespace Emmanuel.Behaviours
{
    public class EnemyHealthBarBehaviour : MonoBehaviour
    {
        [SerializeField]
        private EnemyDataBehaviour edBehaviour;
    
        private float health;
        private float maxHealth;
        
        public GameObject healthBarUI;
        public Slider slider;

        void Start()
        {
            maxHealth = edBehaviour.ed.Health;
            health = maxHealth;
            slider.value = CalculateHealth();
        }

        void Update()
        {

            slider.value = CalculateHealth();

            if ( health < maxHealth ) { healthBarUI.SetActive(true); }

            if ( health <= 0 ) { healthBarUI.SetActive(false); }
        }
    
        float CalculateHealth()
        {
            health = edBehaviour.ed.Health;
            return health / maxHealth;
        }
    
    }
}
