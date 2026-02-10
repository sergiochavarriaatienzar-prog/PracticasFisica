using System.Xml.Serialization;
using UnityEngine;

public class Vector3D : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    public Vector3D v;
    public Vector3D u;


    Vector3D()
    {
        x = 0f;
        y = 0f;
        z = 0f;
    }

    Vector3D(float x, float y, float z)
    {
        x = 1;
        y = 4;
        z = 6;
    }

    public float Magnitud()
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    Vector3D(float modulo,float aplhaX, float alphaY, float alphaZ)
    {
        x = modulo * Mathf.Cos(aplhaX);
        y = modulo * Mathf.Cos(alphaY);
        z = modulo * Mathf.Cos(alphaZ);
    }

    public void Normalize()
    {
        float mag = Magnitud();
        x = x / mag;
        y = y / mag;
        z = z / mag;
    }

    public Vector3D Suma(Vector3D vec)
    {
        Vector3D vec1 = new Vector3D(1.0f, 2.0f, 3.0f);
        Vector3D vec2 = new Vector3D(2.0f, 1.0f, 0.0f);
        Vector3D vectorSuma = vec1.Suma(vec2);
        
        Vector3D resultadoSuma = new Vector3D();
        resultadoSuma.x = this.x + vec.x;
        return resultadoSuma;
    }

    public Vector3D Resta(Vector3D vec)
    {
        Vector3D vec1 = new Vector3D(10.0f, 20.0f, 30.0f);
        Vector3D vec2 = new Vector3D(15.0f, 8.0f, 22.0f);
        Vector3D vectorResta = vec1.Resta(vec2);
        return vectorResta;
    }

    public void Escalar(float number)
    {
        x *= number;
        y *= number;
        z *= number;
    }

    public float ProductoEscalar(Vector3D vec)
    {
        float[] v = { 2.0f, 4.0f, 5.0f };
        float[] u = { 1.0f, 8.0f, 3.0f };
        float resultadoPordE = 0f;

        for (int i = 0; i < 3; i++)
        {
            resultadoPordE += v[i] * u[i];
        }

        return resultadoPordE;
    }

    public Vector3D ProductoVectorial()
    {

        float xv = (v.y * u.z) - (v.z * u.y);
        float yv = (v.z * u.x) - (v.x * u.z);
        float zv = (v.x * u.y) - (v.y * u.x);

        return new Vector3D(xv, yv, zv);
    }
    void Start()
    {
        Vector3D vector3D = gameObject.AddComponent<Vector3D>();
        Vector3D vec = vector3D;
        Vector3D vec1 = new Vector3D(2.0f, 4.0f, 8.0f);
        Vector3D vec2 = new Vector3D(1.0f, 5.0f, 3.0f);
        Escalar(2.0f);
    }


    void Update()
    {
        
    }
}
