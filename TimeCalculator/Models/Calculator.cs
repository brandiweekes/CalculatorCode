﻿namespace CalculatorCode.Models
{
    public abstract class Calculator
    {
        public object InputOne { get; set; }
        public object InputTwo { get; set; }
        public object Result { get; set; }

        //public virtual TimeSpan CalculateTimeSpanResult();
        //public virtual int CalculateIntResult();
    }
}
