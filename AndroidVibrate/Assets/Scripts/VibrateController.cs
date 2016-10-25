using UnityEngine;
using UnityEngine.UI;

public class VibrateController : MonoBehaviour
{
    private static VibrateController instance = null;
    private static VibrateControllerBase vibContInstance = null;

    void Awake()
    {
        instance = this;
    }

    /// <summary>
    /// Stops any running vibrations on the device
    /// </summary>
    static public void cancel()
    {
        Instance.cancel();
    }

    /// <summary>
    /// Check whether the hardware has a vibrator
    /// </summary>
    /// <returns>Returns true if a vibrator is detected on the device</returns>
    static public bool hasVibrator()
    {
        return Instance.hasVibrator();
    }

    /// <summary>
    /// Vibrates constantly for the specified period of time.
    /// </summary>
    /// <param name="milliseconds">The number of milliseconds to vibrate</param>
    static public void vibrate(long milliseconds)
    {
        Instance.vibrate(milliseconds);
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
    static public void vibrate(long[] pattern, int repeat)
    {
        Instance.vibrate(pattern, repeat);
    }

    public static VibrateControllerBase Instance
    {
        get
        {
            if (null == instance)
            {
                GameObject gObj = new GameObject("VibrateController");
                instance = gObj.AddComponent<VibrateController>();

//#if !UNITY_EDITOR
#if UNITY_ANDROID
                gObj = new GameObject("VibrateControllerAndroid");
                vibContInstance = gObj.AddComponent<VibrateControllerAndroid>();
#else
                gObj = new GameObject("VibrateControllerUnity");
                vibContInstance = gObj.AddComponent<VibrateControllerUnity>();
#endif
            }
            else
            {
                if (null == vibContInstance)
                {
//#if !UNITY_EDITOR
#if UNITY_ANDROID
                    vibContInstance = instance.gameObject.AddComponent<VibrateControllerAndroid>();
#else
                    vibContInstance = instance.gameObject.AddComponent<VibrateControllerUnity>();
#endif
                }
            }
            return vibContInstance;
        }
    }
}
