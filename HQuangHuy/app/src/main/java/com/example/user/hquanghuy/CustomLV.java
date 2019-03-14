package com.example.user.hquanghuy;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class CustomLV extends AppCompatActivity {
    static ListView lvNew;
    static CustomAdapter adapter;
    static ArrayList<Product> arrSystem;
    TextView txtBack;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_custom_lv);
        run();
        arrSystem = new ArrayList<Product>();

        arrSystem.add(new Product( "SamsungGalaxy J6", "SSG11", "3959000" ));
        arrSystem.add(new Product( "SamsungGalaxy A7", "DCG008", "3205000" ));
        arrSystem.add(new Product( "Xiaomi Redmmi J6", "2TH127", "6900000" ));
        arrSystem.add(new Product( "Xiaomi Redmi Note 6", "1TH189", "2059000" ));
        adapter = new CustomAdapter(
                CustomLV.this, R.layout.detail, arrSystem);
        lvNew.setAdapter(adapter);
        txtBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }

    private void run() {
        lvNew = findViewById(R.id.idLV);
        txtBack = findViewById(R.id.idbtnBack);
    }
}
