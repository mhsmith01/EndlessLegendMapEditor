using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{

    public string Name;

    public Dictionary<string, string> Localization;

    public Region()
    {
        Localization = new Dictionary<string, string>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
