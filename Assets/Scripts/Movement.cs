using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("right")) {
			addPosition(new Vector3(0.2f, 0, 0));
		}

		if (Input.GetKey("left")) {
			addPosition(new Vector3(-0.2f, 0, 0));
		}

		if (Input.GetKey("up")) {
			addPosition(new Vector3(0, 0.2f, 0));
		}

		if (Input.GetKey("down")) {
			addPosition(new Vector3(0, -0.2f, 0));
		}
	}

	private void addPosition(Vector3 movement) {
		this.gameObject.transform.position += movement;
	}
}
