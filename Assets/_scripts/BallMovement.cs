using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    float _initialSpeed;
    public float _speed;
    public float _maxSpeed = 30f;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        _initialSpeed = _speed;
        RandDirection();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + direction * _speed * Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            this.transform.position = Vector3.zero;
            RandDirection();
        }
    }

    void RandDirection()
    {
        float angle = Random.Range(0, 180f);
        // clamp values between 0 and 1
        // TODO: eu esperava que a bola fosse apenas para frente
        // mas está indo para trás também
        // conferir eixo z apenas positivo
        direction = new Vector3(Mathf.Cos(angle), Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
    }

    void OnCollisionEnter(Collision other)
    {
        if (_speed < _maxSpeed)
        {
            _speed += .5f;
        }
        if (other.transform.CompareTag("Player"))
        {
            _speed = _initialSpeed;
            FindObjectOfType<PlayerScore>().GainScore(10);
        }
        if (other.transform.CompareTag("Defender"))
        {
            // TODO: subtrair pontuação? Encerrar o jogo?
            FindObjectOfType<PlayerHealth>().TakeDamage();
        }
        direction = Vector3.Reflect(direction, other.contacts[0].normal);
    }
}
