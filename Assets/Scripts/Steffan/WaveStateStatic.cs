using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
