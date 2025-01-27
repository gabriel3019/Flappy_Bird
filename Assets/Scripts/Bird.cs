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

        // Detectar clic del ratón o toque en pantalla
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            if (Input.touchCount > 0)
            {
                // Toque en pantalla (móvil)
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    TriggerJump();
                }
            }
            else
            {
                // Clic del ratón (PC)
                TriggerJump();
            }
        }
    }

    private void TriggerJump()
    {
        rb2d.velocity = Vector2.zero; // Reinicia la velocidad
        rb2d.AddForce(Vector2.up * upForce); // Aplica fuerza hacia arriba
        anim.SetTrigger("Flap"); // Activa la animación de "Flap"

        // Reproducir el sonido del salto si está configurado
        SoundSystem.instance.PlayFlap();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true; // Marca al pájaro como muerto
        anim.SetTrigger("Die"); // Activa la animación de "Die"
        rotateBird.enabled = false; // Desactiva la rotación del pájaro
        GameController.instance.BirdDie(); // Notifica al GameController
        rb2d.velocity = Vector2.zero; // Detiene el movimiento del pájaro
        SoundSystem.instance.PlayHit(); // Reproduce el sonido del impacto
    }
}
