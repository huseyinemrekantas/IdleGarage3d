using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnCoinSystem : MonoBehaviour
{
    public static Text coinsText;
    public static double coins;
    public static double earnCoin = 10;
    float timer = 0;
    private void Start()
    {
        coins += earnCoin;
    }
    // Update is called once per frame
    void Update()
    {
        timer += 1;
        coinsText.text = "Coins: " + Math.Round(coins, 0);
        if (timer % 97 == 0)
        {
            coins += earnCoin;
        }
    }
}
