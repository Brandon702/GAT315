using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxShape : Shape
{
    public override eType type => eType.Box;
    public override float size { get => transform.localScale.x; set => transform.localScale = Vector2.one * value; }
    public override float mass => (size * size) * density;
}
