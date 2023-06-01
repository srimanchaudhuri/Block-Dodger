using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeleter : MonoBehaviour
{

    [SerializeField] private float hardFactor = 20f;
    [SerializeField] private float deletePosition = 20f;
    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / hardFactor;
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -deletePosition)
        {
            Destroy(gameObject);
        }
    }
}
