using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
;
    }

    // Update is called once per frame
    void Update()
    {
		//					  X                 ,Y ,Z
        //transform.Translate(1f*Time.deltaTime,0f,0f);
		//transform.Translate(0f,1f*Time.deltaTime,0f);
		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,Input.GetAxis("Vertical")*Time.deltaTime,0f);
		//I tried to do "*(Time.deltaTime*2) to see if the rate of x movement would increase based
		//on how long I help the same directional button. it did not work. but surprisingly, also didn't
		//break the "game". 
    }
}
