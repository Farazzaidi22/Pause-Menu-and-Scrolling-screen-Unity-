using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restrict : MonoBehaviour
{
    private Slider slider;

	// Use this for initialization
	void Start ()
    {
        slider = GetComponentInChildren<Slider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(this.transform.position.x < -100.052f)
        {
            transform.position = new Vector3(-100.052f, transform.position.y, transform.position.z);
        }

        else if (this.transform.position.x > 481.7941f)
        {
            transform.position = new Vector3(481.7941f, transform.position.y, transform.position.z);
        }
    }
}
