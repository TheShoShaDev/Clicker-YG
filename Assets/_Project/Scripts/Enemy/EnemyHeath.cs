using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeath : MonoBehaviour
{
	[SerializeField] private EnemyHealthConfig _enemyHeath;
	public float Health { get; private set; }
	public bool IsDead => Health <= 0;

	private void Start()
	{
		Health = _enemyHeath.Health;
	}

	public void GetDamage(float damage)
	{
		Health -= damage;
	}
}
