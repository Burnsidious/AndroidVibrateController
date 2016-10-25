using UnityEngine;
using System.Collections;

public class VibrateTest : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The number of millisecond to vibrate for")]
    private long millisecondsToVibrate = 1000;

    public void onVibrateTest()
    {
        VibrateController.vibrate(millisecondsToVibrate);
    }

    public void onVibratePatternTest()
    {
        long[] pattern = { 0, 500, 1000, 2500, 3000, 4000 };
        VibrateController.vibrate(pattern, -1);
    }

    public void onVibratePatternRepeatTest()
    {
        long[] pattern = { 500, 1000 };
        VibrateController.vibrate(pattern, 0);
    }

    public void onVibrateCancelTest()
    {
        VibrateController.cancel();
    }

}
