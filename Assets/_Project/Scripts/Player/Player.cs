using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerWallet))]
public class Player : MonoBehaviour
{
	private PlayerWallet _playerWallet;

	private void Awake()
	{
		PlayerStats.InitStats();
	}

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

public static class PlayerStats
{
	public static float DamageAmount { get; private set; }

	public static void InitStats()
	{
		
	}

	public static void IncreseAmount(float value)
	{
		DamageAmount += value;
	}
}
