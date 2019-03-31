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
import android.widget.TextView;

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
    public View getView(final int position, View convertView, ViewGroup parent) {
        LayoutInflater inflater = (LayoutInflater) mycontext.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        convertView = inflater.inflate(mylayout, null);


        TextView txtName = (TextView) convertView.findViewById(R.id.iddetailName);
        txtName.setText(mylist.get(position).getName());

        TextView txtCode = (TextView) convertView.findViewById(R.id.iddetailCode);
        txtCode.setText(mylist.get(position).getCode());

        TextView txtCost = (TextView) convertView.findViewById(R.id.iddetailCost);
        txtCost.setText(String.valueOf(mylist.get(position).getCost()));


        final Product model = mylist.get(position);
        ImageView imageView = (ImageView) convertView.findViewById(R.id.idIV);
        imageView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                   Intent intent = new Intent(mycontext, DetailInformation.class);
                   intent.putExtra("POS", position);
                   intent.putExtra("Contact", model);
                   intent.putExtra("Update", model);
                   mycontext.startActivity(intent);
                    }

        });

        ImageView ivDelete = (ImageView) convertView.findViewById(R.id.idImgViewDelete);
        ivDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                CustomLV.arrSystem.remove(model);
                CustomLV.adapter.notifyDataSetChanged();
            }
        });

        return convertView;
    }
}
