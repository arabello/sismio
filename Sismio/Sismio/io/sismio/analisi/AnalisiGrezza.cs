﻿using System;

namespace Sismio.io.sismio.analisi
{
    // TODO
    public class AnalisiGrezza: Analisi
    {
        public override void Analizza(int[] buffer)
        {
            Console.WriteLine(string.Join(",", buffer));
        }
    }
}