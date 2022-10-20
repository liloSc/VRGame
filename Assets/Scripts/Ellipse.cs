using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
public class Ellipse : MonoBehaviour
{
    public Vector2 radius = new Vector2(1f, 1f);
    public float width = 1f;
    public float rotationAngle = 45;
    public int resolution = 500;

    private LineRenderer self_lineRenderer;

    [Range(3, 36)]
    public int segments;
    public float xAxis = 5f;
    public float yAxis = 3f;


    void OnValidate()
    {
        UpdateEllipse();
    }

    public void UpdateEllipse()
    {
        if (self_lineRenderer == null)
            self_lineRenderer = GetComponent<LineRenderer>();

        self_lineRenderer.SetVertexCount(resolution + 3);

        self_lineRenderer.SetWidth(width, width);

        CalculateEllipse();
    }


    void CalculateEllipse()
    {
        Vector3[] points = new Vector3[segments + 1];
        for (int i = 0; i < segments; i++)
        {
            float angle = ((float)i / (float)segments) * 360 * Mathf.Deg2Rad;
            float x = Mathf.Sin(angle) * xAxis;
            float y = Mathf.Cos(angle) * yAxis;
            points[i] = new Vector3(x, y, 0f);
        }
        points[segments] = points[0];

        self_lineRenderer.positionCount = segments + 1;
        self_lineRenderer.SetPositions(points);
    }
}