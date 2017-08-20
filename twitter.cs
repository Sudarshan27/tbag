using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twitter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void tweet()
	{
		Application.OpenURL ("https://twitter.com/ManUtd?lang=en-in");
	}
}
