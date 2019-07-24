namespace Steffan
{
	/// <summary>
	/// This is a static class that dictates the current phase of the game. This allows behaviours to be
	/// limited to specific 
	/// </summary>
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
