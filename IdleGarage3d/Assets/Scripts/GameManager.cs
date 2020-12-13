using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public float coins = 0;
    public float earnCoin = 10;

    public Button CustomerFrequencyButton;
    public Button CarSpeedUpButton;
    //For Speed of Cars
    public int CarSpeedUpCost;
    public int CarSpeedUpLevel;
    public Text SpeedLevelText;

    //For Customer Frequeency
    public int CustomerFrequencyCost;
    public int CustomerFrequencyLevel;
    public Text CustomerFrequencyLevelText;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        coins = PlayerPrefs.GetFloat("Coin");
    }

    private void Start()
    {
        CarSpeedUpCost = 400;
        CarSpeedUpLevel = 0;

        CustomerFrequencyLevel = 0;
        CustomerFrequencyCost = 400;
        SpeedLevelText.text = CarSpeedUpCost + Environment.NewLine + CarSpeedUpLevel.ToString() + "/5" ;
        CustomerFrequencyLevelText.text = CustomerFrequencyCost + Environment.NewLine + CustomerFrequencyLevel.ToString() + "/7";
    }
    public void CarSpeedUp()
    {
        if (CarSpeedUpLevel < 5)
        {
            if (PlayerPrefs.GetFloat("Coin") > CarSpeedUpCost)
            {
                CarSpeedUpLevel += 1;
                SpeedLevelText.text = "";
                CarScript.speed += 2;
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - CarSpeedUpCost);
                //TriggerControl.coins -= CarSpeedUpCost;
                CarSpeedUpCost = CarSpeedUpCost * 8;
                SpeedLevelText.text = CarSpeedUpCost + Environment.NewLine + CarSpeedUpLevel.ToString() + "/5" ;
            }
        }
        if (CarSpeedUpLevel == 5)
        {
            CarSpeedUpButton.interactable = false;
            SpeedLevelText.text = "MAX LEVEL";
        }       

    }
    public void CustomerFrequency()
    {
        if (CarCreatedScript.i < 7)
        {
            if (PlayerPrefs.GetFloat("Coin") > CustomerFrequencyCost)
            {
                CarCreatedScript.i += 1;
                CustomerFrequencyLevelText.text = "";
                CustomerFrequencyLevel += 1;
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - CustomerFrequencyCost);
                //TriggerControl.coins -= CustomerFrequencyCost;
                CustomerFrequencyCost = CustomerFrequencyCost * 8;
                CustomerFrequencyLevelText.text = CustomerFrequencyCost + Environment.NewLine + CustomerFrequencyLevel.ToString() + "/7";

            }
      
        }
        if (CarCreatedScript.i == 7)
        {
            CustomerFrequencyButton.interactable = false;
            CustomerFrequencyLevelText.text = "MAX LEVEL";
        }        
    }

    public void MoneyBoost()
    {
        coins += earnCoin;
        PlayerPrefs.SetFloat("Coin", coins);
        //PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") + PlayerPrefs.GetFloat("EarnCoin"));
       // TriggerControl.coins += TriggerControl.earnCoin;
    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("a");
            MoneyBoost();
        }
    }
}
