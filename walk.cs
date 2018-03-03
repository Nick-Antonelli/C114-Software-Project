using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {
    Animation animal;
    Vector3 End_pos;
        Vector3 Start_pos;
    public float fraction_of_way_there;
    public float speed = 5f;
	// Use this for initialization
	void Start () {

        Start_pos = transform.position;
        End_pos = transform.position + new Vector3(6, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        fraction_of_way_there += 0.01f;
        transform.position = Vector3.Lerp(Start_pos, End_pos, fraction_of_way_there);
        transform.Translate(speed * Time.deltaTime, 0, 0);
	}
}
