using Assets.Scripts;
using System;
using System.Collections.Generic;

public class Side
{
    public string SideName;
    public PlayerBase Base;
    public List<UnitEnrollment> UnitQueue = new List<UnitEnrollment>();

    public Side(string sideName, PlayerBase @base)
    {
        SideName = sideName;
        Base = @base;
    }
}