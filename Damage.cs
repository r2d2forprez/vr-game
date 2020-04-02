using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("deathTimer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator deathTimer()
    //{
    //    yield return new WaitForSeconds(5);
    //    Destroy(gameObject);
    //}

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null && collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Player>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
