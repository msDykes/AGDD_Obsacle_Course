using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody rb = null;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(" Welcome to my game!");
        Debug.Log("Move with WASD and dodge stuff.");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")  * moveSpeed;
        float zValue = Input.GetAxis("Vertical")   * moveSpeed;
        //this.transform.Translate(xTranslate, 0, zTranslate);
        rb.velocity = new Vector3(xValue, 0, zValue);
    }
}
