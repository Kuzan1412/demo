package com.example.user.hquanghuy;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class EditDataActivity extends AppCompatActivity {

    EditText edtStudent, edtMSSV, edtMajor, edtName, edtCode, edtCost;


    String mStudent = "", mMajor = "", mName = "", mCode = "", mCost = "", mMSSV = "" ;
    Button btnSave, btnBack;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_data);
        run();

        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

        btnSave.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (CheckData())
                {
                    int id = CustomLV.arrSystem.get(CustomLV.arrSystem.size()-1).getMSSV()+1;
                    final Product product = new Product(mName, mCode, mCost, mStudent, id, mMajor);
                    CustomLV.arrSystem.add(product);
                    CustomLV.adapter.notifyDataSetChanged();
                    Toast.makeText(EditDataActivity.this, "Success", Toast.LENGTH_SHORT).show();
                    ClearData();
                }
                else
                {
                    Toast.makeText(EditDataActivity.this, "Failed and checked", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }

    private void ClearData()
    {
        edtCode.setText("");
        edtStudent.setText("");
        edtMSSV.setText("");
        edtMajor.setText("");
        edtName.setText("");
        edtCost.setText("");
    }

    private boolean CheckData()
    {
        mStudent = edtStudent.getText().toString();
        mMajor = edtMajor.getText().toString();
        mMSSV = edtMSSV.getText().toString();
        mName = edtName.getText().toString();
        mCode = edtCode.getText().toString();
        mCost = edtCost.getText().toString();
        if(mStudent.length() < 1 )
        {
            edtStudent.setError("Error! You must fill this field.");
            return false;
        }

        if(mCost.length() < 1)
        {
            edtCost.setError("Error! You must fill this field.");
            return false;
        }

        if(mCode.length() < 1 || mCode.length() > 6)
        {
            edtCode.setError("Error! You must fill this field.");
            return false;
        }

        if(String.valueOf(mMSSV).length() < 1 || String.valueOf(mMSSV).length() > 10)
        {
            edtMSSV.setError("Error! You must fill this field.");
            return false;
        }

        if(mMajor.length() < 1)
        {
            edtMajor.setError("Error! You must fill this field.");
            return false;
        }

        if(mName.length() < 1)
        {
            edtName.setError("Error! You must fill this field.");
            return false;
        }
        return true;
    }

    private void run() {
        edtCode = findViewById(R.id.ideditCode);
        edtName = findViewById(R.id.ideditName);
        edtCost = findViewById(R.id.ideditCost);
        edtStudent = findViewById(R.id.ideditStudent);
        edtMajor = findViewById(R.id.ideditMajor);
        edtMSSV = findViewById(R.id.ideditMSSV);
        btnBack = findViewById(R.id.idbtnBack);
        btnSave = findViewById(R.id.idbtnSave);
    }
}
