using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public Enemy enemy;
    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Awake(){
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    void Start()
    {
        RandomActivate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            //change color + adjacent ones
            ChangeColor();
            //todo adjacent change color
            //create a new enemy
            Instantiate(enemy, new Vector3(0, 1f, 0), Quaternion.identity);
        }
    }
    private void RandomActivate(){
        
        int rand = Random.Range(0, 2);
        if(rand !=0){
            //activate pillar in green
            rend.sharedMaterial = material[1];
        }
    }
    private void ChangeColor(){
        if(rend.sharedMaterial == material[1]){
                rend.sharedMaterial = material[0];
            }
            else{
                rend.sharedMaterial = material[1];
            }
    }
}