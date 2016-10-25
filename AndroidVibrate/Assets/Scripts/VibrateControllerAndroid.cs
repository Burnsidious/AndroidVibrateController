using UnityEngine;

public class VibrateControllerAndroid : VibrateControllerBase
{
    /// <summary>
    /// The object used to make calls into the Android API plugin library
    /// </summary>
    private AndroidJavaObject androidObject;

    void Awake()
    {
        Debug.Log("Got to Android Awake()");
        AndroidJavaClass unityPlayer = new AndroidJavaClass(
            "com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>(
            "currentActivity");

        androidObject = new AndroidJavaObject(
            "com.knowitallgames.androidvibratelibrary.VibrateDroid",
            currentActivity);
    }

    /// <summary>
    /// Stops any running vibrations on the device
    /// </summary>
    override public void cancel()
    {
        androidObject.Call("cancel");
    }

    /// <summary>
    /// Check whether the hardware has a vibrator
    /// </summary>
    /// <returns>Returns true if a vibrator is detected on the device</returns>
    override public bool hasVibrator()
    {
        return androidObject.Call<bool>("hasVibrate");
    }

    /// <summary>
    /// Vibrates constantly for the specified period of time.
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    override public void vibrate(long milliseconds)
    {
        androidObject.Call("vibrate", milliseconds);
    }

    /// <summary>
    /// Vibrate with a given pattern.
    /// From Android API documentation : 
    /// https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long)
    /// Pass in an array of ints that are the durations for which to turn on or off the vibrator 
    /// in milliseconds. The first value indicates the number of milliseconds to wait before 
    /// turning the vibrator on. The next value indicates the number of milliseconds for which 
    /// to keep the vibrator on before turning it off. Subsequent values alternate between 
    /// durations in milliseconds to turn the vibrator off or to turn the vibrator on.
    /// 
    /// To cause the pattern to repeat, pass the index into the pattern array at which to start 
    /// the repeat, or -1 to disable repeating.
    /// </summary>
    /// <param name="pattern">an array of longs of times for which to turn the vibrator on or off.
    /// </param>
    /// <param name="repeat">the index into pattern at which to repeat, or -1 if you don't want to 
    /// repeat.</param>
    override public void vibrate(long[] pattern, int repeat)
    {
        androidObject.Call("vibrate", pattern, repeat);
    }
}
