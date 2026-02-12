using System.Numerics;
using System.Xml.Serialization;
using UnityEngine;

public class Vector3D : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    Vector3D()
    {
        x = 2f;
        y = 4f;
        z = 6f;
    }

    Vector3D(float x, float y, float z)
    {
        x = 1;
        y = 5;
        z = 3;
    }

    public float Magnitud()
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    Vector3D(float modulo, float aplhaX, float alphaY, float alphaZ)
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

    public Vector3D Suma(Vector3D vector)
    {

        float sumaX = this.x + vector.x;
        float sumaY = this.y + vector.y;
        float sumaZ = this.z + vector.z;
        return new Vector3D(sumaX, sumaY, sumaZ);
    }

    public Vector3D Resta(Vector3D vector)
    {
        float restaX = this.x - vector.x;
        float restaY = this.y - vector.y;
        float restaZ = this.z - vector.z;
        return new Vector3D(restaX, restaY, restaZ);
    }

    public void Escalar(float number)
    {
        x *= number;
        y *= number;
        z *= number;
    }

    public float ProductoEscalar(Vector3D vector)
    {
        float multX = this.x * vector.x;
        float multY = this.y * vector.y;
        float multZ = this.z * vector.z;
        float sumaProdE = multX + multY + multZ;

        return sumaProdE;
    }

    public Vector3D ProductoVectorial(Vector3D vector)
    {
        float xv = (this.y * vector.z) - (this.z * vector.y);
        float yv = (this.z * vector.x) - (this.x * vector.z);
        float zv = (this.x * vector.y) - (this.y * vector.x);

        return new Vector3D(xv, yv, zv);
    }
    void Start()
    {
        Vector3D vector3D = gameObject.AddComponent<Vector3D>();
        Vector3D vec = vector3D;
        Vector3D vec1 = new Vector3D(2.0f, 4.0f, 8.0f);
        Vector3D vec2 = new Vector3D(1.0f, 5.0f, 3.0f);

    }
}
