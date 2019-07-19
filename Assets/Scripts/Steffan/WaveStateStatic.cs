namespace Steffan
{
	public static class WaveStateStatic
	{
		private static bool isWavePhase;
		public static bool IsWavePhase
		{
			get { return isWavePhase; }
		}

		public static void ChangePhase()
		{
			isWavePhase = !isWavePhase;
		}
	
	}
}
