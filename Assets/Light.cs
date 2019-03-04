using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>(); //беру компонент лайт у обьекта к которому прикреплен этот скрипт
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))//проверка нажатия на пробел
        {
            light.enabled = !light.enabled;
        }
    }
}
