package com.example.user.hquanghuy;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;

public class DetailInformation extends AppCompatActivity {
    EditText edtdetailName, edtdetailCost, edtdetailCode;

    private void onGetIntent()
    {
        Intent intent = getIntent();
        Product information = (Product) intent.getSerializableExtra("Contact");
        edtdetailName.setText(information.Name);
        edtdetailCost.setText(information.getCost());
        edtdetailCode.setText(String.valueOf(information.getCode()));
    }
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detail_information);
        run();
        onGetIntent();
    }

    private void run() {
        edtdetailName = findViewById(R.id.idbuyName);
        edtdetailCost = findViewById(R.id.idbuyCost);
        edtdetailCode = findViewById(R.id.idbuyCode);
    }
}
