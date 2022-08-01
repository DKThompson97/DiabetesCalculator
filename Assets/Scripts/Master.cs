using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Master : MonoBehaviour
{
    [SerializeField]private float mCurrentGlucose = 0f;
    private float mCarbsToIngets = 0f;
    private float mGoalGlucose = 0f;
    private float mSensitivityFactor = 0f;
    private float mCarbControl = 0f;

    public TextMeshProUGUI clock; 
    
    public float getGoalGlucose { get { return mGoalGlucose; } set { mGoalGlucose = value; } }
    public float getSensitivityIndex { get { return mSensitivityFactor; } set { mSensitivityFactor = value; } }
    public float getCarbControl { get { return mCarbControl; } set { mCarbControl = value; } }
    public static Master Instance
    {
        get;
        private set;
    }



    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
    private void Update()
    {
        string time = System.DateTime.Now.ToString("hh:mm") ;
        clock.text = time;
    }


    // sets glucose input
    public void readInputGlucose(string s)
    {
      
        mCurrentGlucose = float.Parse(s);
        Calculator.Instance.getCurrentGlucose = mCurrentGlucose;
    }
   
    
    
    // sets carbs to ingest
    public void readInputCarbs(string s)
    {
        mCarbsToIngets = float.Parse(s);
        Calculator.Instance.getCarbsToIngest = mCarbsToIngets;
    }



    // sets Goal Glucose
    public void setGoalGlucose(string s)
    {
        Debug.Log(s);
        mGoalGlucose = float.Parse(s);
        //Calculator.Instance.getGoalGlucose = mGoalGlucose;
        SavePrefs.Instance.getGoalGlucose = mGoalGlucose;
        Debug.Log(mGoalGlucose.ToString());
       
    }



    // sets Sensitivity Factor
    public void SetSensitivityFactor(string s)
    {
        mSensitivityFactor = float.Parse(s);
        //Calculator.Instance.getSensitivityIndex = mSensitivityFactor;
        SavePrefs.Instance.getSensitivityIndex = mSensitivityFactor;
    }



    // sets Carb Control
    public void SetCarbControl(string s)
    {
        mCarbControl = float.Parse(s);
        //Calculator.Instance.getCarbControl = mCarbControl;
        SavePrefs.Instance.getCarbControl = mCarbControl;
    }
}
