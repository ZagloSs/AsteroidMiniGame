using System.Linq;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    public float life = 3;

    private ChangeScore cs;
 
    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
