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
            sr = new StreamReader("./Model/code.txt");
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

                   string a= workingLine(line);
                    Console.WriteLine(a);
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
            ArrayList ArrayLetter = new ArrayList();
            String Letter="";
            String number="";
            char let=' ';
            int numAct=0,numSg=0;

            foreach (char letter in word)
            {//Guardo letra por letra para trabajarlo mejor
                ArrayLetter.Add(letter);
            }
            
            for (int i = 0; i < word.Length; i++) {
               
              if(IsNumeric(ArrayLetter[i])){//validar si es numero
               
                  numAct = int.Parse(ArrayLetter[i].ToString());//el numero actual
                 
                  if(i+1 != word.Length  && IsNumeric(ArrayLetter[i+1].ToString()) ){
                      
                      numSg = int.Parse(ArrayLetter[i+1].ToString());

                  }else if(i+1 == word.Length){//si esta al final

                    number = number + numAct.ToString();
                    let = convert(number);
                    return Letter + let;

                  }  
                  
                if(ArrayLetter[i].ToString().Equals("0")){
                
                if(!IsNumeric(ArrayLetter[i+1])){//si sigue una letra agrego el espacio
                    Letter = Letter + " ";
                    
                }else{ //de lo contrario si no una letra evaluamos
                    
                    if(ArrayLetter[i+1].ToString().Equals("9") || ArrayLetter[i+1].ToString().Equals("1")){
                         number = number + ArrayLetter[i].ToString();
                    }else{
                        Letter = Letter + " ";
                    }
                    
                }
                
                }else if(!IsNumeric(ArrayLetter[i+1])){//si el numero que sigue es una letra

                    number = number + numAct.ToString();
                    let = convert(number);
                    Letter = Letter + let;
                    number="";

                }else if(numAct<numSg){//si hay un numero mayor concatenar a numero
                   
                    number = number + ArrayLetter[i].ToString();
                    
                }else if(numAct>numSg){// si hay un numero menor convertir                   
                    
                    number = number + numAct.ToString();
                    let = convert(number);
                    number="";
                    Letter = Letter + let;
                     
                }
                
              }else{
                 
                  Letter = Letter + ArrayLetter[i].ToString();
                  
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
                case "0158": return 'D';
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
                case "0135679": return 'W';
                case "09": return 'X';
                case "1347": return 'Y';
                case "23456": return 'Z';

            }
            return '0';
        }
    }
}