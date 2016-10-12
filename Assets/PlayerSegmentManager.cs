using UnityEngine;
using System.Collections;

public class PlayerSegmentManager : MonoBehaviour {
	public static PlayerSegmentManager instance;

	public SelectionIndicator indicatorPrefab;
	public Transform canvasTransform;

	public SelectionIndicator currenctIndicator;

	void Awake() {
		if(instance == null) {
			instance = this;
		} else if(instance != this) {
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}
}
