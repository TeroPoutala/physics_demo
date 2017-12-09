using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour {

    private float scale;

	// Use this for initialization
	void Start ()
    {
        scale = Random.Range(0.1f, 0.4f);
        this.gameObject.transform.localScale = new Vector3(scale, scale);
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.gameObject.transform.position += Vector3.down * ((scale + 1f) * Time.deltaTime);
	}
}
