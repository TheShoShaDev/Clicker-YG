using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventBus : MonoBehaviour
{
	public static event UnityAction<int> EnemyDied;

	public static event UnityAction EnemyDead;

	public static void OnEnemyDied(int value)
	{
		EnemyDied?.Invoke(value);
	}	
	public static void OnEnemyDead()
	{
		EnemyDead?.Invoke();
	}

}
