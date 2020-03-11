using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Turret;
    private Rigidbody RB;
    public float speed = 10f;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(transform.forward * speed, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision other) {
        Instantiate(Turret, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
