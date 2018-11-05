using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField]
    private Stat health;
    private float initialHealth = 100;

    [SerializeField]
    private Stat mana;
    private float initialMana = 100;

    // Use this for initialization
    protected override void Start()
    {
        health.Initialise(initialHealth, initialHealth);
        mana.Initialise(initialMana, initialMana);
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        GetInput();

        // Call the Super/Inherited version of Update
        base.Update();
    }


    private void GetInput()
    {


        if (Input.GetKey(KeyCode.I))
        {
            health.MyCurrentValue -= 10;
            mana.MyCurrentValue -= 10;
        }

        if (Input.GetKey(KeyCode.O))
        {
            health.MyCurrentValue += 10;
            mana.MyCurrentValue += 10;
        }


        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }
}


