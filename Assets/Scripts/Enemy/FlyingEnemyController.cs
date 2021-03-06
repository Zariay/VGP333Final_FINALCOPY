﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FlyingEnemyController : MonoBehaviour
{
    PlayerController player;
    public float moveSpeed;
    public float playerRange;
    public bool playerInRange;
    public LayerMask playerLayer;

    LevelManager instance;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        instance = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
        playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);
        if (playerInRange)
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerController>().Reset();
            instance.lives--;
        } 
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, playerRange);
    }
}
