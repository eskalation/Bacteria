using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "UnitType", menuName = "Data/Units/Unit Type", order = 1)]
public class UnitType : ScriptableObject {
	[Header("Info")]
	public string namePostFix;
	public int cost;

	[Header("Base Stats")]
	public float damage;
	public float attackSpeed = 1f;
	public float health;
	public float moveSpeed = 1f;
}
