using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject obj;

    public float moveSpeed=3f;
    public float turnSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update(){
        respawn();
        allDirectionMovement();
        allDirectionRotation();
        changeSkinColor();
        activityManagement();
        
    }

    void activityManagement()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (obj.active == true)
            {
                obj.SetActive(false);
            } 
            else//if (obj.active == false)
            {
                obj.SetActive(true);
            }    
        }
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            Destroy(obj);
        }
    }

    void changeSkinColor()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    void allDirectionRotation()
    {
        if (Input.GetKey(KeyCode.A))
            obj.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.D))
            obj.transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
    }

    void allDirectionMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);//Time.deltaTime нужен для плавного передвижения обьекта
        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    void respawn()
    {
        //float h = Input.GetAxis("Horizontal");// отслеживает нажание клавиш A or D left right
        //file->project setting -> input -> Axis(оси)
        if (Input.GetKey(KeyCode.Q)){
            obj.transform.position = new Vector3(0, 0, 0);
            obj.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private void OnMouseDown() //срабатывает при нажатии на какой-то твердый обьект с колайдером
    {
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);
    }

    private void OnMouseUpAsButton()
    {
        
    } //нажать кнапку наведя мышку на обьект и отпустить ее не уводя с обьекта
}
