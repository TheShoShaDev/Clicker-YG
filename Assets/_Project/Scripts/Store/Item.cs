using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI _label;
	[SerializeField] private TextMeshProUGUI _price;
	[SerializeField] private Image _icon;
	[SerializeField] private Button _buyButton;

	private UpgradeItem _storeItem;
	private UpgradeType _upgradeType;
	private int _currentLevel;

	private void Awake()
	{
		_currentLevel = 0 == PlayerPrefs.GetInt(_upgradeType.ToString()) ? 1 : PlayerPrefs.GetInt(_upgradeType.ToString());
	}

	public void SetItem(UpgradeItem storeItem)
	{
		_storeItem = storeItem;
		RenderItem(storeItem);
	}

	private void RenderItem(UpgradeItem storeItem)
	{
		_label.text = storeItem.Label;
		_price.text = (storeItem.Price * _currentLevel).ToString();
		_icon.sprite = storeItem.Icon;
	}

}
