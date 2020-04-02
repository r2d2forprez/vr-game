using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class Health : MonoBehaviour
{

    public const int maxHealth = 100;
    public bool destroyOnDeath;

    //[SyncVar(hook = "OnChangeHealth")]
    public int currentHealth = maxHealth;
    public GameObject healthPack;
    public RectTransform healthBar;
    private bool isLocalPlayer;

    public bool isServer { get; private set; }

    //private NetworkStartPosition[] spawnPoints;

    void Start()
    {
        gameObject.SetActive(true);
        if (isLocalPlayer)
        {
            //spawnPoints = FindObjectsOfType<NetworkStartPosition>();
        }
    }

    public void TakeDamage(int amount)
    {
        if (!isServer)
            return;

        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            if (destroyOnDeath)
            {
                
                GameObject heal = Instantiate(healthPack, gameObject.transform.position, gameObject.transform.rotation);
                this.enabled = false;
                Destroy(gameObject);
            }
            else
            {
                currentHealth = maxHealth;

                // called on the Server, invoked on the Clients
                //RpcRespawn();
            }
        }
    }

    void OnChangeHealth(int currentHealth)
    {
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
    }

    private void Update()
    {
        
    }
    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        healthBar.localScale = new Vector3 (currentHealth / maxHealth, 1,1);
       
    }

    // [ClientRpc]
    //void RpcRespawn()
    //{
    //    if (isLocalPlayer)
    //    {
    //        // Set the spawn point to origin as a default value
    //        Vector3 spawnPoint = Vector3.zero;

    //        // If there is a spawn point array and the array is not empty, pick one at random
    //        if (spawnPoints != null && spawnPoints.Length > 0)
    //        {
    //            spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    //        }

    //        // Set the player’s position to the chosen spawn point
    //        transform.position = spawnPoint;
    //    }
}
