using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GroundEnemyController : MonoBehaviour
{
    public float moveSpeed;
    LevelManager instance;

    void Start()
    {
        instance = FindObjectOfType<LevelManager>();
    }

    void Update()
    {
            transform.Translate(new Vector3(moveSpeed / 2, 0, 0) * Time.deltaTime);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bounce"))
            moveSpeed *= -1;

        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerController>().Reset();
            instance.lives--;
        }
           
    }
}