using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerWallet : MonoBehaviour
{
	private int _balance;

	public int Balance => _balance;

	public event UnityAction<int> BalanceChange;

	public void IncreceBalane(int value)
	{
		_balance += value;
		BalanceChange?.Invoke(_balance);
	}

	public void DecreseBalane(int value)
	{
		_balance -= value;
		BalanceChange?.Invoke(_balance);
	}
}
