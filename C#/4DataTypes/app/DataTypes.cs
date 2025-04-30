/*
In C#, the Value Data Types will directly store the variable value in memory and it will also accept both signed and unsigned literals. 
*/

/*
+--------+----------------+------------------+-----------+---------------------+---------------+
| Alias  | Type Name      | Type             | Size(bits)| Range               | Default Value |
+--------+----------------+------------------+-----------+---------------------+---------------+
| sbyte  | System.SByte   | signed integer   | 8         | -128 to 127         | 0             |
| short  | System.Int16   | signed integer   | 16        | -32,768 to 32,767   | 0             |
| int    | System.Int32   | signed integer   | 32        | -2^31 to 2^31 - 1   | 0             |
| long   | System.Int64   | signed integer   | 64        | -2^63 to 2^63 - 1   | 0L            |
| byte   | System.Byte    | unsigned integer | 8         | 0 to 255            | 0             |
| ushort | System.UInt16  | unsigned integer | 16        | 0 to 65,535         | 0             |
| uint   | System.UInt32  | unsigned integer | 32        | 0 to 2^32 - 1       | 0             |
| ulong  | System.UInt64  | unsigned integer | 64        | 0 to 2^64 - 1       | 0             |
+--------+----------------+------------------+-----------+---------------------+---------------+
*/

using System;
using static System.Console;

namespace DataTypes{
    class DataTypes{
        static void Main(string[] args){
            //primitive
            //integers
            //sbyte
            sbyte sigbyte=124;
            WriteLine("sbyte="+sigbyte);
            //short
            short shrt=32000;
            WriteLine("short="+shrt); 
            //int 
            int num=2147483647; //8 not excepted 2^32
            WriteLine("int="+num);
            //long
            long lnum=2147483648; //8  excepted 2^64
            WriteLine("long="+lnum);
            //byte
            byte bnum=255;
            WriteLine("byte="+bnum);
            //ushort
            ushort us=65535;
            WriteLine("ushort=",us);
            //uint
            uint unum=2147483647; //8 not excepted
            WriteLine("uint="+unum);
            //ulong
            ulong ulnum=2147483648; //8  excepted
            WriteLine("ulong="+ulnum);

            //floating point
            float fnum=34.56f; //32bits
            WriteLine("float="+fnum);
            double dnum=3.142; //64bits
            WriteLine("double="+dnum);

            //Decimal type 128bit datatype suitable for financial 28-29 digit Percision, monetary calculations
            decimal decnum=1900000.00M;
            WriteLine("decimal="+decnum);

            //char represents a UTF-16 code
            char cvar='#';
            WriteLine("char="+cvar);

            //bool
            bool bvar=true;
            WriteLine("bool="+bvar);

            //Reference datatype contains memory addr of var value
            //string
            //object
            //pointer datatype ampersand (&) and asterisk (*).
        }
    }
}