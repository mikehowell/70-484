﻿namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_64
    {
        [TestMethod]
        public void Main() 
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++ )
            {
                Console.Write(values[index]);
            }
        }
    }
}
