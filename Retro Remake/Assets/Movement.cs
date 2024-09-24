using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S;
    public float speed = 10, jumpheight = 15, MaxSpeed = 30;
    public KeyCode jump = KeyCode.W;
    private Rigidbody2D _rb;
    [Header("Raycast")]

    [SerializeField] float dist; //raycast range
    [SerializeField] float downRange = -0.75f; //offset

    bool ground;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        dist = transform.localScale.y; //set dist
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            _rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(right))
        {
            _rb.AddForce(Vector2.right * speed * Time.deltaTime);
        } 
        if (Input.GetKey(up))
        {
            _rb.velocity = Vector2.up * speed;
        }
        if (Input.GetKeyDown(down))
        {
            _rb.velocity = Vector2.down * speed;
        }
        if (_rb.velocity.x > MaxSpeed)
            _rb.velocity = new Vector2 (MaxSpeed, _rb.velocity.y);
        if (_rb.velocity.x > MaxSpeed)
            _rb.velocity = new Vector2(-MaxSpeed, _rb.velocity.y);


        //orgin position * in the down dir downRange, direction, range
        bool ray = Physics2D.Raycast(transform.position + (Vector3.down * downRange), Vector2.down, dist);
        //bool ray = Physics2D.BoxCast(transform.position *())

        //print(ray);

        if (ray && Input.GetKeyDown(jump))
        {
            _rb.velocity = Vector2.up * jumpheight;
        }
        if (Input.GetKeyUp(jump))
        {
            _rb.velocity = new(_rb.velocity.x, _rb.velocity.y / 2);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position + (Vector3.down * downRange), transform.position + Vector3.down * dist);
    }
}
