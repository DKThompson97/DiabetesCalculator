using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [SerializeField] private float Glucose = 0f;
    [SerializeField] private float Sensitivity = 0f;
    [SerializeField] private float Carb = 0f;



    public float getGoalGlucose { get { return Glucose; } set { Glucose = value; } }
    public float getSensitivityIndex { get { return Sensitivity; } set { Sensitivity = value; } }
    public float getCarbControl { get { return Carb; } set { Carb = value; } }
    public static SaveData Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Glucose = 120f;
            Carb = 60f;
            Sensitivity = 200f;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        
    }
    //public void Update()
    //{
    //    Glucose = Master.Instance.getGoalGlucose;
    //    Carb = Master.Instance.getCarbControl;
    //    Sensitivity = Master.Instance.getSensitivityIndex;
    //}
}
