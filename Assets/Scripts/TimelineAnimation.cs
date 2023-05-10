using UnityEngine;

public class TimelineAnimation : MonoBehaviour
{
    private Rigidbody rb;
    private Transform tr;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }
    public void DestroyCylinder()
    {
        Destroy(this.gameObject);
    }
    public void GravityActivated()
    {
        rb.useGravity = true;
    }
    public void TransformScale()
    {
        Vector3 newScale = new Vector3(1, 3, 1);
        transform.localScale = newScale;
    }
}
