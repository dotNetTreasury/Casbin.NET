﻿namespace Casbin.Model;

public interface IRequestValues
{
    public string this[int index] { get; }

    public int Count { get; }
}
