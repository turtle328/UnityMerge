using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const string k_HORIZONTAL = "Horizontal";
    const string good = "Vertical";

    [SerializeField]
    float moveSpeed = 10;

    Vector3 moveDelta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDelta.x = Input.GetAxis(k_HORIZONTAL);
        moveDelta.z = Input.GetAxis(k_VERTICAL);

        transform.Translate(moveDelta * moveSpeed * Time.deltaTime);
    }
}
