package com.example.user.endexam;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ListView;

import java.util.ArrayList;


public class TableFragment extends Fragment {
    static CustomAdapterTable adaptertab;
    static ArrayList<Table> arrTab;
    static ListView lvTab;
    Button btnCreate;
    View mView;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        arrTab = new ArrayList<Table>();

        mView = inflater.inflate(R.layout.fragment_table, container, false);
        lvTab = mView.findViewById(R.id.idLvTable);

        adaptertab = new CustomAdapterTable(getContext(), R.layout.detail_lv_table, arrTab);
        lvTab.setAdapter(adaptertab);

        btnCreate = mView.findViewById(R.id.id_btn_CREATE);
        btnCreate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(getActivity().getApplication(), CreateTable.class);
                startActivity(intent);
            }
        });

        return mView;
    }


}
