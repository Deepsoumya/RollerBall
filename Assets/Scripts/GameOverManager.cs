using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
	//public Text countText;
	public BallController Count;
	public float restartDelay = 5f;

	Animator anim;
	float restartTimer;

	private void Start(){
		anim = GetComponent<Animator>();
	}

	void Update(){
        if (Count.count >= 2)
        {
            anim.SetTrigger("GameOver");
            restartTimer += Time.deltaTime;

            /*if(restartTimer >= restartDelay){
            	Application.LoadLevel(Application.loadedLevel);
            }*/
        }
	}
}