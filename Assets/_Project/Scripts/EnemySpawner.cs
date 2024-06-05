using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyPlace _enemyPlace;
    [SerializeField] private List<Enemy> _enemiesTemplates;

	private int _currentEnemyIndex;

	private void Start()
	{
		_currentEnemyIndex = 0;
		SpawnEnemy();
	}

	//� ������������ ������ �� ����, ������� ���� ������������ ����� �� Rockstart. 
	//������������������ ������ ���� ������ �������, ����� ���� �����, ��� � ��� ���� ������
	private void SpawnEnemy()
	{
		if (_currentEnemyIndex >= _enemiesTemplates.Count)
		{
			_currentEnemyIndex = 0;
		}

		Enemy enemyToSpawn = _enemiesTemplates[_currentEnemyIndex];
		_enemyPlace.SetEnemy(enemyToSpawn);
		_currentEnemyIndex++;
	}

	private void OnEnemyDied(int useLessWalletValue)
	{
		SpawnEnemy();
	}

	private void OnEnable()
	{
		EventBus.EnemyDied += OnEnemyDied;
	}

	private void OnDisable()
	{
		EventBus.EnemyDied -= OnEnemyDied;
	}
}
