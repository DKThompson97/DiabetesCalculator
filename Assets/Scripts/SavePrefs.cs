using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    [SerializeField] float SaveGoalGlucose;
    [SerializeField] float SaveSensitivityIndex;
    [SerializeField] float SaveCarbControl;
    //string SaveUserName = "";

    public float getGoalGlucose { get { return SaveGoalGlucose; } set { SaveGoalGlucose = value; } }
    public float getSensitivityIndex { get { return SaveSensitivityIndex; } set { SaveSensitivityIndex = value; } }
    public float getCarbControl { get { return SaveCarbControl; } set { SaveCarbControl = value; } }
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
       
        PlayerPrefs.SetFloat("SavedGoalGlucose", SaveGoalGlucose);
        PlayerPrefs.SetFloat("SavedSensitivityIndex", SaveSensitivityIndex);
        PlayerPrefs.SetFloat("SavedCarbControl", SaveCarbControl);
        //PlayerPrefs.SetString("UserName", SaveUserName);
        PlayerPrefs.Save();
    }

    public void LoadPreferences()
    {
        if (PlayerPrefs.HasKey("SavedGoalGlucose"))
        {
            SaveGoalGlucose = PlayerPrefs.GetFloat("SavedGoalGlucose");
            SaveSensitivityIndex = PlayerPrefs.GetFloat("SavedSensitivityIndex");
            SaveCarbControl = PlayerPrefs.GetFloat("SavedCarbControl");
            //SaveUserName = PlayerPrefs.GetString("UserName");
            
        }
        else
        {
            Debug.LogError("There was an Error No saved Data");
            // set defaults if no data?
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
