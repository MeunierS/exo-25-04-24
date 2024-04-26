using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    public Pillar[] pillars;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public bool TestIfAllGreen(){
        bool goalActive=false;
        //? for loop not working no idea why, 
        //? tried comparing material and !material, butnot even entering the loop as no debug log inside shows
        // for(int i = 0; i < 8; i++){
        //     if(pillars[i].rend.sharedMaterial.Equals(!material)){
        //         goalActive=false;
        //     }
        //     else
        //     {
        //         goalActive=true;
        //     }
        // }
        // return goalActive;
        if(pillars[0].rend.sharedMaterial.Equals(material)){
            if(pillars[1].rend.sharedMaterial.Equals(material)){
                if(pillars[2].rend.sharedMaterial.Equals(material)){
                    if(pillars[3].rend.sharedMaterial.Equals(material)){
                        if(pillars[4].rend.sharedMaterial.Equals(material)){
                            if(pillars[5].rend.sharedMaterial.Equals(material)){
                                if(pillars[6].rend.sharedMaterial.Equals(material)){
                                    if(pillars[7].rend.sharedMaterial.Equals(material)){
                                        goalActive=true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    return goalActive;
    }
    void OnTriggerEnter()
    {
        if(TestIfAllGreen()){
            SceneManager.LoadScene("MainMenu");
        }
    }
}

