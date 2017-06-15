using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour {

    private Enemy_Master enemyMaster;
    public int enemyHealth = 100;
    public static int  score ;
    private Animator myAnimator;
   

    void SetIntialReferance()
    {
        enemyMaster = GetComponent<Enemy_Master>();
        
        if (GetComponent<Animator>() != null)
        {
            myAnimator = GetComponent<Animator>();

        }
        score = 0;
    }
    private void OnEnable()
    {
        SetIntialReferance();
        enemyMaster.EventEnemyDedectHealth += DeductionHealth;
    }
    private void OnDisable()
    {
        enemyMaster.EventEnemyDedectHealth -= DeductionHealth;
    }
    private void DeductionHealth(int health)
    {
        enemyHealth -= health;
        if (enemyHealth <= 0)
        {
           
            enemyHealth = 0;
            Debug.Log("Enemy Destrou");
           enemyMaster.CallEventEnemyDie();
           
           //s DisableAnimator();
           Destroy(gameObject, 4f);
            score+=10;
        }
    }

    void DisableAnimator()
    {

        if (myAnimator != null)
        {

            if (myAnimator.enabled)
            {

                myAnimator.SetTrigger("death");
                gameObject.transform.position = new Vector3(transform.position.x, 0.3f, transform.position.z);
                Debug.Log("Enemy Die");
            }
            // myAnimator.enabled = false;
        }
    }


}
