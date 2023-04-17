using System;

public class Solver:ISolve
{

    string output;
    void Accumulate(string s)
    {
         output+= s;
    }

    void Clear()
    {
        output = "";
    }

    double Solve()
    {

    }
}