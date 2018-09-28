using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class AnchorMap : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Touch touch;
		if (Input.touchCount<1 || (touch=Input.GetTouch(0)).phase!=TouchPhase.Began) {
			return;
		}

		TrackableHit hit;

		TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinBounds | TrackableHitFlags.PlaneWithinPolygon | TrackableHitFlags.FeaturePointWithSurfaceNormal;
		if (Frame.Raycast(touch.position.x, touch.position.y, raycastFilter, out hit)) {
			var anchor = hit.Trackable.CreateAnchor(hit.Pose);
			transform.position = anchor.transform.position;
		}
	}
}
