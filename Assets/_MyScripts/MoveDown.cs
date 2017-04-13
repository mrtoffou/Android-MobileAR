using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick() {
		transform.localPosition -= new Vector3 (0.0f, 0.0f, 0.2f);
	}
}
