using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * куратина - кусочек кода который выполниться через определенной время
 * 
 */
public class Coroutines : MonoBehaviour
{
  public GameObject obj;

	void Start () {
		Invoke ("Inst", 2f);//для выполнения 1 раз
	}

	void Update () {
		if (Input.GetKey (KeyCode.LeftAlt))
			StartCoroutine (instObj ());
	}

	void Inst () {
		Instantiate (obj, new Vector3 (UnityEngine.Random.Range (-10f, 10f), 0f, UnityEngine.Random.Range (-10f, 10f)), Quaternion.identity);
	}

	IEnumerator instObj () {//для  цыклического выполнения
		while (true) {
            int rand = UnityEngine.Random.Range(-10, 10);
			Instantiate (obj, new Vector3 (UnityEngine.Random.Range (-10f, 10f), 0f, UnityEngine.Random.Range (-10f, 10f)), Quaternion.identity);
			yield return new WaitForSeconds (1.5f);
		}
	}


}
