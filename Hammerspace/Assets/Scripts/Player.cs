using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 3;
    public Weapon weapon;
    public List<Weapon> wList = new List<Weapon>();
    int currWeapon = 0;
    
    public List<Entity> eList = new List<Entity>();

    // Start is called before the first frame update
    void Start()
    {
        if (weapon == null) {
            weapon = new Weapon(1,1);
            wList.Add(weapon);
        }

        wList.Add(new Weapon(999,2));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f")) {
            weapon.swing();
        }
        if(Input.GetKeyDown("e")) {
            weapon.special();
        }

        if(Input.GetKeyDown("q")) {
            switchWeapon();
        }

        if(health == 0) {
            die();
        }
    }

    void die() {
        Debug.Log("dead");
        Destroy(this.gameObject);
    }

    void switchWeapon() {
        if (currWeapon+1 < wList.Count) {
            weapon = wList[currWeapon+1];
            currWeapon++;
        }
        else {
            weapon = wList[0];
            currWeapon = 0;
        }
    }


    // figure out how to put this on a "weapon" that swings
    //  or instantiate it when swung
    void OnTriggerEnter2D(Collider2D other) {

        Debug.Log("entered");

        Entity target = other.gameObject.GetComponent<Entity>();
        if (target != null) {
            target.takeDamage(weapon.damage);
        }
        
    }

}
