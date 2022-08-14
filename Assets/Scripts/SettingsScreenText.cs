using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsScreenText : MonoBehaviour
{
    #region Variables 
    public Text CurrentGlucoseText;
    public Text CurrentSensitivityText;
    public Text CurrentCarbText;
    public Text CurrentMorningGlucoseText;
    public Text CurrentMorningSensitivityText;
    public Text CurrentMorningCarbText;
    public Text CurrentLunchGlucoseText;
    public Text CurrentLunchSensitivityText;
    public Text CurrentLunchCarbText;
    public Text CurrentAfternoonGlucoseText;
    public Text CurrentAfternoonSensitivityText;
    public Text CurrentAfternoonCarbText;
    #endregion

    #region Unity Methods
    public void Start()
    {
        // sets all screen text based on saved data to correct numbers
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        CurrentMorningGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        CurrentMorningSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        CurrentMorningCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        CurrentLunchGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
        CurrentLunchSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
        CurrentLunchCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
        CurrentAfternoonGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
        CurrentAfternoonSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
        CurrentAfternoonCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
    #endregion

    #region Change All Text, Morning, Lunch and dinner. 
    // Used to change all screen text for morning lunch and dinner when the user, uses the change all screen to change all settings at once

    // Changes all glucose texts on all settings pages
    public void ChangeAllGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        CurrentMorningGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        CurrentLunchGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
        CurrentAfternoonGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
    }

    // Changes all Sensitivity indexs on all settings pages
    public void ChangeAllSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        CurrentMorningSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        CurrentLunchSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
        CurrentAfternoonSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
    }

    // Changes all Carb control text on all settings pages
    public void ChangeAllCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        CurrentMorningCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        CurrentLunchCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
        CurrentAfternoonCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
    #endregion

    #region Change morning and change all screen text to show morning values as default
    // change all settings text & morning text
    public void CurrentGText()
    {
        CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        CurrentMorningGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";

    }
    public void CurrentSText()
    {
        CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        CurrentMorningSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
    }
    public void CurrentCText()
    {
        CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        CurrentMorningCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
    }
    #endregion

    #region Change lunch screen text
    //Lunch settings text
    public void CurrentLunchGText()
    {
        CurrentLunchGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
    }
    public void CurrentLunchSText()
    {
        CurrentLunchSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
    }
    public void CurrentLunchCText()
    {
        CurrentLunchCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
    }
    #endregion

    #region Change afternoon screen text
    // Afternoon settings text
    public void CurrentAfternoonGText()
    {
        CurrentAfternoonGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
    }
    public void CurrentAfternoonSText()
    {
        CurrentAfternoonSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
    }
    public void CurrentAfternoonCText()
    {
        CurrentAfternoonCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
    #endregion
}
