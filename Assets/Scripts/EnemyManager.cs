using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies = new List<GameObject>();

    public bool IsAnyEnemyAlive()
    {
        foreach (var enemy in enemies)
        {
            if (enemy == null)
                continue;
            else
                return true;
        }

        return false;
    }
}
