using UnityEngine;
using System.Collections;

public class Bacteria : MonoBehaviour {
	public BacteriaElement bacteriaType;
	public UnitType unitType;

	float _damage;
	float _health;
	float _speed;

	private SpriteRenderer _renderer;

	public void Start() {
		//_renderer = GetComponent<SpriteRenderer>();
		//_renderer.color = bacteriaType.color;
	}
}
