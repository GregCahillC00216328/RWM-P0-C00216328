using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningTotalFilter:MonoBehaviour
{
    public float[] m_arr;
    public float[] result=new float[5];
    

    public void runningCalc(float[] t_arr)
    {
        m_arr = t_arr;
        result = new float[m_arr.Length];
        for (int i = 0; i < m_arr.Length; i++)
        {
            float numToAddTo = m_arr[i];
            if (i == 0)
            {
                result[i] = m_arr[i];
            }
            else
            {
                result[i] = m_arr[i] + result[i - 1];
            }


            print(result[i]);
            //runningCalc();
        }
    }

    


    
}
