using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WPFCalc.Controls
{

    public class CalcControl
    {
        public BindingList<string> TableList = new BindingList<string>();
        public BindingList<string> CalcList = new BindingList<string>();

        public string ShowList()
        {
            string Numbers = default;
            foreach (string item in TableList)
            {
                Numbers = Numbers + item;
            }

            return Numbers;
        }


        public void AddToList(string value)
        {
            TableList.Add(value);
        }


        public void CalcAction(string value)
        {
            string action = value;
            string numb = ShowList();
            CalcList.Add(numb);
            CalcList.Add(action);
            TableList.Clear();
        }

        public void GetRadical()
        {
            if (TableList.Count > 0)
            {
                double value = Convert.ToDouble(ShowList());
                string number = Math.Sqrt(value).ToString();
                TableList.Clear();
                TableList.Add(number);
            }
        }

        public string OneDivideByX()
        {
            if (TableList.Count > 0)
            {
                double value = Convert.ToDouble(ShowList());
                if (value != 0)
                {
                    string number = (1 / value).ToString();
                    TableList.Clear();
                    TableList.Add(number);
                    return number;
                }
                else
                {
                    TableList.Clear();
                    return "Деление на 0";
                }
            }
            else { return "Невозможная операция"; }
        }


        public string ChangeSign()
        {
            double value = Convert.ToDouble(ShowList());
            string number = Convert.ToString(value + (value * -2));
            TableList.Clear();
            TableList.Add(number);
            return Convert.ToString(value + (value * -2));
        }

        public void DelChar()
        {
            TableList.Remove(TableList.LastOrDefault());
        }

        public string Calculate()
        {
            string numb = ShowList();
            CalcList.Add(numb);
            TableList.Clear();
            double result = default;
            while (CalcList.Count > 0)
            {
                if (CalcList[1] == "+")
                {
                    result = Convert.ToDouble(CalcList[0]) + Convert.ToDouble(CalcList[2]);
                    CalcList.RemoveAt(2);
                    CalcList.RemoveAt(1);
                    CalcList.RemoveAt(0);
                    if (CalcList.Count > 1)
                    { CalcList.Insert(0, Convert.ToString(result)); }
                }
                else if (CalcList[1] == "-")
                {
                    result = Convert.ToDouble(CalcList[0]) - Convert.ToDouble(CalcList[2]);
                    CalcList.RemoveAt(2);
                    CalcList.RemoveAt(1);
                    CalcList.RemoveAt(0);
                    if (CalcList.Count > 1)
                    { CalcList.Insert(0, Convert.ToString(result)); }
                }

                else if (CalcList[1] == "*")
                {
                    result = Convert.ToDouble(CalcList[0]) * Convert.ToDouble(CalcList[2]);
                    CalcList.RemoveAt(2);
                    CalcList.RemoveAt(1);
                    CalcList.RemoveAt(0);
                    if (CalcList.Count > 1)
                    { CalcList.Insert(0, Convert.ToString(result)); }
                }
                else if (CalcList[1] == "/")
                {
                    if (Convert.ToDouble(CalcList[2]) != 0)
                    {
                        result = Convert.ToDouble(CalcList[0]) / Convert.ToDouble(CalcList[2]);
                        CalcList.RemoveAt(2);
                        CalcList.RemoveAt(1);
                        CalcList.RemoveAt(0);
                        if (CalcList.Count > 1)
                        { CalcList.Insert(0, Convert.ToString(result)); }
                    }
                    else
                    {
                        CalcList.Clear();
                        TableList.Clear();
                        return "Деление на 0";
                    }
                }
            }
            TableList.Add(Convert.ToString(result));

            return Convert.ToString(result);
        }



    }
}
