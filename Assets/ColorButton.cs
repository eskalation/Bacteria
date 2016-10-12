using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ColorButton : MonoBehaviour, IPointerDownHandler, IPointerExitHandler, IPointerUpHandler {
	public Image colorFill;
	public BacteriaElement element;

	public Bacteria bacteriaPrefab;

	private Bacteria _instantiatedBacteria;
	private bool _leftArea;

	public void OnPointerDown(PointerEventData data ) {
		_instantiatedBacteria = Instantiate( bacteriaPrefab, transform.position, Quaternion.identity) as Bacteria;

		_leftArea = false;
	}

	public void OnPointerExit(PointerEventData eventData) {
		_leftArea = true;
	}

	public void OnPointerUp(PointerEventData eventData) {
		if(!_leftArea) {
			Destroy(_instantiatedBacteria);
		}
	}

	public void OnValidate() {
		if(colorFill != null) {
			colorFill.color = element.color;
		}
	}
}
