using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Transform Player;
	public Text scoreText;
    public float pos;
    public float timeC;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeC = timeC + Time.deltaTime;
        pos = 234.5f;
        //scoreText.text = (pos + Player.position.z).ToString("Distance: .00");
        scoreText.text = timeC.ToString("Time: .00");
        if(Player.position.z > 238)
        {
            scoreText.text = " levelComplet !!";
        }
    }
}
