package com.knowitallgames.androidvibratecontroller;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

import com.knowitallgames.androidvibratelibrary.VibrateDroid;

public class AndroidVibrateTestActivity extends AppCompatActivity implements OnClickListener
{
    VibrateDroid vibDroid;
    Button testButton;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_android_vibrate_test);

        vibDroid = new VibrateDroid(this);

        testButton = (Button)findViewById(R.id.button2);
        testButton.setOnClickListener(this);

    }

    @Override
    public void onClick(View view)
    {
        vibDroid.vibrate(1000);
    }
}
