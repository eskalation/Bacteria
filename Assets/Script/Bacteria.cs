using UnityEngine;
using System.Collections;

public class Bacteria : MonoBehaviour {
	public BacteriaElement bacteriaType;
	public UnitType unitType;

	public float damage;
	public float health;
	public float speed;

	public int cost;

	private SpriteRenderer _renderer;

	public void Start() {
		_renderer = GetComponent<SpriteRenderer>();

		_renderer.color = bacteriaType.color;
	}

	void OnValidate() {
		if(bacteriaType != null) {
			GetComponent<SpriteRenderer>().color = bacteriaType.color;
		}
	}
}
