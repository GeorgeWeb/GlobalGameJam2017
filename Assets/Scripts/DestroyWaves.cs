﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWaves : MonoBehaviour
{
    private void Update()
    {
        Destroy(this.gameObject, 3.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != null && !collision.gameObject.CompareTag("Finish"))
        {
            if (collision.gameObject.GetComponent<GameBlockMatI>() != null)
                collision.gameObject.GetComponent<GameBlockMatI>().HitObject();

            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("Moveable"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("mPlatform"))
        {
            if (collision.gameObject.GetComponent<GameBlockMatI>() != null)
                collision.gameObject.GetComponent<GameBlockMatI>().HitObject();
            
            Destroy(this.gameObject);
        }
    }
}