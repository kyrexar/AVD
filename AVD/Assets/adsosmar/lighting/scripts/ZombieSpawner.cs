using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject Zombie;
    private float i;
    public float interval=2f;
    // Start is called before the first frame update
    void Start()
    {
        i=0;
    }

    // Update is called once per frame
    void Update()
    {
        i -=Time.deltaTime;
        if(i<0f){
            Instantiate(Zombie, gameObject.transform.position, gameObject.transform.rotation);
            i=interval;
        }
    }
}
