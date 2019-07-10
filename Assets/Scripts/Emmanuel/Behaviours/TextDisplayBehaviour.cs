using Steffan.Behaviours;
using UnityEngine;
using UnityEngine.UI;

namespace Emmanuel.Behaviours
{
    public class TextDisplayBehaviour : MonoBehaviour
    {
        public PlayerDataBehaviour pdBehavoiur;
        public Text textObject;

        // Use this for initialization
        private void Start()
        {
            textObject.text = pdBehavoiur.pd.Currency.ToString();
        }

        // Update is called once per frame
        private void Update()
        {
            textObject.text = pdBehavoiur.pd.Currency.ToString();
        }
    }
}