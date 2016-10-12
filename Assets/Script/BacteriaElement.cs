using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CreateAssetMenu(fileName = "BacteriaElement", menuName = "Data/Bacteria Element", order = 1)]
public class BacteriaElement : ScriptableObject {
	new public string name;

	public Color color = Color.white;

	public List<BacteriaElement> strongAgainst;
	public List<BacteriaElement> weakAgainst;
}