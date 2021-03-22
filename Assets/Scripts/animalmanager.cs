using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalmanager : MonoBehaviour {

	// Use this for initialization

	public GameObject tiger,rabbit,panda,snake,dog,cat,pcover,ccover,dcover,rcover,tcover,scover, winText;
	Vector3 catInitialPos,dogInitialPos,snakeInitialPos,pandaInitialPos,rabbitInitialPos,tigerInitialPos;
	public AudioSource source;
	public AudioClip[] correct;
	public AudioClip incorrect;
	//public AudioClip win;
	public static bool catCorrect, dogCorrect, snakeCorrect, pandaCorrect, rabbitCorrect,tigerCorrect = false;



	void Start () {
		catInitialPos = cat.transform.position;
		dogInitialPos = dog.transform.position;
		snakeInitialPos = snake.transform.position;
		pandaInitialPos = panda.transform.position;
		tigerInitialPos =tiger.transform.position;
		rabbitInitialPos =rabbit.transform.position;
		winText.SetActive (false);
	}


	public void dragCat()
	{
		cat.transform.position = Input.mousePosition;
	}

	public void dragDog()
	{
		dog.transform.position = Input.mousePosition;
	}

	public void dragPanda()
	{
		panda.transform.position = Input.mousePosition;
	}

	public void dragRabbit()
	{
		rabbit.transform.position = Input.mousePosition;
	}

	public void dragSnake()
	{
		snake.transform.position=Input.mousePosition;
	}

	public void dragTiger()
	{
		tiger.transform.position=Input.mousePosition;
	}

	public void dropCat()
	{
		float Distance = Vector3.Distance (cat.transform.position, ccover.transform.position);
		if (Distance < 50) {
			cat.transform.position = ccover.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			catCorrect = true;
		} else {
			cat.transform.position = catInitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropDog()
	{
		float Distance = Vector3.Distance (dog.transform.position, dcover.transform.position);
		if (Distance < 50) {
			dog.transform.position = dcover.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			dogCorrect = true;
		} else {
			dog.transform.position = dogInitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropSnake()
	{
		float Distance = Vector3.Distance (snake.transform.position, scover.transform.position);
		if (Distance < 50) {
			snake.transform.position = scover.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			snakeCorrect = true;
		} else {
			snake.transform.position = snakeInitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropPanda()
	{
		float Distance = Vector3.Distance (panda.transform.position, pcover.transform.position);
		if (Distance < 50) {
			panda.transform.position = pcover.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			pandaCorrect = true;
		} else {
			panda.transform.position = pandaInitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropRabbit()
	{
		float Distance = Vector3.Distance (rabbit.transform.position, rcover.transform.position);
		if (Distance < 50) {
			rabbit.transform.position = rcover.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			rabbitCorrect = true;
		} else {
			rabbit.transform.position =rabbitInitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}

	public void dropTiger()
	{
		float Distance = Vector3.Distance (tiger.transform.position, tcover.transform.position);
		if (Distance < 50) {
			tiger.transform.position = tcover.transform.position;
			source.clip = correct [Random.Range (0, correct.Length)];
			source.Play ();
			tigerCorrect = true;
		} else {
			tiger.transform.position = tigerInitialPos;
			source.clip = incorrect;
			source.Play ();
		}
	}





	// Update is called once per frame
	void Update()
	{
		if (catCorrect && dogCorrect && snakeCorrect && pandaCorrect && rabbitCorrect && tigerCorrect) {
			//source.clip = win;
			//source.Play ();
			winText.SetActive (true);

		}
	}

}

