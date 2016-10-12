using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using DG.Tweening;

public class ColorButton : MonoBehaviour, IPointerDownHandler, IPointerExitHandler, IPointerUpHandler {
	public Image colorFill;
	public BacteriaElement element;

	private SelectionIndicator _instantiatedBacteria;
	private bool _leftArea;

	public void OnPointerDown(PointerEventData data ) {
		SelectionIndicator indicator = PlayerSegmentManager.instance.indicatorPrefab;
		Transform parentIn = PlayerSegmentManager.instance.canvasTransform;


		_instantiatedBacteria = Instantiate( indicator, parentIn, false) as SelectionIndicator;
		_instantiatedBacteria.GetComponent<RectTransform>().anchoredPosition = Input.mousePosition;
		_instantiatedBacteria.StartDrag();
		_instantiatedBacteria.Show();
		_instantiatedBacteria.AddBacteriaElement(element);

		PlayerSegmentManager.instance.currenctIndicator = _instantiatedBacteria;

		_leftArea = false;
	}

	public void OnPointerExit(PointerEventData eventData) {
		Debug.Log("EXIT!");

		_leftArea = true;
	}

	public void OnPointerUp(PointerEventData eventData) {
		Debug.Log("UP!");

		if(!_leftArea) {
		}

		_instantiatedBacteria.StopDrag();
		_instantiatedBacteria.Hide();
		_instantiatedBacteria.OnHidden += DestroyBacteria;
	}

	void DestroyBacteria() {
		_instantiatedBacteria.OnHidden -= DestroyBacteria;
		Destroy(_instantiatedBacteria.gameObject);
	}

	public void OnValidate() {
		if(colorFill != null) {
			colorFill.color = element.color;
		}
	}
}
