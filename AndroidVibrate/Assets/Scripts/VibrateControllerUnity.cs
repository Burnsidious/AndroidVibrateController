using UnityEngine;

public class VibrateControllerUnity : VibrateControllerBase
{
    /// <summary>
    /// Stub method without functionality
    /// </summary>
    override public void cancel()
    {

    }

    /// <summary>
    /// Check whether the hardware has a vibrator
    /// This is a stub method for handling these calls from 
    /// unity editor where a vibrator is unexpected
    /// </summary>
    /// <returns>Always returns false</returns>
    override public bool hasVibrator()
    {
        return false;
    }

    /// <summary>
    /// Stub method without functionality
    /// </summary>
    /// <param name="milliseconds">ignored</param>
    override public void vibrate(long milliseconds)
    {

    }

    /// <summary>
    /// Vibrate with a given pattern.
    /// </summary>
    /// <param name="pattern">ignored</param>
    /// <param name="repeat">ignored</param>
    override public void vibrate(long[] pattern, int repeat)
    {

    }
}
