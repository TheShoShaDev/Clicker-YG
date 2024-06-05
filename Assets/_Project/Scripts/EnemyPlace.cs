using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyPlace : MonoBehaviour
{
    [SerializeField] private ClickerZone _clickerZone;
	private Enemy _currentEnemy;

	private void Start()
	{
       // SetEnemy(_currentEnemy);
	}

	public void SetEnemy(Enemy enemy)
    {
        //Архитектурный провал(
        if(_currentEnemy != null)
        {
            RemoveEnemy(_currentEnemy.gameObject);
        }

        _currentEnemy = Instantiate(enemy, transform);
        _clickerZone.Click += _currentEnemy.OnClick;
    }
        
    public void RemoveEnemy(GameObject enemy)
    {
		_clickerZone.Click -= _currentEnemy.OnClick;
		Destroy(enemy);
    }

}
