using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An speed up effect utils
/// </summary>
public static class EffectUtils
{
	/// <summary>
    /// Gets whether or not the speedup effect is active
    /// </summary>
	public static bool SpeedupEffectActive
	{
		get { return GetSpeedupEffectMonitor().SpeedupEffectActive; }
	}

	/// <summary>
    /// Gets how many seconds are left in the speedup effect
    /// </summary>
	public static float SpeedupEffectSecondsLeft
	{
		get { return GetSpeedupEffectMonitor().SpeedupEffectSecondsLeft; }
	}

	/// <summary>
    /// Gets the speedup factor for the speedup effect
    /// </summary>
	public static float SpeedupValue
	{
		get {return GetSpeedupEffectMonitor().SpeedupValue; }
	}

	/// <summary>
    /// Gets the SpeedupEffectMonitor attached to the main camera
    /// </summary>
	static SpeedupEffectMonitor GetSpeedupEffectMonitor()
	{
		return Camera.main.GetComponent<SpeedupEffectMonitor>();
	}
}
