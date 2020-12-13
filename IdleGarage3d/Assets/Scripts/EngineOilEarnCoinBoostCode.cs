using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineOilEarnCoinBoostCode : MonoBehaviour
{
    [System.Serializable]
    public class Experience
    {
        public float price;
        public Button button;
    }

    public Button UpgradeButton;
    public GameObject PowerUpButtonText;
    public GameObject UpgradeLevelText;

    public float UpgradePrice = 400;

    public static int UpgradeLevel = 0;
    public static int UpgradeLevel1 = 0;
    public static int UpgradeLevel2 = 0;
    public static int UpgradeLevel3 = 0;
    public static int UpgradeLevel4 = 0;
    public static int UpgradeLevel5 = 0;
    public static int UpgradeLevel6 = 0;
    public static int UpgradeLevel7 = 0;
    public static int UpgradeLevel8 = 0;
    public static int UpgradeLevel9 = 0;
    public static int UpgradeLevel10 = 0;
    public static int UpgradeLevel11 = 0;

    [SerializeField] Experience[] exp;

    public void Start()
    {

        PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradePrice.ToString();
    }

    public void earnMoneyBoost()
    {
        if (UpgradeLevel < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel += 1;
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin",PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                UpgradePrice += UpgradePrice * 0.4f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();
                
               
            }
        }
        if (UpgradeLevel == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost1()
    {
        if (UpgradeLevel1 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel1 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel1 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel1 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost2()
    {
        if (UpgradeLevel2 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel2 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel2 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel2 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost3()
    {
        if (UpgradeLevel3 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel3 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel3 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel3 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost4()
    {
        if (UpgradeLevel4 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel4 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel4 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel4 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost5()
    {
        if (UpgradeLevel5 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel5 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel5 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel5 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost6()
    {
        if (UpgradeLevel6 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel6 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel6 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel6 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost7()
    {
        if (UpgradeLevel7 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel7 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel7 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel7 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost8()
    {
        if (UpgradeLevel8 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel8 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel8 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel8 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost9()
    {
        if (UpgradeLevel9 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel9 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel9 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel9 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost10()
    {
        if (UpgradeLevel10 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel10 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel10 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel10 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
    public void earnMoneyBoost11()
    {
        if (UpgradeLevel11 < 8)
        {
            if (PlayerPrefs.GetFloat("Coin") > UpgradePrice)
            {
                UpgradeLevel11 += 1;
                /*if (GameManager.earnCoin%0.2 < 1 || GameManager.earnCoin%0.2 > 1)
                {
                    GameManager.earnCoin += 1;
                    GameManager.coins -= UpgradePrice;
                }*/
                PlayerPrefs.SetFloat("Coin", PlayerPrefs.GetFloat("Coin") - UpgradePrice);
                PlayerPrefs.SetFloat("EarnCoin", PlayerPrefs.GetFloat("EarnCoin") + PlayerPrefs.GetFloat("EarnCoin") * 0.1f);
                //TriggerControl.coins -= UpgradePrice;
                //TriggerControl.earnCoin += TriggerControl.earnCoin * 0.10f;
                UpgradePrice += UpgradePrice * 0.40f;
                PowerUpButtonText.GetComponentInChildren<Text>().text = UpgradeLevel11 + Environment.NewLine + Math.Round(UpgradePrice, 0).ToString();

            }
        }
        if (UpgradeLevel11 == 8)
        {
            UpgradeButton.interactable = false;
            PowerUpButtonText.GetComponentInChildren<Text>().text = "MAX LEVEL";
        }

    }
}
