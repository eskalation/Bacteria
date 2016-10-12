using UnityEngine;
using System.Collections;

public class Bacteria : MonoBehaviour {
	BacteriaElement _bacteriaElement;
	UnitType _unitType;

	float _damage;
	float _health;
	float _speed;

	private SpriteRenderer _renderer;

	public void Awake() {
		_renderer = GetComponent<SpriteRenderer>();
		//_renderer.color = bacteriaType.color;
	}

	public void SetBacteriaElement(BacteriaElement element) {
		_bacteriaElement = element;

		_renderer.color = _bacteriaElement.color;
	}
}
