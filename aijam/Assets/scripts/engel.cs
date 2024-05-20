using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public GameObject player;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<newplayercontrol>().die();
        }
    }
   




}
