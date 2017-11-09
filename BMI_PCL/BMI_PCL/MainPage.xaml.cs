using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_PCL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double hcm = double.Parse(this.height.Text);    //身長(cm or m)
            double w = double.Parse(this.weight.Text);      //体重(kg)
            double hm = hcm;
            if (hcm > 5) //cm単位で入力された場合
            {
                hm = hcm / 100;
            }
            else        //m単位で入力された場合
            {
                hcm = hm * 100;
            }

            double bmi = w / (hm * hm);

            string ans = "";
            if (bmi < 16)
            {
                ans = "瘦せすぎ";
            }
            else if (bmi < 17)
            {
                ans = "瘦せ";
            }
            else if (bmi < 18.5)
            {
                ans = "瘦せぎみ";
            }
            else if (bmi < 25)
            {
                ans = "普通";
            }
            else if (bmi < 30)
            {
                ans = "肥満ぎみ";
            }
            else if (bmi < 35)
            {
                ans = "肥満";
            }
            else if (bmi >= 35)
            {
                ans = "過剰肥満";
            }
            else
            {
                ans = "異常";
            }

            DisplayAlert("BMI計算", "高さ=" + hcm.ToString() + "cm 重さ=" + w.ToString() + "kg 結果:" + ans, "OK");

        }
    }
}