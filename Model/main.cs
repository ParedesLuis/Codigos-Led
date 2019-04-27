using System;
using System.IO;
using System.Collections;

namespace Practica1.Model
{
    public class main
    {
        StreamReader sr;
        string lineCode;

        public main()
        {
            sr = new StreamReader("./Model/code.in");
        }

        public void Read()
        {
            String line;
            try
            {
                //String word;
                line = sr.ReadLine();


                while (line != null)
                {
                    Console.WriteLine(workingLine(line));
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceptionn: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private string workingLine(string word)
        {
            String Letter="";
            String number="";
            
            for (int i = 0; i < word.Length; i++) {
               
              if(IsNumeric(word[i])){//validar si es numero
               
               number += word[i];

               if(convert(number)!='0'){

                Letter += convert(number);
                number="";

               }else if(number.Equals("0")){
                   Letter += " ";
                    number="";
               }
                
              }else{
                  Letter += word[i];
              }   
                
            }
        
            return Letter;
        }

        private bool IsNumeric(object Expression){

            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;

        }
        private char convert(string Word)
        {

            switch (Word)
            {
                case "123457": return 'A';
                case "1234567": return 'B';
                case "456": return 'C';
                case "1580": return 'D';
                case "12456": return 'E';
                case "1249": return 'F';
                case "12569": return 'G';
                case "13457": return 'H';
                case "37": return 'I';
                case "3567": return 'J';
                case "13459": return 'K';
                case "156": return 'L';
                case "12357": return 'M';
                case "3579": return 'N';
                case "123567": return 'O';
                case "1458": return 'P';
                case "12347": return 'Q';
                case "123459": return 'R';
                case "12467": return 'S';
                case "278": return 'T';
                case "13567": return 'U';
                case "1379": return 'V';
                case "1356790": return 'W';
                case "90": return 'X';
                case "1347": return 'Y';
                case "23456": return 'Z';

            }
            return '0';
        }
    }
}