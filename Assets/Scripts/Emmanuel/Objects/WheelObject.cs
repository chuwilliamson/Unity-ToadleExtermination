using Emmanuel.Interfaces;
using UnityEngine;

namespace Emmanuel.Objects
{
	public class WheelObject: IWheelObject
	{
		private int _currentIndex;

		WheelObject()
		{
			_currentIndex = 0;
		}
		
		public int Current { get { return _currentIndex; } }

		public void Up()
		{
			throw new System.NotImplementedException();
		}

		public void Down()
		{
			throw new System.NotImplementedException();
		}
	}
}
