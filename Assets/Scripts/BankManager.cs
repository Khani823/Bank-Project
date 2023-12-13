using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    public GameObject DepositPanel;
    public GameObject WithdrawlPanel;
    public GameObject DepoWithPanel;
    

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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
