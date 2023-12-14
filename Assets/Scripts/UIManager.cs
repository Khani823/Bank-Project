using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text cashTxt;
    [SerializeField] TMP_Text balanceTxt;

    [SerializeField] TMP_InputField inputValue;
    [SerializeField] TMP_InputField outputValue;

    [SerializeField] GameObject PopupError;
    public static UIManager Instance;

    void Start()
    {
        Refresh();
    }

    string FormatNumber(int num)
    {
        return string.Format("{0:N0}", num);
    }

    void Refresh()
    {
        cashTxt.text = FormatNumber(MoneyManager.Instance.userData.cash);
        balanceTxt.text = FormatNumber(MoneyManager.Instance.userData.balance);
    }


    private void Awake()
    {
        Instance = this;
    }

    public void Deposit(int money)
    {
        // 보유한 현금보다 더 많은 돈을 넣을 수가 없음.
        if(money > MoneyManager.Instance.userData.cash)
        {
            PopupError.SetActive(true);
            return;
        }

        // 입금 절차 
        MoneyManager.Instance.userData.cash -= money;
        MoneyManager.Instance.userData.balance += money;

        Refresh();
    }

    public void Withdraw(int money)
    {
        if (money > MoneyManager.Instance.userData.balance)
        {
            PopupError.SetActive(true);
            return;
        }

        // 입금 절차 
        MoneyManager.Instance.userData.balance -= money;
        MoneyManager.Instance.userData.cash += money;

        Refresh();
    }

    public void CustomDeposit()
    {
        Deposit(int.Parse(inputValue.text));
    }

    public void CustomWithdraw()
    {
        Withdraw(int.Parse(outputValue.text));
    }
}
