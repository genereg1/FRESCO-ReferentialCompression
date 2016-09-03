using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Test1
{


    public class Class1
    {
        public int count_R;
        public int count_S1;
        public string S;
      //  public List<char> S = new List<char>();
        public string Ref;

        public string[] _2S;
        public string[] _2ref;

        public char[] _sAlg2;
        public char[] _refAlg2;

       // public int nX = 0;
        public string test3;
        public string test4;

        public string[] Result; 

        public char[] buffer;
        public char[] buffer2;

        public char[] array1;

        //public char[] splitArray;
        public char[] concArray;

     //   public char[] array2;

        public string thatNewString;

        public string path1;
        public string path2;

        public string refVal;
        public string sVal;

        public int rsim = 0;
        public int set = 0;       // переменные множества
        public int check = 0;
        public int allLength = 0;
        
        

        

        /*FileStream file1 = new FileStream("E:\\Windows/Test1/list.txt", FileMode.Open);
          public List<string> Blocks = new List<string>();
        
          public List<string> Blocks2_X = new List<string>(); */

        private char[] StrToChr(string[] Sv2)
        {

            //merges the items in the Strings collection into one string

            string merged = "";

            foreach (string str in Sv2)
            {

                merged += str;

            }

            //returns a char array that represents the merged string

            return merged.ToCharArray();
        }



        public List<string> GreddyAlg()
        {

            var sb1 = new List<string>();



            StreamReader fs2 = new StreamReader(path1);

              string text = "";

              while (true)
              {
                  string temp = fs2.ReadLine();
                  
                  if (temp == null) break;

                  text = temp;

                 

                  int start = 0;
                  int current_start = 0;
                  int current_l = 0;
                  char current_char = new Char();
                  int next_l = 0;
                  int next_start = 0;
                  char next_char = new Char();
                                  

                  List<char> array1 = new List<char>();
                  List<char> array2 = new List<char>();


                  // int i = 0;
                  int j;
                  //int m = 0;
                  // int k = 0;

                  //              array1 = Ref.Replace("\r\n", "").ToCharArray();
                  // array2 = Ref.Replace("T\r\n", "").ToCharArray();


                  //  array1 = Ref.ToCharArray(); //array1 = ref
                  //  array2 = S.ToCharArray();

                  //              array2 = S.Replace("\r\n", "").ToCharArray();
                  //              array2 = S.Replace("T\r\n", "").ToCharArray();


                  array2 = Ref.ToList();

                  array1 = text.ToList();

                  count_S1 = array1.Count;

                  count_R = array2.Count;


                  while (start <= count_S1 - 1)
                  {

                      j = 0;
                      next_start = 0;
                      next_l = 0;
                      next_char = '0';

                      current_start = 0;
                      current_l = 0;
                      current_char = '0';
                      //current


                      while (j <= count_R - 1)
                      {
                          if (array1[start] == array2[j])
                          {
                              current_start = j;
                              current_l = 1;
                              int m = j;
                              m++;// Счетчик по R

                              //  start ++;


                              for (int k = start + 1; k < count_S1; k++)
                              {
                                  if (array1[k] == array2[m])
                                  {
                                      current_l++;
                                      m++;
                                  }

                                  else
                                  {
                                      current_char = array1[k]; // заменил
                                      break;
                                  }

                              }

                              if (next_l < current_l)
                              {
                                  next_l = current_l;
                                  next_start = current_start;
                                  next_char = current_char;

                              }


                              j = m;

                          } // условие 

                          else


                              j++;

                      }// while

                      // sb.Append("<").Append(next_start.ToString()).Append(", ").Append(next_l.ToString()).Append(", ");
                      //sb.Append(next_char.ToString()).Append(" > "); //stringbuilder

                      sb1.Add("<");
                      sb1.Add(next_start.ToString());
                      sb1.Add(", ");
                      sb1.Add(next_l.ToString());
                      sb1.Add(", ");
                      sb1.Add(next_char.ToString());
                      sb1.Add(" > ");
                     
                      start = next_l + start + 1;



                  } // цикл1
                  sb1.Add("\r\n");
              } // цикл счета строк
                     
              return sb1;
        }  // конец метода

        




        public int Test1(int a, int b)
        {
            return a + b;
        }

        

      /*  public void SaveData()
        {
            using (FileStream fstream = new FileStream(@"E:\Windows\Учеба 4.2\Диплом\FRESCO-master\data\Result\note.txt", FileMode.OpenOrCreate))
            {
                string svDt2 = ConctStr();
               // List<string> = GreddyAlg();
                byte[] checkArr = System.Text.Encoding.Default.GetBytes(ConctStr());
                fstream.Write(checkArr, 0, checkArr.Length);
                

            } // метод сохранения данных в файл 
         
        } */

        public void ArrTxtFile()
        {
            string[] NewFile = File.ReadAllLines("1.txt");
            foreach (string str in NewFile) ;
            
        } // чтение каждой строки файла

        public List<string>Divider(int sN)
        {

            
            char[] splitArray = Ref.ToArray();
            int test5 = Ref.Length / 2;
           // int test5 = S.Replace("\r\n", "").Length / 2;
            List<string> Blocks = new List<string>();//(S.Length / sN);// + 1);
           // ArrayList Blocks2_X = new ArrayList();
       //     StringBuilder sbBlockX = new StringBuilder();
            
                for (int i = 0; i < splitArray.Length; i+= sN )
                {
                    if (splitArray.Length - i > sN)
                        Blocks.Add(Ref.Substring(i, sN));                                              
                        
                    else
                        Blocks.Add(Ref.Substring(i, splitArray.Length - i) + new String('\0', sN - (splitArray.Length - i)));
                                                            
                   // Выборка и конкатенция строк
                        
                        
                    
             //       if (Blocks.Count == test5 / sN)
               //     sbBlockX.Append(Environment.NewLine);  // bydloKod
    
                   // Blocks.Add(S.Substring(i, sN));


                }
                          
                return Blocks;
                           
                        
        } // Split строк на заданное значение
        public string[] ReturnBlockX()
        {
            return Result;

        } // concatenation string -- возращение строки из  Divider()

        public string ConctStr(int _sN)
        {         
            var Blocks2_X = new List<string>(Divider(_sN));
            var Blocks2_X2 = new List<string>();
            var tempBlocksX3 = new List<string>();
          //  string[] SplitBlockX = Blocks.ToArray();
          //  Blocks2_X = Blocks;
            foreach(string c in Blocks2_X)
            {


                // if(Blocks2_X.Count % _sN == 0)
                tempBlocksX3.Add(c);
                tempBlocksX3.Remove("T\r\n");
                tempBlocksX3.Remove("\r\n");  // добавил
               
                
                
                    if (tempBlocksX3.Count % _sN == 0)
                        Blocks2_X2.Add(c);
                 
                
                

            }

               // string[] Result = (string[])Blocks2_X.ToArray(typeof(char));
               // foreach (string c in Result)
            thatNewString = string.Join("", Blocks2_X2);
            return thatNewString;
         
        }

        public string ReturnGreddy()
        {
            var retGdd = new List<string>(GreddyAlg());
            var retGdd2 = new List<string>();
            foreach(string gdd in retGdd)
            {
                retGdd2.Add(gdd);
            }

            string gddString = string.Join("", retGdd2);

            

            return gddString;


        }
        
        public List<int> GetVal()
        {
            var RetValList = new List<int>();                 
                                   
            string textRef = "";
            string textS = "";

            StreamReader fsRef = new StreamReader(path1);
            StreamReader fs_S = new StreamReader(path2);
            

            while (true)
            {
                rsim = 0;
                set = 0;
                string tempRef = fsRef.ReadLine();
                string tempS = fs_S.ReadLine();

                if (tempRef == null || tempS == null) break;

                textRef = tempRef;
                textS = tempS;

                var temp = new List<char>();
                var valList = new List<char>();
                valList = textRef.ToList();  // ref

                var temp2 = new List<char>();
                var val2list = new List<char>();
                val2list = textS.ToList();
                
                foreach (char num in valList)
                {
                    temp.Add(num);
                    // temp.Remove('<');
                    temp.Remove('>');                                  
                }

                foreach (char num2 in val2list)
                {
                    temp2.Add(num2);
                    temp2.Remove('>');
                }



                thatNewString = string.Join("", temp); // возможно следует заменить переменную
                string thatNewString2 = string.Join("", temp2);
                string[] wordsBlockRef = thatNewString.Split(new char[] { '<' }, StringSplitOptions.RemoveEmptyEntries); //разбть строку на 
                // на подстроки

                string[] wordsBlockS = thatNewString2.Split(new char[] { '<' }, StringSplitOptions.RemoveEmptyEntries);



                foreach (string compare in wordsBlockRef)
                {
                    foreach (string compare2 in wordsBlockS)
                    {
                        if (compare == compare2)
                        {
                            set++;

                            allLength = wordsBlockRef.Count() + wordsBlockS.Count();
                            
                            rsim = allLength - set;
                                                                                  
                        }
                    }

                    
                }
                
                if (rsim == 0 || set == 0) //если нет совпадений
                {
                    RetValList.Add(allLength);
                                      
                }

                else
                    RetValList.Add(rsim);
                   
                  
            }


            return RetValList;
            

        }

        public int MinVal()
        {
            var minValList = new List<int>(GetVal());

            int min = minValList.Min();

            return min;
        }


        

        
        
        

        
    }
}
        
        


               

                

                

            
           

           
                
                
                        
                
             

            
                    
            
                
                    
                   
                
                   
            
            






       
    
        

