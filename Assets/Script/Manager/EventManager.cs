using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
   public static EventManager Instance { get; private set; }

    public Action<DeductMoneyEventArgs> DeductMoney;
    private void Awake()
    {
         Instance = this;
    }
}

public class DeductMoneyEventArgs : EventArgs
{
    public float Amount { get; private set; }
    public DeductMoneyEventArgs(float amount)
    {
        Amount = amount;
    }
}
