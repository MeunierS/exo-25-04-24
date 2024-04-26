using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHairColor : MonoBehaviour
{
    public Material[] material;
    [HideInInspector] public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        int rndIndex = Random.Range(0, material.Length);
        rend.sharedMaterial = material[rndIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
