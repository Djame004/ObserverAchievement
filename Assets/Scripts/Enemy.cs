using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    public static event Action OnEnemyKilled;

    private void OnDisable()
	{
        OnEnemyKilled?.Invoke();
    }
}
