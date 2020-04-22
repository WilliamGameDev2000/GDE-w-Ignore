using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider Ball;
    public GameObject Coin;

    public bool collected = false;


    private void OnTriggerEnter(Collider other)
    {
        if(other == Ball)
        {
            Coin.SetActive(false);
            collected = true;
            FindObjectOfType<AudioManager>().Play("Collect");
        }
        
    }

}
