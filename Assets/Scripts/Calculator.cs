using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    // Variable for current Glucose
    private float CurrentGlucose = 0f;

    // Variable to hold final glucose calculation
    private float TotalGlucose = 0f;

    // Variable for carbs to eat
    private float CarbsToIngest = 0f;

    // Varibale for final card calculation
    private float TotalCarb = 0f;

    // Total together 
    private float GaF = 0f;

    // Text to replace text feild in calculator scene
    public Text totalValueText;

    // Get set for everything
    // Get Set for current Glucose
    public float getCurrentGlucose { get { return CurrentGlucose; } set { CurrentGlucose = value; } }
   
    // Get set for total glucose // Nedded??
    public float getTotalGlucose { get { return TotalGlucose; } set { TotalGlucose = value; } }

    // Get set for Carbs to ingest
    public float getCarbsToIngest { get { return CarbsToIngest; } set { CarbsToIngest = value; } }

   // Get set for final carb calc // Needed??
    public float getTotalCarb { get { return TotalCarb; } set { TotalCarb = value; } }

    // Get set for total together // Needed??
    public float getGaF { get { return GaF; }set { GaF = value; } }


    // Create instance of Calc class
    public static Calculator Instance
    {
        get;
        private set;
    }
    void Awake()
    {
        // Create instance of calc class
       if (Instance != null && Instance != this)
       {
           Destroy(this);
           return;
       }
       Instance = this;
        
    }
   
    // Rounding chart for rounding units. will change per person
    public float RoundUnits(float _input)
    {
        float temp = 0f;
        float temp2 = 0f;
        float temp3 = 0f;
        if (_input <= .29f)
        {
            temp = 0f;
        }
        if (_input >= .3f && _input <= .79f)
        {
            temp = .5f;
        }
        if (_input >= .8f && _input <= 1 )
        {
            temp = 1.0f;
        }
        if (_input > 1)
        {
            temp2 = (int)Math.Truncate(_input);
            Debug.Log(temp2.ToString());
            temp3 = _input - temp2;
            temp = RoundUnits(temp3);
            temp += temp2;
        }
        
        Debug.Log(temp.ToString());
        return temp;
        
    }

    // Glucose only Calculation
    public void CalculateGlucose ()
    {
        float temp = CurrentGlucose - SavePrefs.Instance.getGoalGlucose;
        temp = temp / SavePrefs.Instance.getSensitivityIndex;
        temp = RoundUnits(temp);
        TotalGlucose = temp;
        // test
        Debug.Log(TotalGlucose.ToString());
        totalValueText.text = $"You need {TotalGlucose} Units";
    }

    // Food calculation Only
    public void CalcuateFood ()
    {
        float temp = CarbsToIngest / SavePrefs.Instance.getCarbControl;
        temp = RoundUnits(temp);
        TotalCarb = temp;
        // test
        Debug.Log(TotalCarb.ToString());
        totalValueText.text = $"You need {TotalCarb} Units";
    }

    // Food + Glucose Calculation
    public void CalculateBoth()
    {
        float tempG = 0f;
        float tempC = 0f;
        float total = 0f;
        tempG = CurrentGlucose - SavePrefs.Instance.getGoalGlucose;
        tempG = tempG / SavePrefs.Instance.getSensitivityIndex;
        tempC = CarbsToIngest / SavePrefs.Instance.getCarbControl;
        total = tempC + tempG;
        total = RoundUnits(total);
        GaF = total;
        totalValueText.text = $"You need {GaF} Units";
    }
}
