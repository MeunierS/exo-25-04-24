using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TMP_Text enemyCount;
    public TMP_Text portalActive;
    public Goal goal;
    [HideInInspector] public int count=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goal.goalActive){
            portalActive.SetText($"Portal is now Active !!!");
        }
        else{
            portalActive.SetText($"Portal is not active");
        }      
    }
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Pillar")){
            count++;
            enemyCount.SetText($"{count} fans are after you !");
        }
    }
}
