using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Store Item", menuName = "Store Item")]
public class UpgradeItem : ScriptableObject
{
	[SerializeField] private UpgradeType _upgradeType;
	[SerializeField] private string _label;
	[SerializeField] private Sprite _icon;
	[SerializeField] private int _price;

	public UpgradeType UpgradeType => _upgradeType;
	public string Label => _label;
	public Sprite Icon => _icon;
	public int Price => _price;

	public void DoUpgrade()
	{
		Upgrade.DoUpgrade(UpgradeType);
	}
}

public enum UpgradeType
{
	Damage,
	Income
}
