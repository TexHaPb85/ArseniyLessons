using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**
 * скрипты нужно подключать к обьектам в юнити
 */
public class script1 : MonoBehaviour{

    public int frameCount = 0;
    public int visable = 0;
    [SerializeField]//private но доступно в Unity
    private AudioSource audioSource;


    // Start is called before the first frame update
    //срабатывает при старте программы
    void Start()
    {
        print("hi");
    }

    private void Awake()
    {
        print("wake up!");
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per every frame
    void Update()
    {
        frameCount++;
        if (Input.GetKeyUp(KeyCode.S))
        {
            print("frames: " + frameCount);
            Destroy(audioSource);
        }
        
    }
}
