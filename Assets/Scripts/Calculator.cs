using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    // Glucose calculation variables
    private float CurrentGlucose = 0f;
    private float GoalGlucose = 0f;
    private float SensitivityIndex = 0f;
    private float TotalGlucose = 0f;

    // carb calculation variables
    private float CarbsToIngest = 0f;
    private float CarbControl = 0f;
    private float TotalCarb;

    // Total together 
    private float GaF = 0f;

    public GameObject totalValueText;

    // Get set for everything
    public float getCurrentGlucose { get { return CurrentGlucose; } set { CurrentGlucose = value; } }
    public float getGoalGlucose { get { return GoalGlucose; } set { GoalGlucose = value; } }
    public float getSensitivityIndex { get { return SensitivityIndex; } set { SensitivityIndex = value; } }
    public float getTotalGlucose { get { return TotalGlucose; } set { TotalGlucose = value; } }
    public float getCarbsToIngest { get { return CarbsToIngest; } set { CarbsToIngest = value; } }
    public float getCarbControl { get { return CarbControl; }set { CarbControl = value; } }
    public float getTotalCarb { get { return TotalCarb; } set { TotalCarb = value; } }
    public float getGaF { get { return GaF; }set { GaF = value; } }
    public static Calculator Instance
    {
        get;
        private set;
    }
    public void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        // test 
        GoalGlucose = 120f;
        SensitivityIndex = 200f;
        CarbControl = 60f;
    }
    // Rounding chart for rounding units. will change per person
    public float RoundUnits(float _input)
    {
        float temp = 0f;
        if (_input <= .29f)
        {
            temp = 0f;
        }
        if (_input >= .3f && _input <= .79f)
        {
            temp = .5f;
        }
        if (_input >= .8f  )
        {
            temp = 1.0f;
        }
        
        Debug.Log(temp.ToString());
        return temp;
        
    }

    // Glucose only Calculation
    public void CalculateGlucose ()
    {
        float temp = CurrentGlucose - GoalGlucose;
        temp = temp / SensitivityIndex;
        temp = RoundUnits(temp);
        TotalGlucose = temp;
        // test
        Debug.Log(TotalGlucose.ToString());
        totalValueText.GetComponent<Text>().text = $"You need {TotalGlucose} Units";
    }

    // Food calculation Only
    public void CalcuateFood ()
    {
        float temp = CarbsToIngest / CarbControl;
        temp = RoundUnits(temp);
        TotalCarb = temp;
        // test
        Debug.Log(TotalCarb.ToString());
    }

    // Food + Glucose Calculation
    public void CalculateBoth()
    {
        float tempG = 0f;
        float tempC = 0f;
        float total = 0f;
        tempG = CurrentGlucose - GoalGlucose;
        tempG = tempG / SensitivityIndex;
        tempC = CarbsToIngest / CarbControl;
        total = tempC + tempG;
        total = RoundUnits(total);
        GaF = total;
    }
}
