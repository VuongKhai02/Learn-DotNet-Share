using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace dotnet6_Array_Generic_Collection
{
    internal class Prac_Indexer
    {
        //private int[] num;

        //public Prac_Indexer(int length)
        //{
        //    num = new int[length];  

        //}

        //public int this[int i]
        //{
        //    get
        //    {
        //        return num[i];  
        //    }
        //    set
        //    {
        //        num[i] = value; 
        //    }
        //}

        private Student[] stu;

        public Prac_Indexer(int length)
        {
            stu = new Student[length];
        }
        public Student this[int i]
        {
            get
            {
                return stu[i];
            }
            set
            {
                stu[i] = value;
            }
        }
    }
}
