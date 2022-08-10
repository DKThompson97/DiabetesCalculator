using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsScreenText : MonoBehaviour
{
    public Text CurrentGlucoseText;
    public Text CurrentSensitivityText;
    public Text CurrentCarbText;
    public Text CurrentLunchGlucoseText;
    public Text CurrentLunchSensitivityText;
    public Text CurrentLunchCarbText;
    public Text CurrentAfternoonGlucoseText;
    public Text CurrentAfternoonSensitivityText;
    public Text CurrentAfternoonCarbText;
    private void Awake()
    {
        
    }

    public void Start()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    // change all settings text & morning text
    public void CurrentGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
    }
    public void CurrentSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
    }
    public void CurrentCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
    }
    //Lunch settings text
    public void CurrentLunchGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
    }
    public void CurrentLunchSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
    }
    public void CurrentLunchCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
    }
    // Afternoon settings text
    public void CurrentAfternoonGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
    }
    public void CurrentAfternoonSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
    }
    public void CurrentAfternoonCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
}
