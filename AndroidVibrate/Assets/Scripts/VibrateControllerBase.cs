
using UnityEngine;

abstract public class VibrateControllerBase : MonoBehaviour
{
    abstract public void cancel();

    // Check whether the hardware has a vibrator
    abstract public bool hasVibrator();

    /// Vibrate constantly for the specified period of time.
    abstract public void vibrate(long milliseconds);

    //    Vibrate with a given pattern.
    abstract public void vibrate(long[] pattern, int repeat);
}
