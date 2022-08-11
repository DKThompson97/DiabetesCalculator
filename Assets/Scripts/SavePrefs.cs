using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    #region Variables
    // Morning
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
    #endregion

    #region Get Set for variables
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
    #endregion

    #region Unity Methods 

    public static SavePrefs Instance;

    // creates an instance of the SavePrefs class and allows it not to be destroyed
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

    // saves new settings on quit
    public void OnApplicationQuit()
    {
        SavePreferences();
    }

    // saves new settings on pause
    public void OnApplicationPause(bool pause)
    {
        SavePreferences();
    }

    // saves new settings on focus
    public void OnApplicationFocus(bool focus)
    {
        if (focus == false)
        {
            SavePreferences();
        }
    }
    #endregion

    #region Save and load functions
    // Saves all data when called
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

    // loads all saved data if no saved data starts off data as defaults
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


    // resets all data to defaults
    public void ResetPreferences()
    {
        // resets all data to defaults
        PlayerPrefs.DeleteAll();
        //morning
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
        //SaveUserName = "User";
    }
    #endregion
}
