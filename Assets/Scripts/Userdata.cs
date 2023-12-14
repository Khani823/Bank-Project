using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UserData_", menuName = "ATM Data/User Data", order = 0)]

public class Userdata : ScriptableObject
{
    public int cash;
    public int balance;
}
