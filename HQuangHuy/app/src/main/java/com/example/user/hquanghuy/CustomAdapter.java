package com.example.user.hquanghuy;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;

import java.util.List;

public class CustomAdapter  extends BaseAdapter {
    Context mycontext;
    int mylayout;
    List<Product> mylist;

    public CustomAdapter(Context mycontext, int mylayout, List<Product> mylist) {
        this.mycontext = mycontext;
        this.mylayout = mylayout;
        this.mylist = mylist;
    }


    @Override
    public int getCount() {
        return mylist.size();
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        LayoutInflater inflater = (LayoutInflater) mycontext.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        convertView = inflater.inflate(mylayout, null);


        EditText edtName = (EditText) convertView.findViewById(R.id.iddetailName);
        edtName.setText(mylist.get(position).Name);

        EditText edtCode = (EditText) convertView.findViewById(R.id.iddetailCode);
        edtCode.setText(mylist.get(position).Code);

        EditText edtCost = (EditText) convertView.findViewById(R.id.iddetailCost);
        edtCost.setText(String.valueOf(mylist.get(position).Cost));

        final Product model = mylist.get(position);
        ImageView imageView = (ImageView) convertView.findViewById(R.id.idIV);
        imageView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                   Intent intent = new Intent(mycontext, DetailInformation.class);
                        intent.putExtra("Contact", model);
                        mycontext.startActivity(intent);
                    }

        });
        LinearLayout linearLayout = (LinearLayout) convertView.findViewById(R.id.Layout);
        linearLayout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(mycontext, DetailInformation.class);
                intent.putExtra("Contact", model);
                mycontext.startActivity(intent);
            }
        });



        return convertView;
    }
}
