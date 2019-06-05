using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
	public Transform player;
	public NavMeshAgent agent;

    void FixedUpdate()
    {
        agent.SetDestination(player.transform.position);
    }

    void OnCollisionEnter(Collision arg)
    {
    	if(arg.gameObject.tag == "Bullet")
    	{
    		Destroy(gameObject);
            scoreText.score++;
    	}

        if(scoreText.score == 6)
        {
            SceneManager.LoadScene(0);
        }

        if(arg.gameObject.tag == "MainCamera")
        {
            hp.hpInt--;
        }

        if(hp.hpInt == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
