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


public class ProductFragment extends Fragment {
    static CustomAdapter adapter;
    static ArrayList<Product> arrSystem;
    static ListView lvData;
    View mView;
    Button btnAdd;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        arrSystem = new ArrayList<Product>();

        arrSystem.add(new Product("CF3009", "Coffee Joy", "20000", "VND"));
        arrSystem.add(new Product("CF1999", "Coffee Moka", "50000", "VND"));
        arrSystem.add(new Product("CF0300", "Coffee Latte", "55000", "VND"));
        arrSystem.add(new Product("CF0031", "Coffee Cherry", "83000", "VND"));
        arrSystem.add(new Product("CF0199", "Coffee Arabica", "91000", "VND"));

        mView = inflater.inflate(R.layout.fragment_product, container, false);
        lvData = mView.findViewById(R.id.idLVProduct);

        adapter = new CustomAdapter(getContext(), R.layout.detail_lv, arrSystem);
        lvData.setAdapter(adapter);

        btnAdd = mView.findViewById(R.id.id_btn_ADD);
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getActivity().getApplication(), AddProduct.class);
                startActivity(intent);
            }
        });
        return mView;
    }

}