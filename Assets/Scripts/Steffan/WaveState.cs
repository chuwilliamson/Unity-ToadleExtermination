namespace Steffan
{
	public static class WaveState
	{
		private static bool isBuildPhase;
		public static bool IsBuildPhase
		{
			get { return isBuildPhase; }
		}

		public static void ChangePhase()
		{
			isBuildPhase = !isBuildPhase;
		}
	
	}
}
