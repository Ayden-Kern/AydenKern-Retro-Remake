using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPM : MonoBehaviour
{
    public int score, coins, time;                          // Ints represent WHOLE NUMBERS
    public float speed, xPosition, yPosition;               // Floats rep DECIMAL NUMBERS
    public string menuLabel;                                // Strings Rep WORDS/PHRASES/TEXT
    public bool enemtyIsDead, isGrounded, isPlayerDead;     // Bools rep Values that are TRUE OR FALSE
    public Vector2 currentMovement, platformPosition, playerPostition, rotation; // Vector2's rep 2D DECIMALS
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
