﻿using System;

namespace PrototypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            WeeklyLog log_previous, log_new;
            log_previous = new WeeklyLog();
            Attachment attachment = new Attachment();
            log_previous.Attachment = attachment;
            log_new = log_previous.Clone();
            Console.WriteLine("周报是否相同？{0}", (log_previous == log_new) ? "是" : "否");
            Console.WriteLine("附件是否相同？{0}", (log_previous.Attachment == log_new.Attachment) ? "是" : "否");
            Console.Read();
        }
    }
}
