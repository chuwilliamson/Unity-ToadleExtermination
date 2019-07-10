using Steffan.Behaviours;
using UnityEngine;
using UnityEngine.UI;

namespace Emmanuel.Behaviours
{
    public class EnemyHealthBarBehaviour : MonoBehaviour
    {
        private float _health;
        private float _maxHealth;

        [SerializeField] private EnemyDataBehaviour edBehaviour;

        public GameObject healthBarUI;
        public Slider slider;

        private void Start()
        {
            _maxHealth = edBehaviour.ed.Health;
            _health = _maxHealth;
            slider.value = CalculateHealth();
        }

        private void Update()
        {
            slider.value = CalculateHealth();

            if ( _health < _maxHealth ) healthBarUI.SetActive(true);

            if ( _health <= 0 ) healthBarUI.SetActive(false);
        }

        private float CalculateHealth()
        {
            _health = edBehaviour.ed.Health;
            return _health / _maxHealth;
        }
    }
}