using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGameObjects : MonoBehaviour {

	public Transform mapTransform;
	private float delay = 0.5f;
	private float time = 0.0f;
	private bool triggered = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!triggered) {
			time += Time.deltaTime;
			if (time >= delay) {
				triggered = true;
				Debug.Log(mapTransform);
				foreach (Transform transform in mapTransform) {
					Debug.Log(transform);
					if (transform.ToString() == "17/23242/47860 (UnityEngine.Transform)") {
						int index = 0;
						foreach (Transform child in transform) {
							print(index);
							if (index == 12) {
								Destroy(child.gameObject);
							}
							index++;
						}
					} else if (transform.ToString() == "17/23242/47861 (UnityEngine.Transform)") {
						int index = 0;
						foreach (Transform child in transform) {
							print(index);
							if (index == 8) {
								Destroy(child.gameObject);
							}
							index++;
						}
					}
				}
			}
		}
	}
}
