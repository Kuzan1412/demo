package com.example.user.tablayout;

import android.support.design.widget.TabLayout;
import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {
    ViewPager vpDemo;
    TabLayout tblDemo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        run();


    }

    private void run() {
        vpDemo = findViewById(R.id.idviewPager);
        vpDemo.setAdapter(new PageAdapter(getSupportFragmentManager()));
        tblDemo = findViewById(R.id.idtabLayout);
        tblDemo.setupWithViewPager(vpDemo);
    }
}
