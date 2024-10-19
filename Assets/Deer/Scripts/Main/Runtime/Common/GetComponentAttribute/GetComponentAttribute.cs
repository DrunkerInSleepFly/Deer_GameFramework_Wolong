using System;


[AttributeUsage(AttributeTargets.Field)]
public class GetComponentAttribute : Attribute
{
    public GetComponentFrom ComponentAddress { get; }
    public string TargetName { get; }

    public GetComponentAttribute(GetComponentFrom address = GetComponentFrom.Self, string objectName = "")
    {
        ComponentAddress = address;
        TargetName = objectName;
    }
}

