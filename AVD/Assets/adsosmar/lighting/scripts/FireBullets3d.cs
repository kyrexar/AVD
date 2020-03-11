using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets3d : MonoBehaviour
{
    // Start is called before the first frame update
    public float frequency = 0.1f;
    public float time = 3f;
    public Animator animator;
    public GameObject Bullet3d;
    public Transform[] BulletPositions;
    public Animator[] GunsAnimators;
    void Start()
    {
        StartCoroutine(Fire());
        transform.rotation = Quaternion.Euler(0, transform.rotation.y, transform.rotation.z);
        StartCoroutine(Die());
    }
    private int i=0;
    IEnumerator Fire()
    {
        //GunsAnimators[i].SetTrigger("Fire");

        Instantiate(Bullet3d, BulletPositions[i].position, BulletPositions[i].rotation);
        i++;
        if (i >= BulletPositions.Length) i = 0;
        yield return new WaitForSeconds(frequency);
            
        StartCoroutine(Fire());
    }

    IEnumerator Die(){
        yield return new WaitForSeconds(time);
        OnDisable();
        animator.SetBool("isDead",true);
        Destroy(gameObject,1f);
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
