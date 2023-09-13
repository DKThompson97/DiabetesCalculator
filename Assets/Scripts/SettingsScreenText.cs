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
    public static SettingsScreenText Instance
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
    public void Start()
    {
        // sets all screen text based on saved data to correct numbers
        SettingsScreenText.Instance.CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        SettingsScreenText.Instance.CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        SettingsScreenText.Instance.CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        SettingsScreenText.Instance.CurrentMorningGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        SettingsScreenText.Instance.CurrentMorningSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        SettingsScreenText.Instance.CurrentMorningCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        SettingsScreenText.Instance.CurrentLunchGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
        SettingsScreenText.Instance.CurrentLunchSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
        SettingsScreenText.Instance.CurrentLunchCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
        SettingsScreenText.Instance.CurrentAfternoonGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
        SettingsScreenText.Instance.CurrentAfternoonSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
        SettingsScreenText.Instance.CurrentAfternoonCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
    #endregion

    #region Change All Text, Morning, Lunch and dinner. 
    // Used to change all screen text for morning lunch and dinner when the user, uses the change all screen to change all settings at once

    // Changes all glucose texts on all settings pages
    public void ChangeAllGText()
    {
        SettingsScreenText.Instance.CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        SettingsScreenText.Instance.CurrentMorningGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        SettingsScreenText.Instance.CurrentLunchGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
        SettingsScreenText.Instance.CurrentAfternoonGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
    }

    // Changes all Sensitivity indexs on all settings pages
    public void ChangeAllSText()
    {
        SettingsScreenText.Instance.CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        SettingsScreenText.Instance.CurrentMorningSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        SettingsScreenText.Instance.CurrentLunchSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
        SettingsScreenText.Instance.CurrentAfternoonSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
    }

    // Changes all Carb control text on all settings pages
    public void ChangeAllCText()
    {
        SettingsScreenText.Instance.CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        SettingsScreenText.Instance.CurrentMorningCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        SettingsScreenText.Instance.CurrentLunchCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
        SettingsScreenText.Instance.CurrentAfternoonCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
    #endregion

    #region Change morning and change all screen text to show morning values as default
    // change all settings text & morning text
    public void CurrentGText()
    {
        SettingsScreenText.Instance.CurrentGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";
        SettingsScreenText.Instance.CurrentMorningGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getGoalGlucose}";

    }
    public void CurrentSText()
    {
        SettingsScreenText.Instance.CurrentSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
        SettingsScreenText.Instance.CurrentMorningSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getSensitivityIndex}";
    }
    public void CurrentCText()
    {
        SettingsScreenText.Instance.CurrentCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
        SettingsScreenText.Instance.CurrentMorningCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getCarbControl}";
    }
    #endregion

    #region Change lunch screen text
    //Lunch settings text
    public void CurrentLunchGText()
    {
        SettingsScreenText.Instance.CurrentLunchGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getLGoalGlucose}";
    }
    public void CurrentLunchSText()
    {
        SettingsScreenText.Instance.CurrentLunchSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getLSensitivityIndex}";
    }
    public void CurrentLunchCText()
    {
        SettingsScreenText.Instance.CurrentLunchCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getLCarbControl}";
    }
    #endregion

    #region Change afternoon screen text
    // Afternoon settings text
    public void CurrentAfternoonGText()
    {
        SettingsScreenText.Instance.CurrentAfternoonGlucoseText.text = $"Current Goal Glucose is: {SavePrefs.Instance.getAGoalGlucose}";
    }
    public void CurrentAfternoonSText()
    {
        SettingsScreenText.Instance.CurrentAfternoonSensitivityText.text = $"Current Sensitivity Index is: {SavePrefs.Instance.getASensitivityIndex}";
    }
    public void CurrentAfternoonCText()
    {
        SettingsScreenText.Instance.CurrentAfternoonCarbText.text = $"Current Carb Control is: {SavePrefs.Instance.getACarbControl}";
    }
    #endregion
}
