package com.example.user.hquanghuy;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class CustomLV extends AppCompatActivity {
    static ListView lvNew;
    static CustomAdapter adapter;
    static ArrayList<Product> arrSystem;
    TextView txtBack;
    Button btnAdd;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_custom_lv);
        run();
        arrSystem = new ArrayList<Product>();

        arrSystem.add(new Product( "SamsungGalaxy J6", "SSG11", "3959000 VND", "Hooe", 12903087, "IT" ));
        arrSystem.add(new Product( "SamsungGalaxy A7", "DCG008", "3205000 VND", "Raito", 1601002243, "English" ));
        arrSystem.add(new Product( "Xiaomi Redmmi J6", "2TH127", "6900000 VND", "Misakai", 1703020011, "Bussiness Manage" ));
        arrSystem.add(new Product( "Xiaomi Redmi Note 6", "1TH189", "2059000 VND", "Yuuto", 1706020001, "IT" ));
        adapter = new CustomAdapter(
                CustomLV.this, R.layout.detail, arrSystem);
        lvNew.setAdapter(adapter);
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(CustomLV.this, EditDataActivity.class);
                startActivity(intent);
            }
        });

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
        btnAdd = findViewById(R.id.idbtnAdd);
    }
}
