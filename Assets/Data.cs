﻿using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Data {

    private static readonly int[] digitLengths = { 4, 3, 3, 5, 4, 4, 3, 5, 5, 4 };
    private const string pi = "31415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491";



    public static readonly Func<int, string, bool>[,] rules = new Func<int, string, bool>[5, 5]
    {
        {
            (v, str) => v % str.Sum(ch => digitLengths[ch - 1]) == 0,
            (v, str) => pi.Contains(str),
            (v, str) => Math.Log(v + 1, 2) % 1 == 0,
            (v, str) => true,
            (v, str) => true,
        },
        {
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
        },
        {
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
        },
        {
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
        },
        {
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
            (v, str) => true,
        },


    }
}
