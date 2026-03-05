using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    
    [SerializeField] private Transform firePoint;
    
    [SerializeField] private GameObject[] fireballs;

    private Animator anim;
    private PlayerMovement PlayerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        PlayerMovement = GetComponent<PlayerMovement>();

        private void Update()
        { 
            if (Input.GetmouseButton(0) && cooldownTimer > attackCooldown)
                 Attack();
            cooldownTimer += Time.deltaTime;
        }
    }
    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[0].transform.position = firePoint.position;
        fireballs[0].GetComponent<Fireball>projectileDirection(Mathf.Sign(transform.localScale.x));
}
