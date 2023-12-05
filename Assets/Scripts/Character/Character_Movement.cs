using UnityEditor;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 12f;

    private Animator animator;
    public float poto;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical) * velocidad;
        rb.velocity = new Vector2(movimiento.x, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            Saltar();
        }

        animator.SetFloat("speed", movimientoHorizontal);
    }

    private void Saltar()
    {
        rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
    }
}
