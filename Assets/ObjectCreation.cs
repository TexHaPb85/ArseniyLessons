using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreation : MonoBehaviour
{
    public GameObject[] gameObjects;
    private GameObject instObject;

    void Start()
    {
        int rand = Random.Range(0, gameObjects.Length-1);
        Instantiate(gameObjects[rand], new Vector3(0, 0, 0), Quaternion.identity);//Quaternion.identity-обьект будет иметь все те же пареметры по позиции что и копируемый
        instObject = Instantiate(gameObjects[rand], new Vector3(0,0,0), Quaternion.identity) as GameObject;
        instObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    }

    void Update()
    {
        
    }
}
