using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankManager : MonoBehaviour
{
    public GameObject DepositPanel;
    public GameObject WithdrawlPanel;
    public GameObject DepoWithPanel;
    public GameObject StopPanel;

    public Text Cash;
    public Text Balance;

    public int cash = 100000;
    public int balance = 50000;
    public void DepositTen()
    {      
        if (cash < 10000)
        {
            //StopPanel.SetActive(true);
        }
        else
        {
            cash -= 10000;
            balance += 10000;
        }
    }

    public void DepositThirty()
    {
        if (cash < 30000)
        {
            StopPanel.SetActive(true);
        }
        else
        {
            cash -= 30000;
            balance += 30000;
        }
    }
    public void DepositFifty()
    {
        if (cash < 50000)
        {
            StopPanel.SetActive(true);
        }
        else
        {
            cash -= 50000;
            balance += 50000;
        }
    }

    public void WithdrawlTen()
    {
        if (balance < 10000)
        {
            StopPanel.SetActive(true);
        }
        else
        {
            balance -= 10000;
            cash += 10000;
        }
    }
    public void WithdrawlThirty()
    {
        if (balance < 30000)
        {
            StopPanel.SetActive(true);
        }
        else
        {
            balance -= 30000;
            cash += 30000;
        }
    }
    public void WithdrawlFifty()
    {
        if (balance < 50000)
        {
            StopPanel.SetActive(true);
        }
        else
        {
            balance -= 50000;
            cash += 50000;
        }
    }
    public void SettingCashBalance()
    {
        Cash.text = "Çö±Ý: " + cash.ToString();
        Balance.text = "Balance: " + balance.ToString();
    }

    public void OnClickStop()
    {
        StopPanel.SetActive(false);
    }
    public void OnClickDeposit()
    {
        DepositPanel.SetActive(true);

        DepoWithPanel.SetActive(false);
    }


    public void OnClickWithdrawl()
    {
        WithdrawlPanel.SetActive(true);

        DepoWithPanel.SetActive(false);
    }

    public void OnClickBack1()
    {
        DepoWithPanel.SetActive(true);

        DepositPanel.SetActive(false);
    }

    public void OnClickBack2()
    {
        DepoWithPanel.SetActive(true);

        WithdrawlPanel.SetActive(false);
    }

    void Awake()
    {
        SettingCashBalance();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SettingCashBalance();
    }
}
