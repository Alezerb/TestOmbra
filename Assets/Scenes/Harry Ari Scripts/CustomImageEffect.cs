using UnityEngine;

[ExecuteInEditMode]
public class CustomImageEffect : MonoBehaviour
{

    public Material material;

    public void Start() => Camera.main.depthTextureMode = DepthTextureMode.DepthNormals;// depthnormals are needed for outline effect

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, material);
    }
}