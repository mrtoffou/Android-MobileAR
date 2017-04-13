using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour {
    public GameObject gameObj;
    public float speed = 2f;
    public float x = 0f;
    public float y = 10f;
    public float z = 0f;

    void Start()
    {

    }

    void Update()
    {
        transform.RotateAround( gameObj.transform.position, new Vector3(x,y,z), 100 * Time.deltaTime * speed );
    }
}