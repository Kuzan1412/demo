package com.example.user.endexam;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class History extends AppCompatActivity {

    Table tableModel;
    int mStudentId;
    MySQLite sqLite;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_history);
        sqLite = new MySQLite(History.this);
        sqLite.OpenDB();
    }
}
