using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_MS
{
    static class Generate_Random_Value
    {
        private static char stu = 'S',tea='T',off='O';

        private static int stuint = 20000,teaint=20000,offint=100000;

        public static string generate_Student_Id()
        {
            stuint += 1;
            return stu + "-" + stuint;

        }
        public static string generate_Official_Id()
        {
            offint += 13;
            return off + "-" + offint;
        }

        public static string generate_Teacher_Id()
        {
            teaint += 5;
            return tea + "-" + teaint;

        }
        public static int generate_Password()
        {
            Random r = new Random();
            return r.Next(100000, 999999);
        }
        public static void Increment_Student_Id()
        {
            stuint += 2;
        }
        public static void Increment_Teacher_Id()
        {
            teaint += 1;
        }
        public static void Increment_Officer_Id()
        {
            offint += 2;
        }

    }
}
