package com.example.user.hquanghuy;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class DetailInformation extends AppCompatActivity {
    EditText edtdetailName, edtdetailCost, edtdetailCode, edtdetailStudent, edtdetailMSSV, edtdetailMajor;
    int mMSSV;
    String mStudent = "", mMajor = "", mName = "", mCode = "", mCost = "";
    Button btnUpdate;
    int positon = 0;
    private void onGetIntent()
    {
        Intent intent = getIntent();
        positon = intent.getIntExtra("POS", 0);
        Product information = (Product) intent.getSerializableExtra("Update");
        edtdetailStudent.setText(information.getStudent());
        edtdetailMSSV.setText(String.valueOf(information.getMSSV()));
        edtdetailMajor.setText(String.valueOf(information.getMajor()));
        edtdetailName.setText(information.getName());
        edtdetailCost.setText(information.getCost());
        edtdetailCode.setText(String.valueOf(information.getCode()));
    }


    private Product ValidateForm()
    {
        mStudent = edtdetailStudent.getText().toString();
        mMajor = edtdetailMajor.getText().toString();
        mMSSV = Integer.parseInt(edtdetailMSSV.getText().toString());
        mName = edtdetailName.getText().toString();
        mCode = edtdetailCode.getText().toString();
        mCost = edtdetailCost.getText().toString();
        if(mStudent.length() < 1 )
        {
            edtdetailStudent.setError("Error! You must fill this field.");
            return null;
        }

        if(mCost.length() < 1)
        {
            edtdetailCost.setError("Error! You must fill this field.");
            return null;
        }

        if(mCode.length() < 1 || mCode.length() > 6)
        {
            edtdetailCode.setError("Error! You must fill this field.");
            return null;
        }

        if(String.valueOf(mMSSV).length() < 1 || String.valueOf(mMSSV).length() > 10)
        {
            edtdetailMSSV.setError("Error! You must fill this field.");
            return null;
        }

        if(mMajor.length() < 1)
        {
            edtdetailMajor.setError("Error! You must fill this field.");
            return null;
        }

        if(mName.length() < 1)
        {
            edtdetailName.setError("Error! You must fill this field.");
            return null;
        }
        Product item = new  Product(mName, mCode, mCost, mStudent, mMSSV, mMajor);
        return item;
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detail_information);
        run();
        onGetIntent();
        btnUpdate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Product item = ValidateForm();
                if(item != null)
                {
                    CustomLV.arrSystem.remove(positon);
                    CustomLV.arrSystem.add(positon, item);
                    CustomLV.adapter.notifyDataSetChanged();
                    finish();
                }
            }
        });
    }

    private void run() {
        edtdetailName = findViewById(R.id.idbuyName);
        edtdetailCost = findViewById(R.id.idbuyCost);
        edtdetailCode = findViewById(R.id.idbuyCode);
        edtdetailMajor = findViewById(R.id.iddetailMajor);
        edtdetailMSSV = findViewById(R.id.iddetailMSSV);
        edtdetailStudent = findViewById(R.id.iddetailStudent);
        btnUpdate = findViewById(R.id.idbtnUpdate);
    }
}
