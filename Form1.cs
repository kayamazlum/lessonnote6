using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6nDers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Yönetim Bilişim Sistemleri";
            label1.Text = str.Length.ToString();

            String str2 = "Düzce Üniversitesi";

            String str3 = "\t \t \t Bu bir c# işlemidir";
            //label2.Text = str + str2;
            //label2.Text = string.Concat(str, str2); // stringleri birleştirir

            //label2.Text = str.Equals(str2).ToString(); //birbirlerine eşit mi ? true false döner

            //label2.Text = "i harfi ilk olarak : " + str2.IndexOf('i') + " sırada bulundu"; // index no verir
            //label2.Text = "iver harfleri ilk olarak : " + str2.IndexOf('iver') + " sırada bulundu";
            //label2.Text = "i harfi ilk olarak : " + str2.IndexOf('i', 5) + " sırada bulundu"; // 5.den sonraki

            //label2.Text = str2.ToLower(); // küçültür
            //label2.Text = str2.ToUpper(); // büyütür
            //label2.Text = str2.ToLower() + "\n"+ str2.ToUpper();

            //label2.Text = str2.Replace("Düzce", "Uludağ"); // kelimeleri değiştirir

            //label2.Text = str3 + "\n" + str3.Trim(); //boşlukları siler

            //label2.Text = str2.Substring(1); //1.den itibarenki değerleri getirir
            //label2.Text = str2.Substring(1, 4); // başlangıç indexi ve kaç karakter alınacağı

            //label2.Text = str2.Contains("Düzce").ToString(); // düzce kelimesi var mı true false

            label2.Text = str2.Remove(3, 4); //3ten itibaren 4 tane karakter siler

            
            
            
            
            // double s1 = "3.5";
            // double b = double.Parse(s1); // convert den farklı bi yöntem



        }
    }
}
