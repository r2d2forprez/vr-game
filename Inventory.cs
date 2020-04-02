using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Inventory : MonoBehaviour
{
    public List<Item> list = new List<Item>();
    public GameObject player;
    public GameObject inventoryPanel;

    public static Inventory instance;

    void updatePanelSlots()
    {
        int index = 0;
        foreach(Transform child in inventoryPanel.transform)
        {

            InventorySlotController slot = child.GetComponent<InventorySlotController>();

            if (index < list.Count)
            {
                slot.item = list[index];
            }
            else
            {
                slot.item = null;
            }

            slot.updateInfo();
            //Update slot[index]'s name and icon...
            index++;
        }
    }

     void Start()
    {
        instance = this;
        updatePanelSlots(); 
    }

    public void Add(Item item)
    {
        if (list.Count < 30)
        {
            list.Add(item);
        }
        updatePanelSlots();
    }

    public void Remove(Item item)
    {
        list.Remove(item);
        updatePanelSlots();
    }
    

}
