using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour
{
	[SerializeField] private Store _store;
	[SerializeField] private Button _openbutton;
	[SerializeField] private Button _closebutton;

	private void OpenStore()
	{
		_store.gameObject.SetActive(true);
	}

	private void CloseStore()
	{
		_store.gameObject.SetActive(false);
	}

	private void OnEnable()
	{
		_openbutton.onClick.AddListener(OpenStore);
		_closebutton.onClick.AddListener(CloseStore);
	}

	private void OnDisable()
	{
		_openbutton.onClick.RemoveListener(OpenStore);
		_closebutton.onClick.RemoveListener(CloseStore);
	}

}
