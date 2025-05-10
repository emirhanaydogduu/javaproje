using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Takip edilecek nesne (oyuncu)
    public float smoothSpeed = 0.125f; // Takip yumuşaklık derecesi
    public Vector3 offset; // Kamera ile oyuncu arasındaki mesafe

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }

    // Opsiyonel: Kamera offset'ini otomatik ayarlamak için
    void Start()
    {
        if (target != null)
        {
            offset = transform.position - target.position;
        }
    }
}