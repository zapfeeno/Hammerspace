using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    
    public int health = 3;

    public void die() {

        Destroy(gameObject);

    }

    public void takeDamage(int amount) {
        health = health - amount;
        Debug.Log("ouch!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        if (health <= 0) {
            die();
        }
    }


}
