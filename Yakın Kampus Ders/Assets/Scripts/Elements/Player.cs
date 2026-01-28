using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameDirector gameDirector;
    public Animator animator;
    public float speed;

    public bool isAppleCollected;
    private bool _isCharacterWalking;

    private Rigidbody _rb;

    public void RestartPlayer()
    {
        gameObject.SetActive(true);
        _rb = GetComponent<Rigidbody>();
        _rb.position = new Vector3(-0.6f, 0, -6);
        isAppleCollected = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            gameDirector.levelManager.AppleCollected();
            isAppleCollected = true;
        }
        if (other.CompareTag("Door") && isAppleCollected)
        {
            gameDirector.LevelCompleted();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 7;
            SetWalkAnimationSpeed(1.75f);
        }
        else
        {
            speed = 4;
            SetWalkAnimationSpeed(1f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (direction.magnitude < .1f)
        {
            TriggerIdleAnimation();
        }
        else
        {
            TriggerWalkAnimation();
        }

        transform.LookAt(transform.position + direction);
        _rb.linearVelocity = direction.normalized * speed;
    }

    void TriggerWalkAnimation()
    {
        if (!_isCharacterWalking)
        {
            animator.SetTrigger("Walk");
            _isCharacterWalking = true;
        }
    }

    void TriggerIdleAnimation()
    {
        if (_isCharacterWalking)
        {
            animator.SetTrigger("Idle");
            _isCharacterWalking = false;
        }
    }

    void SetWalkAnimationSpeed(float s)
    {
        animator.SetFloat("WalkSpeedMultiplier", s);
    }

}