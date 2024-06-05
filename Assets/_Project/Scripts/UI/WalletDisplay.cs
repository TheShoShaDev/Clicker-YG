using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class WalletDisplay : MonoBehaviour
{
	[SerializeField] private PlayerWallet _playerWallet;
	[SerializeField] private TextMeshProUGUI _balanceDisplay;

	private void OnEnable()
	{
		_playerWallet.BalanceChange += OnBalanceChanged;
	}
	private void OnDisable()
	{
		_playerWallet.BalanceChange -= OnBalanceChanged;
	}

	private void OnBalanceChanged(int balance)
	{
		_balanceDisplay.text = balance.ToString();
	}
}
