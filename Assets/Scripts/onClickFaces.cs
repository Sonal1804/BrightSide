using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClickFaces : MonoBehaviour {

	public GameObject face1,face2,face3,face4,face5,face6,fcover1,fcover2,fcover3,fcover4,fcover5,fcover6, winText;
	Vector3 face1InitialPos,face2InitialPos,face3InitialPos,face4InitialPos,face5InitialPos,face6InitialPos;

	void Start () {
		face1InitialPos = face1.transform.position;
		face2InitialPos =face2.transform.position;
		face3InitialPos = face3.transform.position;
		face4InitialPos = face4.transform.position;
		face5InitialPos = face5.transform.position;
		face6InitialPos = face6.transform.position;
		winText.SetActive (false);
		
	}


	public void LoadScene(string sceneName)
	{
		
		SceneManager.LoadScene(sceneName);
	}
}
