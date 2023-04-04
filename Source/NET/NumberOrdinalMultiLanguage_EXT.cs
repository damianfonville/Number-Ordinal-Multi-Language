using System;
using System.Collections;
using System.Data;
using System.Text;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimeCommon;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssNumberOrdinalMultiLanguage_EXT
{

    public class CssNumberOrdinalMultiLanguage_EXT : IssNumberOrdinalMultiLanguage_EXT
    {

        private const string MALE = "MALE";
        private const string FEMALE = "FEMALE";
        private const string DEFAULT_INDICATOR = ".";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssNumber">Number ot format</param>
        /// <param name="ssLanguage">2 letter language ISO</param>
        /// <param name="ssGender"></param>
        /// <param name="ssOrdinalNumber"></param>
        public void MssToOrdinalNumber(int ssNumber, string ssLanguage, string ssGender, out string ssOrdinalNumber)
        {
            ssOrdinalNumber = ssLanguage switch
            {
                "EN" => Formatter_en(ssNumber),
                "ES" => Formatter_es(ssNumber, ssGender),
                "FR" => Formatter_fr(ssNumber, ssGender),
                "NL" => Formatter_nl(ssNumber),
                "IT" => Formatter_it(ssNumber, ssGender),
                "PT" => Formatter_pt(ssNumber, ssGender),
                _ => $"{ssNumber}{DEFAULT_INDICATOR}",
            };
        } // MssToOrdinalNumber


        private string Formatter_en(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            int hundredModule = number % 100;
            int decimalModule = number % 10;

            if (11 <= hundredModule && hundredModule <= 13)
            {
                stringBuilder.Append("th");
            }
            else
            {
                switch (decimalModule)
                {
                    case 1:
                        stringBuilder.Append("st");
                        break;
                    case 2:
                        stringBuilder.Append("nd");
                        break;
                    case 3:
                        stringBuilder.Append("rd");
                        break;
                    default:
                        stringBuilder.Append("th");
                        break;
                }
            }

            return stringBuilder.ToString();
        }

        private string Formatter_es(int number, string gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (gender == MALE)
            {
                stringBuilder.Append("\u00BA");
            }
            else if (gender == FEMALE)
            {
                stringBuilder.Append("\u00AA");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_fr(int number, string gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (number == 1)
            {
                if (gender == MALE)
                {
                    stringBuilder.Append("er");
                }
                else if (gender == FEMALE)
                {
                    stringBuilder.Append("re");
                }
            }
            else
            {
                stringBuilder.Append("e");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_nl(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("e");

            return stringBuilder.ToString();
        }

        private string Formatter_it(int number, string gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (gender == MALE)
            {
                stringBuilder.Append("\u00BA");
            }
            else if (gender == FEMALE)
            {
                stringBuilder.Append("\u00AA");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_pt(int number, string gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (gender == MALE)
            {
                stringBuilder.Append("\u00BA");
            }
            else if (gender == FEMALE)
            {
                stringBuilder.Append("\u00AA");
            }

            return stringBuilder.ToString();
        }

        private string Formatter_ga(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("\u00FA");

            return stringBuilder.ToString();
        }

        private string Formatter_ja(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("\u756A");

            return stringBuilder.ToString();
        }

        private string Formatter_zh(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);
            stringBuilder.Append("\u7B2C");

            return stringBuilder.ToString();
        }

        private string Formatter_ca(int number, string gender)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(number);

            if (gender == MALE)
            {
                switch (number)
                {
                    case 1:
                        stringBuilder.Append("r");
                        break;
                    case 2:
                        stringBuilder.Append("n");
                        break;
                    case 3:
                        stringBuilder.Append("r");
                        break;
                    case 4:
                        stringBuilder.Append("t");
                        break;
                    default:
                        stringBuilder.Append("�");
                        break;
                }
            }
            else if (gender == FEMALE)
            {
                stringBuilder.Append("a");
            }

            return stringBuilder.ToString();
        }


    } // CssNumberOrdinalMultiLanguage_EXT

} // OutSystems.NssNumberOrdinalMultiLanguage_EXT

