﻿using Microsoft.VisualBasic;
using System;
using System.Text;

namespace dotnet_3
{
    internal class lthdt
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            var person  = new Person();
            person.Gender = 1;
            person.dob = new DateTime(2000, 11, 20);
            //2
            person.Name = "Dev12112";
            person.email = "Dev@gmail.com.vn";
            person.phone = "0918230921";

            person.DisplayInfo();

            /*
            var a = person.GetName();
            Console.WriteLine(a);
            */
            
            var person2 = new Person();
            person2.Gender = 0;
            person2.dob = new DateTime(2003,04,14);
            //1
            person2.SetName("Dev2");
            person2.email = "Dev2@gmail.com.vn";
            person2.phone = "09210323";

            person2.DisplayInfo();
            person2.Run(2, new DateTime(2002,12,2));
        }
    }
}
