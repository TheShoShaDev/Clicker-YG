using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemyHeath))]
[RequireComponent(typeof(SpriteSwapper))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyHeath _enemyHealth;
    [SerializeField] private SpriteSwapper _spriteSwapper;

	[SerializeField] private int _value;

	private void Start()
	{
		if(!_enemyHealth.gameObject.activeSelf)
		{
			_enemyHealth.gameObject.SetActive(true);
		}

	}

	public void OnClick()
    {
        if(!_enemyHealth.IsDead)
        {
			StartCoroutine(_spriteSwapper.SetHit());

            _enemyHealth.GetDamage(1f);
        }
        else
        {
			StartCoroutine(_spriteSwapper.SetDead());
		}
    }

	private void OnValidate()
	{
		_enemyHealth ??= GetComponent<EnemyHeath>();
		_spriteSwapper ??= GetComponent<SpriteSwapper>();
	}

	private void OnSetDead()
	{
		EventBus.OnEnemyDied(_value);
		//Debug.Log("I've Died");
	}

	private void OnEnable()
	{
		EventBus.EnemyDead += OnSetDead;
	}

	private void OnDisable()
	{
		EventBus.EnemyDead -= OnSetDead;
	}
}
