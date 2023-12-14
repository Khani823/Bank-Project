using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;

    public Userdata userData;

    private void Awake()
    {
        Instance = this;
    }
}
