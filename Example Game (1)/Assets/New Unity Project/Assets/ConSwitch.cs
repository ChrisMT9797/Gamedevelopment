using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
{
	{
		int intelx = 5;
		int intely = 6;

		if (intelx < intely)
		{
		print("My supierior intellect... was infieror???");
		}
		else
		{
		print("What a shame that you had to match wits with someone that has any...");
		}
	}
	{
	int strength = 4;
	switch(strength)
	{
	case 1:
	print("I am too strong................");
	break;
	case 2:
	print("I could lift that... if I wanted too..");
	break;
	case 3:
	print("That? HAHAHA... only weaklings bother.");
	break;
	case 4:
	print("What? am I lifing a house? So light I couldn't tell, haha");
	break;
	case 5:
	print("I could rep those with my pinky toe.");
	break;
	default:
	print("Strength stat failed.");
	break;
	}
	}
}

    /*{
        int intel1 = 7;
		int intel2 = 4;
        int intel3 = 3;
		int strength1 = 6;
		int strength2 = 3;
		int courage1 = 8;
		int courage2 = 2;
		
		if (intel1 > strength1)
		{
		print("Wisdom is power over all");
		}
		else if (intel1 > strength2)
		{
		print("A pity strength was your only power");
		}
		else if (intel1 < courage1)
		{
		print("If only you could have comprehended the darkness");
		}
		else if (intel1 > courage2)
		{
		print("Your boldness was your greatest strength... and it was foolish");
		}
		else if (intel2 < strength1)
		{
		print("Bravery is the greatest tool");
		}
		else if (intel2 > strenght2)
		{
		print("I conjour fire with thought... you lift rocks...");
		}
		else if (intel2 < courage1)
		{
		print("A fool for a wiseman...");
		}
		else if (intel2 > courage2)
		{
		print("A coward for a brave man...");
		}
		else if (intel3 < strength1)
		{
		print("Rocks hit harder than fire");
		}
		else if (intel3 > strength2)
		{
		print("Well fought... (never thought I'd respect a fool");
		}
		else if (intel3 < courage1)
		{
		print("This was no contest);
		}
		else if (intel3 > courage2)
		{
		print("Haha... you got beat by me?? bwahahaha... that's laughable... wait...");
		}
		else if (strength1 < courage1)
		{
		print("I would have breatended to be scared if I thought it'd made you feel better...");
		}
		else if (strength1 > courage2)
		{
		print("Die puny...");
		}
		else if (strength2 < courage1)
		{
		print("Well... at least you were too dumb to feel bad about this");
		}
		else (strength2 > courage2)
		{
		print("Smash... Break... ARGH!!");
		} I did the above for fun. It's not working, which I kinda expected. I'll figure it out sometime. There's also a random element that should be included (to randomly select between intel1/2/3 vs either strength1/2 or courage 1/2, etc.
    } */


    // Update is called once per frame
    void Update()
    {
        
    }
}
