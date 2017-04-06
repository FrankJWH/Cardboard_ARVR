using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webCam : MonoBehaviour {
	public GameObject slider;
	public Slider sliderVal;
	// Use this for initialization
		float zAxis = 30F;

		IEnumerator Start() {

			yield return Application.RequestUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone);

			if (Application.HasUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone)) {
//
//				float height = Camera.main.orthographicSize * 2.0F;
//				float width = height * Screen.width / Screen.height;
//				transform.localScale += new Vector3(width, height, 0.1F);

				WebCamTexture webcamTexture = new WebCamTexture();
				Renderer renderer = GetComponent<Renderer>();
				renderer.material.mainTexture = webcamTexture;
				webcamTexture.Play();

				transform.eulerAngles = new Vector3 (0, 0, zAxis);

			} else {
			}
		}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (GetComponent<Camera>().transform.position);
//		zAxis = float.Parse (sliderVal.value.ToString());
		transform.eulerAngles = new Vector3 (0, 0, zAxis);

	}
}
