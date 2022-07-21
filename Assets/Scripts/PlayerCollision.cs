using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerScript playerscript;
    public Score score;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    public GameController gameController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    { 
        if(other.gameObject.tag == "Obstacles")
        {
            audioSource1.Play();
            gameController.GameOver();
            playerscript.enabled = false;
        }
    }
}
