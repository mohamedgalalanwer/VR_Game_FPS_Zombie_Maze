﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLeve : MonoBehaviour {
    public GameObject UIgameObject;
    public Text scoreText;
    // Use this for initialization
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Enemy_Health.score < 150)
            {//to test
                UIgameObject.SetActive(true);
                scoreText.text = "Score : " + Enemy_Health.score;
               // return;
            }
            else if (Enemy_Health.score >= 100)
            {
                UIgameObject.SetActive(true);
                scoreText.text = "Score : " + Enemy_Health.score;

                StartCoroutine(WaitAndPrint());
            }
        }
    }

    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(1.5f);
        Application.LoadLevel("main");
    }

    }
