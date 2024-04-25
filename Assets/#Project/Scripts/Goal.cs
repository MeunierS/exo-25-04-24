using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    public Pillar[] pillar;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter()
    {
        if(pillar[0].rend.sharedMaterial.Equals(material)){
            if(pillar[1].rend.sharedMaterial.Equals(material)){
                if(pillar[2].rend.sharedMaterial.Equals(material)){
                    if(pillar[3].rend.sharedMaterial.Equals(material)){
                        if(pillar[4].rend.sharedMaterial.Equals(material)){
                            if(pillar[5].rend.sharedMaterial.Equals(material)){
                                if(pillar[6].rend.sharedMaterial.Equals(material)){
                                    if(pillar[7].rend.sharedMaterial.Equals(material)){
                                        SceneManager.LoadScene("MainMenu");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
