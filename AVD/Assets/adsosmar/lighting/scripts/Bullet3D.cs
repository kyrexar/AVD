using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    public LayerMask layermask;
    public GameObject Explosion;
    public float speed = 80f;
    public float time = 3f;
    private Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, time);
    }

    private void OnCollisionEnter(Collision info)
    {
            Instantiate(Explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
    }
}
