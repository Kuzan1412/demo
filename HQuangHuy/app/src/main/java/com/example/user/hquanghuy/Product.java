package com.example.user.hquanghuy;

import java.io.Serializable;

public class Product implements Serializable {
    public String Name;
    public String Code;
    public String Cost;

    public Product(String name, String code, String cost) {
        Name = name;
        Code = code;
        Cost = cost;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getCode() {
        return Code;
    }

    public void setCode(String code) {
        Code = code;
    }

    public String getCost() {
        return Cost;
    }

    public void setCost(String cost) {
        Cost = cost;
    }
}
