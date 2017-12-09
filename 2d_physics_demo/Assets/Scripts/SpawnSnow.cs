using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnow : MonoBehaviour {

    public GameObject snowFlake;

    private float spawnerLenght;

	// Use this for initialization
	void Start ()
    {
        spawnerLenght = this.gameObject.transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(SpawnSnowflake());
	}

    IEnumerator SpawnSnowflake()
    {
        float snowflakePosX = UnityEngine.Random.Range(0, spawnerLenght);
        Vector3 snowflakePos = new Vector3(this.gameObject.transform.localScale.x / 2 - snowflakePosX, this.gameObject.transform.position.y);
        Instantiate(snowFlake, snowflakePos, this.gameObject.transform.rotation);
        yield return 0;
    }
}
