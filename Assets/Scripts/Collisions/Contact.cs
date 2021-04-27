using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public struct Contact
{
    public Body bodyA;
    public Body bodyB;
    public float depth;
    public Vector2 normal;
}

