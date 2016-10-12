using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "HealingUnitType", menuName = "Data/Units/Healing Unit Type", order = 1)]
public class HealingUnitType : UnitType {
	[Header("Healing Stats")]
	public float healAmount;
	public float healSpeed;
}
