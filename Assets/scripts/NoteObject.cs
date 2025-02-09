using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool validHit;
    public KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown(key))
    {
        if (validHit)
        {
            // Add check for null before destroying the object
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("NoteObject is null when attempting to destroy!");
            }
        }
    }
}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            validHit = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            validHit = false;
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
