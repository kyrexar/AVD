using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject SpawnerBall;
    public static bool TurretNotSpawned;
    // Start is called before the first frame update
    void Start()
    {
        TurretNotSpawned=true;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && TurretNotSpawned){
            Instantiate(SpawnerBall, gameObject.transform.position, gameObject.transform.rotation);
            TurretNotSpawned=false;
        }
    }
}
