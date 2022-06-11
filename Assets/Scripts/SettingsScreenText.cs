using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsScreenText : MonoBehaviour
{
    public Text CurrentGlucoseText;
    public Text CurrentSensitivityText;
    public Text CurrentCarbText;

    public void Start()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SaveData.Instance.getGoalGlucose}";
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SaveData.Instance.getSensitivityIndex}";
        CurrentCarbText.text = $"Current Carb Control is: {SaveData.Instance.getCarbControl}";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void CurrentGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SaveData.Instance.getGoalGlucose}";
    }
    public void CurrentSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SaveData.Instance.getSensitivityIndex}";
    }
    public void CurrentCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {SaveData.Instance.getCarbControl}";
    }
}
