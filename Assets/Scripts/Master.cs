using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Master : MonoBehaviour
{
    #region Variables
    [SerializeField] private float mCurrentGlucose = 0f;
    [SerializeField] private float mCarbsToIngets = 0f;
    // Main settings
    [SerializeField] private float mGoalGlucose = 0f;
    [SerializeField] private float mSensitivityFactor = 0f;
    [SerializeField] private float mCarbControl = 0f;
    // Morning settings data
    [SerializeField] private float morningGoalGlucose = 0f;
    [SerializeField] private float morningSensitivityFactor = 0f;
    [SerializeField] private float morningCarbControl = 0f;
    // lunchtime settings data
    [SerializeField] private float lunchGoalGlucose = 0f;
    [SerializeField] private float lunchSensitivityFactor = 0f;
    [SerializeField] private float lunchCarbControl = 0f;
    // af6ternoon settings data
    [SerializeField] private float afternoonGoalGlucose = 0f;
    [SerializeField] private float afternoonSensitivityFactor = 0f;
    [SerializeField] private float afternoonCarbControl = 0f;


    // creates a text mesh pro to view live system time
    public TextMeshProUGUI clock;
    #endregion

    #region Get Set methods
    // getter setter for the three rotating variables that will hold user settings for the correct time of day
    public float getGoalGlucose { get { return mGoalGlucose; } set { mGoalGlucose = value; } }
    public float getSensitivityIndex { get { return mSensitivityFactor; } set { mSensitivityFactor = value; } }
    public float getCarbControl { get { return mCarbControl; } set { mCarbControl = value; } }

    // getter for instance of master class
    public static Master Instance
    {
        get;
        private set;
    }
    #endregion

    #region Unity Methods 
    private void Start()
    {
        //uploads all saved settings to master from saved prefs
        morningGoalGlucose = SavePrefs.Instance.getGoalGlucose;
        morningSensitivityFactor = SavePrefs.Instance.getSensitivityIndex;
        morningCarbControl = SavePrefs.Instance.getCarbControl;
        lunchGoalGlucose = SavePrefs.Instance.getLGoalGlucose;
        lunchSensitivityFactor = SavePrefs.Instance.getLSensitivityIndex;
        lunchCarbControl = SavePrefs.Instance.getLCarbControl;
        afternoonGoalGlucose = SavePrefs.Instance.getAGoalGlucose;
        afternoonSensitivityFactor = SavePrefs.Instance.getASensitivityIndex;
        afternoonCarbControl = SavePrefs.Instance.getACarbControl;
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
        DateTime morning = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 01, 01, 00);
        DateTime lunch = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 01, 00);
        DateTime afternoon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 01, 00);

        DateTime time = System.DateTime.Now;
        clock.text = time.ToString("hh:mm");
        if (time.CompareTo(morning) == 1 && time.CompareTo(lunch) == -1)
        {
            mGoalGlucose = morningGoalGlucose;
            mSensitivityFactor = morningSensitivityFactor;
            mCarbControl = morningCarbControl;
            //Debug.Log("using morning valuse");  // For testing
        }
        if (time.CompareTo(lunch) == 1 && time.CompareTo(morning) == 1 && time.CompareTo(afternoon) == -1)
        {
            mGoalGlucose = lunchGoalGlucose;
            mSensitivityFactor = lunchSensitivityFactor;
            mCarbControl = lunchCarbControl;
            //Debug.Log("using lunch valuse"); // For testing
        }
        if (time.CompareTo(afternoon) == 1 && time.CompareTo(morning) == 1 && time.CompareTo(lunch) == 1)
        {
            mGoalGlucose = afternoonGoalGlucose;
            mSensitivityFactor = afternoonSensitivityFactor;
            mCarbControl = afternoonCarbControl;
            //Debug.Log("using afternoon valuse"); // For testing
        }
    }
    #endregion

    #region Functions for reading user input on calculator screen
    // sets glucose input
    public void readInputGlucose(string s)
    {
      // sets current glucose in master and calculator scripts
        mCurrentGlucose = float.Parse(s);
        Calculator.Instance.getCurrentGlucose = mCurrentGlucose;
    }
    
    
    // sets carbs to ingest
    public void readInputCarbs(string s)
    {
        // sets carbs to ingest in master and calculator scripts
        mCarbsToIngets = float.Parse(s);
        Calculator.Instance.getCarbsToIngest = mCarbsToIngets;
    }
    #endregion

    #region Glucose setting functions
    // sets All Goal Glucoses
    public void setAllGoalGlucose(string s)
    {
        morningGoalGlucose = float.Parse(s);
        lunchGoalGlucose = float.Parse (s);
        afternoonGoalGlucose = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getGoalGlucose = morningGoalGlucose;
        SavePrefs.Instance.getLGoalGlucose = lunchGoalGlucose;
        SavePrefs.Instance.getAGoalGlucose = afternoonGoalGlucose;
    }

    // Sets morning goal glucose
    public void setMorningGoalGlucose(string s)
    {
        morningGoalGlucose = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getGoalGlucose = morningGoalGlucose;
    }

    // Sets lunch goal glucose
    public void setLunchGoalGlucose(string s)
    {
        lunchGoalGlucose = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getLGoalGlucose = lunchGoalGlucose;
    }

    // Sets Afternoon goal glucose
    public void setAfternoonGoalGlucose(string s)
    {
        afternoonGoalGlucose = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getAGoalGlucose = afternoonGoalGlucose;
    }
    #endregion

    #region Sensitivity Factor setting functions
    // sets all Sensitivity Factor
    public void SetAllSensitivityFactor(string s)
    {
        morningSensitivityFactor = float.Parse(s);
        lunchSensitivityFactor = float.Parse(s);
        afternoonSensitivityFactor = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getSensitivityIndex = morningSensitivityFactor;
        SavePrefs.Instance.getLSensitivityIndex = lunchSensitivityFactor;
        SavePrefs.Instance.getASensitivityIndex = afternoonSensitivityFactor;
    }

    // Sets Morning Sensitivity Factor
    public void SetmorningSensitivityFactor(string s)
    {
        morningSensitivityFactor = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getSensitivityIndex = morningSensitivityFactor;
    }

    // Sets lunch Sensitivity Factor
    public void SetLunchSensitivityFactor(string s)
    {
        lunchSensitivityFactor = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getLSensitivityIndex = lunchSensitivityFactor;
    }

    // Sets afternoon Sensitivity Factor
    public void SetAfternoonSensitivityFactor(string s)
    {
        afternoonSensitivityFactor = float.Parse(s);
        // saves new settings
        SavePrefs.Instance.getASensitivityIndex = afternoonSensitivityFactor;
    }
    #endregion

    #region Carb Control Setting functions
    // sets all Carb Control
    public void SetAllCarbControl(string s)
    {
        morningCarbControl = float.Parse(s);
        lunchCarbControl = float.Parse(s);
        afternoonCarbControl = float.Parse(s);
        // Saves new settings
        SavePrefs.Instance.getCarbControl = morningCarbControl;
        SavePrefs.Instance.getLCarbControl = lunchCarbControl;
        SavePrefs.Instance.getACarbControl = afternoonCarbControl;
    }

    // Sets morning Carb Control
    public void SetMorningCarbControl(string s)
    {
        morningCarbControl = float.Parse(s);
        // Saves new settings
        SavePrefs.Instance.getCarbControl = morningCarbControl;
    }

    // Sets lunch Carb Control
    public void SetLunchCarbControl(string s)
    {
        lunchCarbControl = float.Parse(s);
        // Saves new settings
        SavePrefs.Instance.getLCarbControl = lunchCarbControl;
    }

    // Sets afternoon Carb Control'
    public void SetAfternoonCarbControl(string s)
    {
        afternoonCarbControl = float.Parse(s);
        // Saves new settings
        SavePrefs.Instance.getACarbControl = afternoonCarbControl;
    }
    #endregion

}
