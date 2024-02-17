using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public float coinValue;

    public LevelSystem levelScript;

    // Start is called before the first frame update
    void Start()
    {
        coinValue = 1f;
        levelScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<LevelSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            levelScript.currLevelProgress += coinValue;
            Destroy(gameObject, 0.1f);
        }
    }
}
