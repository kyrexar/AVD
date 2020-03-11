using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject SpawnerBall;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            Instantiate(SpawnerBall, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
