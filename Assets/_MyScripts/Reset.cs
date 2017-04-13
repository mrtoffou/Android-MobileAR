using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    private Vector3 _position;
    private Vector3 _scale;
	//private Vector3 _rotation;
    //private Vector3 rotation;

	// Use this for initialization
	void Start ()
    {
        _position = transform.position;
        _scale = transform.localScale;
		//_rotation = transform.localRotation;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

	// button onClick Event: Resets all transform properties
    public void onClick()
    {
        Debug.Log("onClick(): Reset");
        transform.position = _position;
        transform.localScale = _scale;
		//transform.rotation = _rotation;
    }
}
