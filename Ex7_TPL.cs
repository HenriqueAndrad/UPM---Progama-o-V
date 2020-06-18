using UnityEngine;
using System;
using System.Threading;
using System.Threading.Tasks;

public class Ex7_TPL : MonoBehaviour
{
    private void Awake()
    {
        System.Random random = new System.Random((int)DateTime.UtcNow.Ticks);
        Mesh malha = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = malha.vertices;
        Parallel.For(0, vertices.Length, (i) =>
        {
            vertices[i].x += (float)random.NextDouble() * 69.0f;
            vertices[i].y += (float)random.NextDouble() * 69.0f;
            vertices[i].z += (float)random.NextDouble() * 69.0f;
        });
        malha.vertices = vertices;
        malha.RecalculateNormals();
    }
}
