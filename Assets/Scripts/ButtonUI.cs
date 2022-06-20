using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    public void GoToHomeScreen()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void GoToCalculator()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings screen");
        
    }

    public void GoToGlucoseEquation()
    {
        SceneManager.LoadScene("GlucoseEquation");
    }

    public void GoToEquations()
    {
        SceneManager.LoadScene("Equations");
    }

    public void GoToCarbEquation()
    {
        SceneManager.LoadScene("CarbEquation");
    }

    public void GoToRoundingChart()
    {
        SceneManager.LoadScene("RoundingChart");
    }

    
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
