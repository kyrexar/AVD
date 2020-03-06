using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3D : MonoBehaviour
{
    public LayerMask layermask;
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
    public void Die()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider info)
    {
        Debug.Log(info.gameObject.name);
        if //(info.gameObject.layer == Masks)
            (layermask == (layermask | (1 << info.gameObject.layer)))
        {
            RB.Sleep();//avoid more interactions
            GetComponent<Animator>().SetTrigger("Die");
            //it plays the animation to make an explotion and die
      
        }

    }
}
