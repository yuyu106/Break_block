using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data;

public class DataSet
{

    public SelectableData data;

    private static DataSet mInstance;

    public static DataSet Instance
    {
        get
        {
            if(mInstance == null)
            {
                mInstance = new DataSet();
            }
            return mInstance;
        }
    }


}
