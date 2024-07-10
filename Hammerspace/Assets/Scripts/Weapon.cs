using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{

    public int damage = 1;
    int swingTime = 1;


    public Weapon(){

        damage = 1;
        swingTime = 1;

    }

    public Weapon(int damage, int swingTime) {

        this.damage = damage;
        this.swingTime = swingTime;

    }

    // figure out spawning weapon and damage
    // numbers placeholders
    public void swing() {
        Debug.Log("swing! " + damage);
    }

    public void special() {
        Debug.Log("special! " + damage*2);
    }


}
