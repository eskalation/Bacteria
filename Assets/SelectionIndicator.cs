using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;

public class SelectionIndicator : MonoBehaviour {
	public Image background;
	public Image icon;

	public Action OnHidden;

	private ParticleSystem _particles;
	private BacteriaElement _element;
	private UnitType _unitType;

	private bool _dragging = false;

	private RectTransform _rectTransform;

	void Awake() {
		_rectTransform = GetComponent<RectTransform>();
		_particles = GetComponent<ParticleSystem>();
	}

	void Start() {
		Canvas canvas = gameObject.AddComponent<Canvas>();

		canvas.overrideSorting = true;
		canvas.sortingOrder = 100;

	}

	public void AddBacteriaElement(BacteriaElement element) {
		if(_dragging) {
			_element = element;

			_particles.startColor = element.color;
			background.color = element.color;
		}
	}

	public void AddUnitType(UnitType unitType) {
		if(_dragging) {
			if(unitType == _unitType) {
				return;
			}
			
			_unitType = unitType;
			
			icon.sprite = unitType.icon;
			icon.color = Color.white;
			icon.SetNativeSize();
			transform.DOKill(true);
			transform.DOPunchScale(Vector3.one * .4f, .2f);
		}
	}

	public void StartDrag() {
		_dragging = true;
	}

	void Update() {
		if(_dragging) {
			_rectTransform.anchoredPosition = Input.mousePosition;
		}
	}

	public void StopDrag() {
		_dragging = false;
	}

	public void Show() {
		transform.DOKill(false);
		transform.DOScale(Vector3.one * 1.5f, .5f).SetEase(Ease.OutBack);
	}

	public void Hide() {
		transform.DOKill(false);
		transform.DOScale(Vector3.zero, .3f).SetEase(Ease.OutQuad);

		Invoke("Hidden", _particles.startLifetime);

	}

	void Hidden() {
		if(OnHidden != null) {
			OnHidden();
		}
	}
}
