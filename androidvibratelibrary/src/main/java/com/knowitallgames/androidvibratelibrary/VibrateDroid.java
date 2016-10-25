package com.knowitallgames.androidvibratelibrary;

import android.app.Activity;
import android.os.Vibrator;
/**
 * Created on 10/24/2016.
 * Original Author : Jonathan Burnside
 */

public class VibrateDroid
{
    private Vibrator vibrator;

    public VibrateDroid(Activity _activity)
    {
        vibrator = (Vibrator) _activity.getSystemService(
                Activity.VIBRATOR_SERVICE);

    }

    // Discontinues current vibrations
    public void cancel()
    {
        vibrator.cancel();
    }

    // Check whether the hardware has a vibrator
    public boolean hasVibrator()
    {
        return vibrator.hasVibrator();
    }


    /// Vibrate constantly for the specified period of time.
    public void vibrate(long milliseconds)
    {
        vibrator.vibrate(milliseconds);
    }

    //    Vibrate with a given pattern.
    public void vibrate(long[] pattern, int repeat)
    {
        vibrator.vibrate(pattern, repeat);
    }
}
