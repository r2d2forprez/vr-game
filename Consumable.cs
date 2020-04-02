using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Consumable", menuName = "Items/Consumable")]
public class Consumable : Item
{
    public int heal = 0;

    public override void Use()
    {
        GameObject player = Inventory.instance.player;
        Health playerHealth = player.GetComponent<Health>();

        //have the Health script heal the player...
        playerHealth.Heal(heal);
        Inventory.instance.Remove(this);
    }

}
