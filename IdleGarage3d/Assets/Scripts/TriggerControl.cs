using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerControl : MonoBehaviour
{
    public Text coinsText;
    float coinsx;
    public bool exiting = false;
    public void Start()
    {
        coinsText.GetComponentInChildren<Text>().text = "Coins: " + Math.Round(PlayerPrefs.GetFloat("Coin"), 0).ToString();
    }
    private void OnTriggerExit(Collider Car)
    {
        if (Car.tag == "Car")
        {
            exiting = true;
        }

    }
    private void Update()
    {
        coinsText.text = "Coins: " + Math.Round(PlayerPrefs.GetFloat("Coin"), 0).ToString();
        if (exiting)
        {
            PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") + PlayerPrefs.GetFloat("EarnCoin"));
            exiting = false;
        }
    }
}
