package com.example.user.hquanghuy;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

public class DetailInformation extends AppCompatActivity {
    TextView txtdetailName, txtdetailCost, txtdetailCode;

    private void onGetIntent()
    {
        Intent intent = getIntent();
        Product information = (Product) intent.getSerializableExtra("Contact");
        txtdetailName.setText(information.Name);
        txtdetailCost.setText(information.getCost());
        txtdetailCode.setText(String.valueOf(information.getCode()));
    }
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detail_information);
        run();
        onGetIntent();
    }

    private void run() {
        txtdetailName = findViewById(R.id.idbuyName);
        txtdetailCost = findViewById(R.id.idbuyCost);
        txtdetailCode = findViewById(R.id.idbuyCode);
    }
}
