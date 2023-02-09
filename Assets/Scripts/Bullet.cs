using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    
private GameManager _gameManager;
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    private float _speed = 20f;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * _speed, 0);
            if (transform.position.y > 20)
            {
                Destroy(gameObject);
            }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            if (_gameManager != null)
                _gameManager.AddPoints();
        }
    }
}
