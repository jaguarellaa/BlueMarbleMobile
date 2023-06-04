using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator Anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadLevel(int LevelNumber)
    {
        Anim.SetTrigger("End");

        yield return new WaitForSeconds(0.3f);

        SceneManager.LoadScene(LevelNumber);
    }
}
