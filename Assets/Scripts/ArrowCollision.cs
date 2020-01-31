using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowCollision : MonoBehaviour
{

    public GameObject counter;




    // Start is called before the first frame update
 

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("projectile"))
        {
            this.gameObject.SetActive(false);
            counter.GetComponent<CounterScript>().Counterincrementer();



        }
    }


}


