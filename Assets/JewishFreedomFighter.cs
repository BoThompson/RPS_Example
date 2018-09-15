using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewishFreedomFighter : MonoBehaviour {
    public float Faith;
	// Use this for initialization
	void Start () {
		
	}
	public void PickOption(int option)
    {
        //Randomly pick for the computer
        int enemy = Random.Range(0, 3);
        //Decide who won
        if (enemy == 0)
        {
            if(option == 999)
            {
                Debug.Log("YOU WON, NAZIS DIE!!");
            }else if(option == -1000)
            {
                Debug.Log("YOU TIED. WITH NAZIS. YOU ARE TERRIBLE PEOPLE.");
            }
            else //They picked 0
            {
                Debug.Log("YOU LOST. TO NAZIS. YOU WERE NOT THE FINAL SOLUTION.");
            }
        }else if(enemy == 1)
        {
            if (option == 999)
            {
                Debug.Log("YOU TIED, FREEDOM FRIES FOR EVERYONE!!");
            }
            else if (option == -1000)
            {
                Debug.Log("YOU LOST. WITH NAZIS. YOU DON'T DESERVE TO WIN. IN LIFE.");
            }
            else //They picked 0
            {
                Debug.Log("YOU WIN. WHO NEEDS FREEDOM, AMIRITE?");
            }
        }
        else //This means they picked 2
        {

            if (option == 999)
            {
                Debug.Log("YOU LOST, FREEDOM CAN'T STOP BULLETS!!");
            }
            else if (option == -1000)
            {
                Debug.Log("YOU WON. WITH NAZIS. YOU DON'T DESERVE TO WIN. IN LIFE.");
            }
            else //They picked 0
            {
                Debug.Log("YOU TIED. MUTUALLY ASSURED DESTRUCTION. NOBODIES BABIES LIVE.");
            }
        }
        
        //Declare the winner
    }
	// Update is called once per frame
	void Update () {
        transform.position += Faith * Vector3.forward * Time.deltaTime;
	}
}
