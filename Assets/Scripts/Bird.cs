using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private bool isDead;
    private Rigidbody2D rb2d;
    private Animator anim;
    public float upForce = 200f;

    private RotateBird rotateBird;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rotateBird = GetComponent<RotateBird>();
    }

    void Update()
    {
        if (isDead) return;

        // Detectar clic del rat�n o toque en pantalla
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            if (Input.touchCount > 0)
            {
                // Toque en pantalla (m�vil)
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    TriggerJump();
                }
            }
            else
            {
                // Clic del rat�n (PC)
                TriggerJump();
            }
        }
    }

    private void TriggerJump()
    {
        rb2d.velocity = Vector2.zero; // Reinicia la velocidad
        rb2d.AddForce(Vector2.up * upForce); // Aplica fuerza hacia arriba
        anim.SetTrigger("Flap"); // Activa la animaci�n de "Flap"

        // Reproducir el sonido del salto si est� configurado
        SoundSystem.instance.PlayFlap();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true; // Marca al p�jaro como muerto
        anim.SetTrigger("Die"); // Activa la animaci�n de "Die"
        rotateBird.enabled = false; // Desactiva la rotaci�n del p�jaro
        GameController.instance.BirdDie(); // Notifica al GameController
        rb2d.velocity = Vector2.zero; // Detiene el movimiento del p�jaro
        SoundSystem.instance.PlayHit(); // Reproduce el sonido del impacto
    }
}
