package com.example.user.hquanghuy;

import java.io.Serializable;

public class Product implements Serializable {
    private String Name;
    private String Code;
    private String Cost;
    private String Student;
    private int MSSV;
    private String Major;

    public String getStudent() {
        return Student;
    }

    public void setStudent(String student) {
        Student = student;
    }

    public int getMSSV() {
        return MSSV;
    }

    public void setMSSV(int MSSV) {
        this.MSSV = MSSV;
    }

    public String getMajor() {
        return Major;
    }

    public void setMajor(String major) {
        Major = major;
    }

    public Product(String name, String code, String cost, String student, int MSSV, String major) {
        Name = name;
        Code = code;
        Cost = cost;
        Student = student;
        this.MSSV = MSSV;
        Major = major;
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
