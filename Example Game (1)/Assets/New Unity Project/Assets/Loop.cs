using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		{
//loop
		for (int i = 0; i < 5; i++)
			{
			print(i);
			}
		}
		{
//array
        string[] characters = {"Volgai", "Willstrom", "Felix", "Grathorn"};
		characters[3] = "Orian";
		print(characters[3]);
		print(characters.Length);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
