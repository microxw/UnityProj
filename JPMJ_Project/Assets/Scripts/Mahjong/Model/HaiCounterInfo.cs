﻿
public class HaiCounterInfo
{
    public int numKind = 0;
    public int count = 0;

    public HaiCounterInfo()
    {

    }
    public HaiCounterInfo(int numKind, int count)
    {
        this.numKind = numKind;
        this.count = count;
    }

    public void reset()
    {
        numKind = 0;
        count = 0;
    }
}
