using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerWallet))]
public class Player : MonoBehaviour
{
	private PlayerWallet _playerWallet;

	private void OnEnable()
	{
		EventBus.EnemyDied += OnEnemyDied;
	}

	private void OnDisable()
	{
		EventBus.EnemyDied -= OnEnemyDied;
	}

	private void Start()
	{
		_playerWallet = GetComponent<PlayerWallet>();
	}

	private void OnEnemyDied(int value) 
	{
		_playerWallet.IncreceBalane(value);
	}

}
