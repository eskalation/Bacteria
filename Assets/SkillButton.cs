using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class SkillButton : MonoBehaviour, IPointerEnterHandler {
	public UnitType unitType;
	public Image image;

	public void OnValidate() {
		if(image != null && unitType != null) {
			image.sprite = unitType.icon;
			image.SetNativeSize();
		}
	}

	public void OnPointerEnter(PointerEventData eventData) {
		Debug.Log("ENTER");

		SelectionIndicator indicator = PlayerSegmentManager.instance.currenctIndicator;

		if(indicator != null) {
			indicator.AddUnitType(unitType);
		}
	}
}
