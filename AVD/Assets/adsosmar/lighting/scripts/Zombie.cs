using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 5f;
    public Animator animator;
    private bool notDead;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,15f);
        notDead=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(notDead){
            transform.position = transform.position + new Vector3(0,0,speed*Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision info)
    {
        Die();
    }

    void Die(){
        notDead=false;
        animator.SetBool("isDead",true);
        Destroy(gameObject,7f);
    }
}
