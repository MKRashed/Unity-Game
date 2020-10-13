using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    
    public PlayerMovement movement;
    public GameManager gameManager;
    public Scoring scoreOver;
    public Text gameOver;
    public float timeT;

    void OnCollisionEnter(Collision hit)
    {
        if(hit.collider.tag == "obstracals")
        {
            Debug.Log("Player collied with somethings!");
            gameOver.text = timeT.ToString("Game Over !! Final Time:0 ");
            movement.enabled = false;
            scoreOver.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeT = timeT + Time.deltaTime;
        
    }
}
