using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SpriteSwapper : MonoBehaviour
{
	private SpriteRenderer _spriteRenderer;

	[SerializeField] private Sprite _default;
	[SerializeField] private Sprite _hit;
	[SerializeField] private Sprite _Dead;

	private bool IsDone => _spriteRenderer.sprite == _Dead;

	private void Awake()
	{
		_spriteRenderer ??= GetComponentInChildren<SpriteRenderer>();
		_default ??= _spriteRenderer.sprite;
	}

	public IEnumerator SetHit()
	{
		_spriteRenderer.sprite = _hit;
		yield return new WaitForSeconds(0.1f);
		if (!IsDone)
		{
			_spriteRenderer.sprite = _default;
		}
	}

	public IEnumerator SetDead() 
	{
		_spriteRenderer.sprite = _Dead;
		yield return new WaitForSeconds(0.1f);
		EventBus.OnEnemyDead();
	}
}
