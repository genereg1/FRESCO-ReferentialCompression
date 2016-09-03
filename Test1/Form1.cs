using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test1
{
    public partial class Form1 : Form
    {
        Class1 Cmps = new Class1();
        //FileStream file1 = new FileStream("E:\\Windows/Test1/list.txt", FileMode.Open);
      //  public string SplitArrayEnded;

        public string newString;


        public string text;









        public Form1()
        {
            InitializeComponent();


        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* 
             if (Char.IsDigit(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)))
                 e.Handled = true;
             else
                
                 return;
             */
            // Обработка дл ввода только заглавных букв
            e.KeyChar = Char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar("A") | (e.KeyChar == Convert.ToChar("G") | (e.KeyChar == Convert.ToChar("C") |
                e.KeyChar == Convert.ToChar("T"))) | (e.KeyChar == '\b')) return;

            else
                e.Handled = true;


            //if (Char(e.KeyChar) == (Char)Key.Back) 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Фильтрация только текстовых файлов 
            openFileDialog1.Filter = "Text Files|*.txt";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

                openFileDialog1.InitialDirectory = Cmps.path1;
                Cmps.path1 = openFileDialog1.FileName; // передает в поток путь файла

                textBox1.Text = reader.ReadToEnd();
                //Close the reader and the stream
                reader.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar("A") | (e.KeyChar == Convert.ToChar("G") | (e.KeyChar == Convert.ToChar("C") |
                e.KeyChar == Convert.ToChar("T"))) | (e.KeyChar == '\b')) return;

            else
                e.Handled = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            

            Cmps.Ref = textBox1.Text.ToString();
            //Cmps.S = File.ReadAllLines(textBox2.Text);

            Cmps.S = textBox2.Lines.ToString();                     

             
          
            // label6.Text = Cmps.GreddyAlg(); // вызов метода 1-го алгоритма
             string newString3 = string.Join("", Cmps.GreddyAlg()); // заменил* 
             label6.Text = newString3;
            

        } // обработчик 



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Фильтрация только текстовых файлов 
            openFileDialog1.Filter = "Text Files|*.txt";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

                openFileDialog1.InitialDirectory = Cmps.path1;
                Cmps.path1 = openFileDialog1.FileName; // передает в поток путь файла

                textBox2.Text = reader.ReadToEnd();
                //Close the reader and the stream
                reader.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox2.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   Cmps.SaveData(); 
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.FileName = String.Empty;
            
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

              /*  openFileDialog1.InitialDirectory = Cmps.path1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   Cmps.path1 = openFileDialog1.FileName;
                } */

                openFileDialog1.InitialDirectory = Cmps.path1;
                Cmps.path1 = openFileDialog1.FileName; // передает в поток путь файла


                    //Read Contents
            //    textBox4.Text = reader.ReadToEnd();
                textBox4.Text = reader.ReadToEnd();
                
                

                
                reader.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Фильтрация только текстовых файлов 
            openFileDialog1.Filter = "Text Files|*.txt";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

                openFileDialog1.InitialDirectory = Cmps.path1;
                Cmps.path1 = openFileDialog1.FileName; // передает в поток путь файла

                textBox5.Text = reader.ReadToEnd();
                //Close the reader and the stream
                
                reader.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBoxSpeedUpValueX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        } // ввод только цифр X

        private void button7_Click(object sender, EventArgs e)
        {
           // Cmps.S = textBox4.Text.ToString(); // 
            //Cmps._sAlg2 = Cmps.S.ToCharArray();
            
            Cmps.Ref = textBox5.Text.ToString(); //
            Cmps._refAlg2 = Cmps.Ref.ToCharArray();

            int nX = Int32.Parse(textBox3Split.Text); // Ввод числа расщеплений 
            //int spdUpX = Int32.Parse(textBoxSpeedUpValueX.Text); // Ввод числа..

            string combindedString = string.Join(" ", Cmps.Divider(nX)); // Вызов медота расщепления строки.
            

            label8.Text = combindedString;
           
            label10.Text = Cmps.ConctStr(nX);

            using (FileStream fstream = new FileStream(@"E:\Windows\Учеба 4.2\Диплом\FRESCO-master\data\ToyFRESCO\2\Result2.txt", FileMode.OpenOrCreate))
            {
                string svDt2 = Cmps.ConctStr(nX);
               // List<string> = GreddyAlg();
                byte[] checkArr = System.Text.Encoding.Default.GetBytes(Cmps.ConctStr(nX));
                fstream.Write(checkArr, 0, checkArr.Length);
                

            } // метод сохранения данных в файл 

         
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {


            Cmps.Ref = textBox3.Text.ToString(); // ref base textBox
           // Cmps.S = Cmps.thatNewString.ToString();
            Cmps.S = textBox6.Lines.ToString();


            // Запись данных в массив 


            

            // Счетчик массива 

            

            // label6.Text = Cmps.GreddyAlg(); // вызов метода 1-го алгоритма

            //string newString4 = string.Join("", Cmps.GreddyAlg()); // заменил* 

            //label10.Text = newString4;

            Cmps.GreddyAlg();
            label10.Text = Cmps.ReturnGreddy();

            using (FileStream fstream = new FileStream(@"E:\Windows\Учеба 4.2\Диплом\FRESCO-master\data\ToyFRESCO\2\compSxJ.txt", FileMode.OpenOrCreate))
            {
                string svDt2 = Cmps.ReturnGreddy();
                // List<string> = GreddyAlg();
                byte[] checkArr = System.Text.Encoding.Default.GetBytes(Cmps.ReturnGreddy());
                fstream.Write(checkArr, 0, checkArr.Length);


            } // метод сохранения данных в файл 

            
            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.FileName = String.Empty;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Stream fs = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(fs);

                textBox3.Text = reader.ReadToEnd();


                reader.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            

            Cmps.Ref = textBox3.Text.ToString(); // ref base textBox
          //  Cmps.S = File.ReadAllLines(@"E:\Windows\Учеба 4.2\Диплом\FRESCO-master\data\ToyFRESCO\2\ArrTest.txt");
            
            Cmps.S = textBox4.Lines.ToString();
            
            //  Cmps.S = textBox4.Text.Split(new String[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);
           

            // Запись данных в массив 


            //   char[] array1 = Cmps.Ref.ToCharArray();

           // Cmps.array1 = Cmps.Ref.ToCharArray();

            //   char[] array2 = Cmps.S.ToCharArray();
            //Cmps.array2 = Cmps.S.ToCharArray();


            // Счетчик массива 

           

            //label6.Text = Cmps.GreddyAlg(); // вызов метода 1-го алгоритма
            //string newString3 = string.Join("", Cmps.GreddyAlg()); // заменил* 
            Cmps.GreddyAlg();
          //  label10.Text = Cmps.ReturnGreddy();
            string newString3 = string.Join("", Cmps.GreddyAlg()); // заменил* 
            label10.Text = newString3;

            using (FileStream fstream = new FileStream(@"E:\Windows\Учеба 4.2\Диплом\FRESCO-master\data\ToyFRESCO\2\compRefi.txt", FileMode.OpenOrCreate))
            {
                string svDt2 = Cmps.ReturnGreddy();
                //List<string> = GreddyAlg();
                byte[] checkArr = System.Text.Encoding.Default.GetBytes(Cmps.ReturnGreddy());
                fstream.Write(checkArr, 0, checkArr.Length);


            } // метод сохранения данных в файл 
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Фильтрация только текстовых файлов 
            openFileDialog1.Filter = "Text Files|*.txt";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

                openFileDialog1.InitialDirectory = Cmps.path1;
                Cmps.path1 = openFileDialog1.FileName; // передает в поток путь файла

                textBox6.Text = reader.ReadToEnd();
                //Close the reader and the stream

                reader.Close();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Фильтрация только текстовых файлов 
            openFileDialog1.Filter = "Text Files|*.txt";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

                openFileDialog1.InitialDirectory = Cmps.path1;
                Cmps.path1 = openFileDialog1.FileName; // передает в поток путь файла

                textBox7.Text = reader.ReadToEnd();
                //Close the reader and the stream

                reader.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Фильтрация только текстовых файлов 
            openFileDialog1.Filter = "Text Files|*.txt";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {
                //Create a stream which points to the file
                Stream fs = openFileDialog1.OpenFile();
                //Create a reader using the stream
                StreamReader reader = new StreamReader(fs);
                //Read Contents

                openFileDialog1.InitialDirectory = Cmps.path2;
                Cmps.path2 = openFileDialog1.FileName; // передает в поток путь файла

                textBox8.Text = reader.ReadToEnd();
                //Close the reader and the stream

                reader.Close();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cmps.refVal = textBox7.Text.ToString();
            Cmps.sVal = textBox8.Text.ToString();

          //  Cmps.GetVal();
          //  Cmps.MinVal();

          
            string ResultStringVal = string.Join("\r\n", Cmps.GetVal());
            textBox9.Text = ResultStringVal;

            string ResultMinVal = string.Join("", Cmps.MinVal());
            label17.Text = ResultMinVal;

            

           // Cmps.GetVal();
            

         


        } 

        

        

        



    }
}

