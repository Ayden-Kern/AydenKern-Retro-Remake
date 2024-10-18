using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level1");
        }
        
    }
}
