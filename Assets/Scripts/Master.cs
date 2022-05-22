using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    private float mCurrentGlucose = 0f;
    private float mCarbsToIngets = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void readInputGlucose(string s)
    {
        mCurrentGlucose = float.Parse(s);
        Calculator.Instance.getCurrentGlucose = mCurrentGlucose;
        //test
        Debug.Log(mCurrentGlucose.ToString());
    }
    public void readInputCarbs(string s)
    {
        mCarbsToIngets = float.Parse(s);
        Calculator.Instance.getCarbsToIngest = mCarbsToIngets;
        //test
        Debug.Log(mCarbsToIngets.ToString());
    }
    // change answer text
    }
