using UnityEngine;

public class GrassInteractionCam : MonoBehaviour
{
    public Camera GameCam;
    public Camera grassCam;
    public float Height;
    public float resolution = 1024;

    private void Start()
    {

    }

    void ApplyGrassCamTransform()
    {
        if (!GameCam)
        {
            GameCam = Camera.main;
        }

        if (grassCam.depthTextureMode != DepthTextureMode.Depth)
        {
            grassCam.depthTextureMode = DepthTextureMode.Depth;
        }

        Vector3 newPosition = GameCam.transform.position + (Vector3.up * Height);
        newPosition.x = Mathf.Round(newPosition.x * resolution) / resolution;
        newPosition.y = Mathf.Round(newPosition.y * resolution) / resolution;
        newPosition.z = Mathf.Round(newPosition.z * resolution) / resolution;

        grassCam.transform.position = newPosition;
        grassCam.transform.eulerAngles = new Vector3(90, 0, 0);

        Shader.SetGlobalVector("_GrassCamPos", grassCam.transform.position);
        Shader.SetGlobalFloat("_GrassCamScale", grassCam.orthographicSize * 2);
    }


    private void FixedUpdate()
    {
        ApplyGrassCamTransform();
    }

    private void OnDrawGizmos()
    {
        ApplyGrassCamTransform();
    }
}
