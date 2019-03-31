package com.example.user.tablayout;

import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentStatePagerAdapter;

public class PageAdapter extends FragmentStatePagerAdapter {
    Fragment1stActivity mFragment1;
    Fragment2ndActivity mFragment2;

    public PageAdapter(FragmentManager fm) {
        super(fm);
        mFragment1 = new Fragment1stActivity();
        mFragment2 = new Fragment2ndActivity();
    }

    @Override
    public Fragment getItem(int i) {
        if(i == 0)
        {
            return mFragment1;
        }
        else if(i == 1)
            {
                return mFragment2;
            }
        return null;
    }

    @Override
    public int getCount() {
        return 2;
    }

    @Nullable
    @Override
    public CharSequence getPageTitle(int position) {
        String title = "";
        switch (position){
            case 0:
                title = "One";
                break;
            case 1:
                title = "Two";
                break;
            case 2:
                title = "Three";
                break;
        }
        return title;

    }
}
