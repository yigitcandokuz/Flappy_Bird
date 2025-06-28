using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public float ziplamaAraligi;
    Rigidbody2D rb;
    public TMP_Text skor_text;
    public float skor;
    public AudioClip coinClip;
    public AudioClip gameOverClip;
    AudioSource audioSource;
    public GameObject gameOverPanel;

    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        skor = 0;
        audioSource = GetComponent<AudioSource>();
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * ziplamaAraligi;
        }

        skor_text.text = skor.ToString();
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Scorer")
        {
            skor++;
            audioSource.PlayOneShot(coinClip);
        }
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "pipe")
        {
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true);
            audioSource.PlayOneShot(gameOverClip);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("MaýnMenu");
    }
}








