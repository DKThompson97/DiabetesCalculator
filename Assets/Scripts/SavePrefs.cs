using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{   // Morning
    [SerializeField] float SaveGoalGlucose;
    [SerializeField] float SaveSensitivityIndex;
    [SerializeField] float SaveCarbControl;
    //Lunch
    [SerializeField] float SaveLGoalGlucose;
    [SerializeField] float SaveLSensitivityIndex;
    [SerializeField] float SaveLCarbControl;
    //Afternoon
    [SerializeField] float SaveAGoalGlucose;
    [SerializeField] float SaveASensitivityIndex;
    [SerializeField] float SaveACarbControl;
    //string SaveUserName = "";


    // Morning
    public float getGoalGlucose { get { return SaveGoalGlucose; } set { SaveGoalGlucose = value; } }
    public float getSensitivityIndex { get { return SaveSensitivityIndex; } set { SaveSensitivityIndex = value; } }
    public float getCarbControl { get { return SaveCarbControl; } set { SaveCarbControl = value; } }

    // Lunch
    public float getLGoalGlucose { get { return SaveLGoalGlucose; } set { SaveLGoalGlucose = value; } }
    public float getLSensitivityIndex { get { return SaveLSensitivityIndex; } set { SaveLSensitivityIndex = value; } }
    public float getLCarbControl { get { return SaveLCarbControl; } set { SaveLCarbControl = value; } }

    // Afternoon
    public float getAGoalGlucose { get { return SaveAGoalGlucose; } set { SaveAGoalGlucose = value; } }
    public float getASensitivityIndex { get { return SaveASensitivityIndex; } set { SaveASensitivityIndex = value; } }
    public float getACarbControl { get { return SaveACarbControl; } set { SaveACarbControl = value; } }
    public static SavePrefs Instance;
    void Awake()
    {
        if (Instance == null)
        {
            LoadPreferences();
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void OnApplicationQuit()
    {
        SavePreferences();
    }
    public void OnApplicationPause(bool pause)
    {
        SavePreferences();
    }
    public void OnApplicationFocus(bool focus)
    {
        if (focus == false)
        {
            SavePreferences();
        }
    }
    public void SavePreferences()
    {
        // Morning
        PlayerPrefs.SetFloat("SavedGoalGlucose", SaveGoalGlucose);
        PlayerPrefs.SetFloat("SavedSensitivityIndex", SaveSensitivityIndex);
        PlayerPrefs.SetFloat("SavedCarbControl", SaveCarbControl);
        // Lunch
        PlayerPrefs.SetFloat("SavedLGoalGlucose", SaveLGoalGlucose);
        PlayerPrefs.SetFloat("SavedLSensitivityIndex", SaveLSensitivityIndex);
        PlayerPrefs.SetFloat("SavedLCarbControl", SaveLCarbControl);
        //Afternoon
        PlayerPrefs.SetFloat("SavedAGoalGlucose", SaveAGoalGlucose);
        PlayerPrefs.SetFloat("SavedASensitivityIndex", SaveASensitivityIndex);
        PlayerPrefs.SetFloat("SavedACarbControl", SaveACarbControl);


        //PlayerPrefs.SetString("UserName", SaveUserName);
        PlayerPrefs.Save();
    }

    public void LoadPreferences()
    {
        if (PlayerPrefs.HasKey("SavedGoalGlucose"))
        {
            // Morning
            SaveGoalGlucose = PlayerPrefs.GetFloat("SavedGoalGlucose");
            SaveSensitivityIndex = PlayerPrefs.GetFloat("SavedSensitivityIndex");
            SaveCarbControl = PlayerPrefs.GetFloat("SavedCarbControl");
            // Lunch
            SaveLGoalGlucose = PlayerPrefs.GetFloat("SavedLGoalGlucose");
            SaveLSensitivityIndex = PlayerPrefs.GetFloat("SavedLSensitivityIndex");
            SaveLCarbControl = PlayerPrefs.GetFloat("SavedLCarbControl");
            // Afternoon
            SaveAGoalGlucose = PlayerPrefs.GetFloat("SavedAGoalGlucose");
            SaveASensitivityIndex = PlayerPrefs.GetFloat("SavedASensitivityIndex");
            SaveACarbControl = PlayerPrefs.GetFloat("SavedACarbControl");


            //SaveUserName = PlayerPrefs.GetString("UserName");

        }
        else
        {
            Debug.LogError("There was an Error No saved Data");
            // set defaults if no data?
            SaveGoalGlucose = 120f;
            SaveSensitivityIndex = 200f;
            SaveCarbControl = 60f;
            // Lunch
            SaveLGoalGlucose = 120f;
            SaveLSensitivityIndex = 200f;
            SaveLCarbControl = 60f;
            // Afternoon
            SaveAGoalGlucose = 120f;
            SaveASensitivityIndex = 200f;
            SaveACarbControl = 60f;
        }
    }

    public void ResetPreferences()
    {
        PlayerPrefs.DeleteAll();
        SaveGoalGlucose = 0f;
        SaveSensitivityIndex = 0f;
        SaveCarbControl = 0f;
        //SaveUserName = "User";
    }
}
