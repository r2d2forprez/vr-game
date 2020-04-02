using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{

    public int index;
    public string levelName;

    public Image black;

    public Animator anim;
    public void ButtonStart()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Continue()
    {
        SceneManager.LoadScene("Scene_3");
    }

    public void Try()
    {
        SceneManager.LoadScene("Menu");
    }






    // Start is called before the first frame update
    void OnTriggerEnter(Collider boxCollider)
    {
        if (boxCollider.gameObject.CompareTag("Player"))
        {

            //StartCoroutine(Fading());
            Debug.Log("hi");
            //loading level with scene name
            SceneManager.LoadScene("Scene_2");
        }
    }



    //IEnumerator Fading()
    //{
    //    anim.SetBool("Fade", true);
    //    yield return new WaitUntil(() => black.color.a == 1);
    //    SceneManager.LoadScene("Scene_2");
    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

}