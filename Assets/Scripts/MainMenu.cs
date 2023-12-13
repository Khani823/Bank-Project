using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickDeposit()
    {
        Debug.Log("입금");
    }

    public void OnClickWithdrawl()
    {
        Debug.Log("출금");        
    }

    public void OnClickCash()
    {
        Debug.Log("현금");
    }

    public void OnClick10000()
    {
        Debug.Log("10000원 입금");
    }
    public void OnClick30000()
    {
        Debug.Log("30000원 입금");
    }
    public void OnClick50000()
    {
        Debug.Log("50000원 입금");
    }
    public void OnClickBack()
    {
        Debug.Log("뒤로가기");
    }
}
