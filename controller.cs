using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	private InstantTrackingController trackerscript;
	private GameObject ButtonParent;

	// Use this for initialization
	void Start () {
		trackerscript = GameObject.Find ("Controller").gameObject.GetComponent<InstantTrackingController> ();
		ButtonParent = GameObject.Find ("Button Parent");

		trackerscript._gridRenderer.enabled = false;
		ButtonParent.SetActive (false);
		
	}
	void OnEnable()
	{
		trackerscript._gridRenderer.enabled = false;
		ButtonParent.SetActive (false);
	}
	void OnDisable()
	{
		ButtonParent.SetActive (true);
	}
		
	// Update is called once per frame
	

}
