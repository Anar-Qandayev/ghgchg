using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Student : Person
    {
        public int IQRank { get; set; } /*IQ imtahanının nəticəsi 100 bal üzərindən*/
        public int LanguageRank { get; set; } /*Dil imtahanının nəticəsi (100 bal üzərindən)*/
        public Person person { get; set; }

        public Student(int IQRank , int LanguageRank):base()
        {
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;
        }

        public Student(): base()
        {
        }

        

        //Şagirdin iki imtahanının nəticəsi 120dən azdırsa, o zaman sinifdə qaldığı mənasını bildirən methoddur.
        public string ExamResult(int IQRank, int LanguageRank , int age)
        {
            if (age < 6 || age > 20) return "Siz shagird deyilsigiz.";
           
            int Great = IQRank + LanguageRank;
           string text =  $"Siz imtahandan {Great} bal toplamisiz.";

            if (Great >= 120)
                text += "\nTEBRIKLER! SIZ IMTAHANDAN UGURLA KECDINIZ.";
            else
                 text += "\nSiz kechid bali toplaya bilmesiz. Teesufki sinifde qaldiniz. ";

            return text;
        }
    }
}
