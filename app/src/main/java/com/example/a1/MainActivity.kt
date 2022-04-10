package com.example.a1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MainActivity : AppCompatActivity() {
    private Button mYesButton;
    private Button mNoButton;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        mYesButton = (Button) findViewById(R.id.button_yes);
        mYesButton.setOnClickListener(new )
        mNoButton = (Button) findViewById(R.id.button_no);
    }
}