using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;

public class DisplayUI : MonoBehaviour {

//	public GameObject menu;
	private bool isShowing;
	public InputField inputVal;
	public GameObject background;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int nbTouches = Input.touchCount;

		if (nbTouches > 0) {
			Debug.Log ("Touched Again!");
			VRSettings.enabled = !VRSettings.enabled;
//			menu.SetActive (!isShowing);
			Debug.Log("this is touched");
			Debug.Log ("TextBox input:" + inputVal.text.ToString());
		}
		if (Input.GetMouseButtonDown (0)) {
//			menu.SetActive (!isShowing);
			Debug.Log("this is touched");
			Debug.Log ("TextBox input:" + inputVal);
		}

		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
//				menu.SetActive (!isShowing);
			}
		}
		
	}
}
