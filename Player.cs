using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour {

 

    public int health;
    public int armor;
    internal static object instance;
    

    // public GameUI gameUI;

    // Use this for initialization
    void Start () {
		
	}

    void Menu()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            GameObject ip = Inventory.instance.inventoryPanel;

            if (!ip.activeSelf)
            {
                ip.SetActive(true);
            }
            else
            {
                ip.SetActive(false);
            }
        }
    }

    public void TakeDamage(int amount)
    {
        int healthDamage = amount;

        //if (armor > 0)
        //{
        //    int effectiveArmor = armor * 2;
        //    effectiveArmor -= healthDamage;

        //    // If there is still armor, don't need to process
        //    // health damage
        //    if (effectiveArmor > 0)
        //    {
        //        armor = effectiveArmor / 2;
        //        return;
        //    }

        //    armor = 0;
        //}

        health -= healthDamage;
        Debug.Log("Health is " + health);

        if (health <= 0)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("You_lose");
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, 2.68f, transform.position.z);
    }


    // 1
    private void pickupHealth()
    {
        
        Item item = new Item();
        item.name = "HealthPack";
        Inventory.instance.Add(item);
        //health += 50;
        if (health > 500)
        {
            health = 500;
        }
    }

    //private void pickupArmor()
    //{
    //    armor += 15;
    //}

    public void PickUpItem(int pickupType)
    {
        switch (pickupType)
        {
            //case Constants.PickUpArmor:
            //    pickupArmor();
            //    break;
            case Constants.PickUpHealth:
                pickupHealth();
                break;


        }
    }
}
