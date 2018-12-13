using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            decimal course = 567;

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL
            bool charToBoolImplicit = sex;
            bool charToBoolExplicit = (bool)sex;
            bool ctbConverter = Convert.ToBoolean(sex);

            //1.3 CHAR to DECIMAL
            decimal ctdecIm = sex;
            decimal ctdecEx = (decimal)sex;
            decimal ctdecConv = Convert.ToDecimal(sex);

            //1.4 CHAR to INT
            int ctintIm = sex;
            int ctintEx = (int)sex;
            int ctintConv = Convert.ToInt16(sex);

            //2. STRING CONVERSION

            //2.1 STRING to CHAR
            char stcIm = name;
            char stcEx = string(name);
            char stcConv = Convert.ToString(name);

            //2.2 STRING to BOOL

            bool stbIm = name;
            bool stbEx = (bool)name;
            bool stbConv = Convert.ToBoolean(name);

            //2.3 STRING to DECIMAL
            decimal stdecIm = name;
            decimal stdecEx = (decimal)name;
            decimal stdecConv = Convert.ToDecimal(name);

            //2.4 STRING to INT
            int stintIm = name;
            int stintEx = (int)name;
            int stintConv = Convert.ToInt16(name);

            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR
            char btcIm = hasFree2Pages;
            char btcEx = char(hasFree2Pages);
            char btcConv = Convert.ToChar(hasFree2Pages);

            //3.2 BOOL to STRING
            string btsIm = hasFree2Pages;
            string btsEx = bool(hasFree2Pages);
            string btsConv = Convert.ToString(hasFree2Pages);

            //3.3 BOOL to DECIMAL
            decimal btdecIm = hasFree2Pages;
            decimal btdecEx = decimal(hasFree2Pages);
            decimal btdecConv = Convert.ToString(hasFree2Pages);
            //3.4 BOOL to INT
            int btintIm = hasFree2Pages;
            int btintEx = (int)hasFree2Pages;
            int btintConv = Convert.ToInt16(hasFree2Pages);
            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR
            char dectcIm = course;
            char dectcEx = char(course);
            char dectcConv = Convert.ToChar(course);

            //4.2 DECIMAL to BOOL
            bool dectbIm = course;
            bool dectbEx = (decimal)course;
            bool dectbConv = Convert.ToBoolean(course);

            //4.3 DECIMAL to STRING
            string dtsIm = course;
            string dtsEx = string(course);
            string dtsConv = Convert.ToString(course);

            //4.4 DECIMAL to INT
            int dectintIm = course;
            int dectintEx = (int)course;
            int dectintConv = Convert.ToInt16(course);

            //5. INT CONVERSION         

            //5.1 INT to CHAR
            char inttcIm = birthYear;
            char inttcEx = char(birthYear);
            char inttcConv = Convert.ToChar(birthYear);

            //5.2 INT to BOOL
            bool inttbIm = birthYear;
            bool inttbEx = (decimal)birthYear;
            bool inttbConv = Convert.ToBoolean(birthYear);

            //5.3 INT to DECIMAL

            decimal itdIm = birthYear;
            decimal itdEx = birthYear;
            decimal itdConv = Convert.ToDecimal(birthYear);

            //5.4 INT to STRING
            string inttsIm = birthYear;
            string inttsEx = string(birthYear);
            string inttsConv = Convert.ToString(birthYear);
        }
    }
}
