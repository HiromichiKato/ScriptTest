using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];          array[0] = 20;         array[1] = 25;         array[2] = 48;         array[3] = 82;         array[4] = 90;          for (int i = 4; i > -1; i--)
        {             Debug.Log(array[i]);         }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
