using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Enemy")]
public class EnemyScriptable : ScriptableObject
{
    [Tooltip("How much health an enemy has. This is an int.")]
    public int enemyHealth = 1;
    [Tooltip("How far an enemy has to be before the attack starts. This is an int.")]
    public int enemyRange;
    [Tooltip("The amount of damage an enemy will do to the player. This is an int.")]
    public int enemyDamage = 1;
    [Tooltip("The amount of coins dropped by the enemy on death. This is an int.")]
    public int coinDropAmount = 1;
    [Tooltip("The prefab for the enemy type.")]
    public GameObject enemyPrefab;


    public void IncreaseEnemy()
    {
        enemyHealth++;
        enemyDamage += 2;
        coinDropAmount++;
    }

    
}
