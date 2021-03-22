using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facemanager : MonoBehaviour {

	// Use this for initialization

	public GameObject face1,face2,face3,face4,face5,face6,fcover1,fcover2,fcover3,fcover4,fcover5,fcover6, winText;
	Vector3 face1InitialPos,face2InitialPos,face3InitialPos,face4InitialPos,face5InitialPos,face6InitialPos;
	public AudioSource source;
	public AudioClip[] correct;
	public AudioClip incorrect;
	//public AudioClip win;
	public static bool face1Correct, face2Correct,face3Correct, face4Correct, face5Correct,face6Correct = false;



	void Start () {
		face1InitialPos = face1.transform.position;
		face2InitialPos =face2.transform.position;
		face3InitialPos = face3.transform.position;
		face4InitialPos = face4.transform.position;
		face5InitialPos = face5.transform.position;
		face6InitialPos = face6.transform.position;
		winText.SetActive (false);
	}


	public void dragface1()
	{
		face1.transform.position = Input.mousePosition;
	}

	public void dragface2()
	{
		face2.transform.position = Input.mousePosition;
	}

	public void dragface3()
	{
		face3.transform.position = Input.mousePosition;
	}

	public void dragface4()
	{
		face4.transform.position = Input.mousePosition;
	}

	public void dragface5()
	{
		face5.transform.position=Input.mousePosition;
	}

	public void dragface6()
	{
		face6.transform.position=Input.mousePosition;
	}

	public void dropface1()
	{
		float Distance = Vector3.Distance (face1.transform.position, fcover1.transform.position);
		if (Distance < 50) {
			face1.transform.position = fcover1.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			face1Correct = true;
		} else {
			face1.transform.position = face1InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropface2()
	{
		float Distance = Vector3.Distance (face2.transform.position, fcover2.transform.position);
		if (Distance < 50) {
			face2.transform.position = fcover2.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			face2Correct = true;
		} else {
			face2.transform.position = face2InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropface3()
	{
		float Distance = Vector3.Distance (face3.transform.position, fcover3.transform.position);
		if (Distance < 50) {
			face3.transform.position = fcover3.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			face3Correct = true;
		} else {
			face3.transform.position = face3InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropface4()
	{
		float Distance = Vector3.Distance (face4.transform.position, fcover4.transform.position);
		if (Distance < 50) {
			face4.transform.position = fcover4.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			face4Correct = true;
		} else {
			face4.transform.position = face4InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropface5()
	{
		float Distance = Vector3.Distance (face5.transform.position, fcover5.transform.position);
		if (Distance < 50) {
			face5.transform.position = fcover5.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			face5Correct = true;
		} else {
			face5.transform.position = face5InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropface6()
	{
		float Distance = Vector3.Distance (face6.transform.position, fcover6.transform.position);
		if (Distance < 50) {
			face6.transform.position = fcover6.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			face6Correct = true;
		} else {
			face6.transform.position = face6InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}





	// Update is called once per frame
	void Update()
	{
		if (face1Correct && face2Correct && face3Correct && face4Correct && face5Correct && face6Correct) {
			//source.clip = win;
			//source.Play ();
			winText.SetActive (true);

		}
	}

}
