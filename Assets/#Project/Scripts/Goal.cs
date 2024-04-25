using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    public Pillar pillar;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        DoIActivate();
    }
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void DoIActivate(){
        //check if all 8 pillars are green, if yes activate goal pillar
        
        gameObject.SetActive(true);
    }
}
