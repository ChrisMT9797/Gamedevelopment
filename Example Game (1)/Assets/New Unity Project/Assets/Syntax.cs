using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my object
        
        /* Hello there!
         *General Kenobi!
         * */}

    // Update is called once per frame
    void Update()
    {
        print(transform.position.y);
        if (transform.position.y <= 5f)
        {
            print("i'm about to hit the ground!");
        }
		else if (transform.position.y <=2.5f) 
		{
			print ("AAAAAAAAAAAAAHHHHHHHHHHHHHHH");
		}
		else
		{
			print("I'm fine... yeah... I'm... Fine...");
		}
    }
}
