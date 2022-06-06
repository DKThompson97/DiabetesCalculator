using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsScreenText : MonoBehaviour
{
    public Text CurrentGlucoseText;
    public Text CurrentSensitivityText;
    public Text CurrentCarbText;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void CurrentGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {Master.Instance.getGoalGlucose}";
    }
    public void CurrentSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {Master.Instance.getSensitivityIndex}";
    }
    public void CurrentCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {Master.Instance.getCarbControl}";
    }
}
