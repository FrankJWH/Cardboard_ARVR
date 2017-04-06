using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamScript : MonoBehaviour {
	// Use this for initialization
	//float zAxis = 0F;

	IEnumerator Start() {

		yield return Application.RequestUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone);

		if (Application.HasUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone)) {

			WebCamTexture webcamTexture = new WebCamTexture();
			Renderer renderer = GetComponent<Renderer>();
			renderer.material.mainTexture = webcamTexture;
			webcamTexture.Play();

			//transform.eulerAngles = new Vector3 (0, 0, 0);

		} else {
		}
	}

	// Update is called once per frame
	void Update () {
		//transform.LookAt (GetComponent<Camera>().transform.position);
		//zAxis = float.Parse (sliderVal.value.ToString());
		//transform.eulerAngles = new Vector3 (0, 0, zAxis);

	}
}