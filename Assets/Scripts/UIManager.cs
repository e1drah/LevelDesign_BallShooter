﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

// Sam Robichaud 
// NSCC Truro 2022

public class UIManager : MonoBehaviour
{
    //Script references
    public GameObject ball;
    private BallController _ballController;

    //private GameObject gameManager;
    //private GameManager _gameManager;


    public Text modeText;    
    public Text ShotsLeftCount;

    public Text LevelCount;

    public Slider Slider;

    public void UpdateShotsleft(int count)
    {        
        ShotsLeftCount.text = count.ToString();
    }

    public void UpdateLevelCount(int count)
    {
        LevelCount.text = count.ToString();
    }
        
    public void SliderUpdate(float holdTime)
    {
        Slider.value = holdTime;
    }

}
