using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMover : MonoBehaviour {
    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    [SerializeField]
    private float speed = 1;

    // Update is called once per frame
    void Update () {
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (horizontal, vertical);

        transform.position += movement * Time.deltaTime * speed;
    }

    private void OnCollisionEnter (Collision collision) {
        // collision.collider
        SceneManager.LoadScene (0);
    }
}