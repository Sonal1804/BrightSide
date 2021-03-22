using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmanager : MonoBehaviour {

	// Use this for initialization

	public GameObject bird1,bird2,bird3,bird4,bird5,bird6,bcover1,bcover2,bcover3,bcover4,bcover5,bcover6, winText;
	Vector3 bird1InitialPos,bird2InitialPos,bird3InitialPos,bird4InitialPos,bird5InitialPos,bird6InitialPos;
	public AudioSource source;
	public AudioClip[] correct;
	public AudioClip incorrect;
	//public AudioClip win;
	public static bool bird1Correct, bird2Correct,bird3Correct, bird4Correct, bird5Correct,bird6Correct = false;



	void Start () {
		bird1InitialPos = bird1.transform.position;
		bird2InitialPos = bird2.transform.position;
		bird3InitialPos = bird3.transform.position;
		bird4InitialPos = bird4.transform.position;
		bird5InitialPos = bird5.transform.position;
		bird6InitialPos = bird6.transform.position;
		winText.SetActive (false);
	}


	public void dragbird1()
	{
		bird1.transform.position = Input.mousePosition;
	}

	public void dragbird2()
	{
		bird2.transform.position = Input.mousePosition;
	}

	public void dragbird3()
	{
		bird3.transform.position = Input.mousePosition;
	}

	public void dragbird4()
	{
		bird4.transform.position = Input.mousePosition;
	}

	public void dragbird5()
	{
		bird5.transform.position=Input.mousePosition;
	}
		
	public void dragbird6()
	{
		bird6.transform.position=Input.mousePosition;
	}

	public void dropbird1()
	{
		float Distance = Vector3.Distance (bird1.transform.position, bcover1.transform.position);
		if (Distance < 50) {
			bird1.transform.position = bcover1.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			bird1Correct = true;
		} else {
			bird1.transform.position = bird1InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropbird2()
	{
		float Distance = Vector3.Distance (bird2.transform.position, bcover2.transform.position);
		if (Distance < 50) {
			bird2.transform.position = bcover2.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			bird2Correct = true;
		} else {
			bird2.transform.position = bird2InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropbird3()
	{
		float Distance = Vector3.Distance (bird3.transform.position, bcover3.transform.position);
		if (Distance < 50) {
			bird3.transform.position = bcover3.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			bird3Correct = true;
		} else {
			bird3.transform.position = bird3InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropbird4()
	{
		float Distance = Vector3.Distance (bird4.transform.position, bcover4.transform.position);
		if (Distance < 50) {
			bird4.transform.position = bcover4.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			bird4Correct = true;
		} else {
			bird4.transform.position = bird4InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropbird5()
	{
		float Distance = Vector3.Distance (bird5.transform.position, bcover5.transform.position);
		if (Distance < 50) {
			bird5.transform.position = bcover5.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			bird5Correct = true;
		} else {
			bird5.transform.position = bird5InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropbird6()
	{
		float Distance = Vector3.Distance (bird6.transform.position, bcover6.transform.position);
		if (Distance < 50) {
			bird6.transform.position = bcover6.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			bird6Correct = true;
		} else {
			bird6.transform.position = bird6InitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}




	
	// Update is called once per frame
	void Update()
	{
		if (bird1Correct && bird2Correct && bird3Correct && bird4Correct && bird5Correct && bird6Correct) {
			//source.clip = win;
			//source.Play ();
			winText.SetActive (true);

		}
	}

}
