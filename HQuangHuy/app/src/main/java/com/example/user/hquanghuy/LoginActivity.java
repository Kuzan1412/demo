package com.example.user.hquanghuy;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    EditText edtUser, edtPass;
    Button btnLog;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        run();
        btnLog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(onValidate())
                {
                    if (edtUser.getText().toString().equals("1706020029") && edtPass.getText().toString().equals("12345"))
                    {   //Toast
                        Toast.makeText(LoginActivity.this, "Successfully", Toast.LENGTH_LONG).show();
                        Intent intent = new Intent(LoginActivity.this, CustomLV.class);
                        startActivity(intent);
                    }
                    else
                        Toast.makeText(LoginActivity.this, "Error! User : 1706020029", Toast.LENGTH_LONG).show();
                }
            }
        });
    }

    private void run() {
        edtPass = findViewById(R.id.idedtPass);
        edtUser = findViewById(R.id.idedtUser);
        btnLog = findViewById(R.id.idbtnLog);
    }


    private boolean onValidate() {
        if (edtUser.getText().toString().length() < 1 )
        {
            edtUser.setError("Please, you must fill username");
            return false;
        }
        if(edtPass.getText().toString().length() < 1)
        {
            edtPass.setError("Please, you must fill password");
            return false;
        }

        return true;
    }

}