﻿using System;

public interface IChargeable
{
    public void Charge()
    {
        Console.WriteLine("Charging...");
    }
    public string GetInfo()
    {
        return string.Empty;
    }
}