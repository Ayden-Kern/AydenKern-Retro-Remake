using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public static event Action<Enemy> OnEnemyKilled;
    [SerializeField] float health, maxHealth = 1;
    public float moveSpeed ;
    Rigidbody2D _rb;
    private Transform target;
    Vector2 moveDirection;
    private Animator anim;
    public GameObject pointA;
    public GameObject pointB;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        _rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        target = pointB.transform;
        anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = target.position - transform.position;
        if(target == pointB.transform)
        {
            _rb.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            _rb.velocity = new Vector2(-moveSpeed, 0);
        }

        if (Vector2.Distance(transform.position, target.position) < 0.5f && target == pointB.transform)
        {
            target = pointA.transform;
        }
        if (Vector2.Distance(transform.position, target.position) < 0.5f && target == pointA.transform)
        {
            target = pointB.transform;
        }
    }
    public void TakeDamage(float damageAmount)
    {
        Debug.Log($"Damage Amount: {damageAmount}");
        health -= damageAmount;
        Debug.Log($"Health is now {health}");

        if (health <= 0)
        {
            Destroy(gameObject);
            OnEnemyKilled?.Invoke(this);
        }
    }
}
