using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject obj;
    private GameObject inst_obj;
    [SerializeField]
    private float speed = 4f;

    void Start()
    {
        //inst_obj = Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    void Update()
    {
        float zPos = Input.GetAxis("Vertical");

        inst_obj.transform.Translate(Vector3.forward * speed * zPos * Time.deltaTime);
    }

    /*void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
    }

    private void OnCollisionExit(Collision collision)
    {
        transform.localScale = new Vector3(transform.localScale.x * 2f, transform.localScale.y * 2f, transform.localScale.z / 2f);
    }*/

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
    }


}
