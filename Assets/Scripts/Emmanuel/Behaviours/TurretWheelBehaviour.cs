using Emmanuel.ScriptableObjects;
using Matthew;
using UnityEngine;
using UnityEngine.UI;

namespace Emmanuel.Behaviours
{
	public class TurretWheelBehaviour : MonoBehaviour
	{
		[SerializeField] private TurretDisplayDataList turretList;

		[SerializeField] private Image turretWheelMain;

		[SerializeField] private GameEvent onTurretSelected;

		private int turretListIndex;
	
		// Use this for initialization
		void Start ()
		{
			turretListIndex = 0;
			turretWheelMain.sprite = turretList.turretDisplaydatas[turretListIndex].turretIcon;
		}
	
		// Update is called once per frame
		void Update () 
		{
		
		}

		public void MoveUp()
		{
			if ( turretListIndex + 1 >= turretList.turretDisplaydatas.Count ) return;
			
			turretListIndex++;
			turretWheelMain.sprite = turretList.turretDisplaydatas[turretListIndex].turretIcon;
		}

		public void MoveDown()
		{
			if ( turretListIndex - 1 < 0 ) return;
			
			turretListIndex--;
			turretWheelMain.sprite = turretList.turretDisplaydatas[turretListIndex].turretIcon;
		}

		public void Select()
		{
			onTurretSelected.Raise(gameObject, turretList.turretDisplaydatas[turretListIndex].td);
		}
	}
}
