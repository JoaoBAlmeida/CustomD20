using CustomD20.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomD20.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Results : ContentPage
    {
        private readonly Random rand = new Random();
        public Results(int Pont)
        {
            InitializeComponent();
            LblPont.Text = Pont.ToString();
            Title = GetTitle(Pont, SetLabel());
        }
        private int SetLabel()
        {
            int num = rand.Next(1, 21);
            LblDice.Text = num.ToString();
            return num;
        }

        private String GetTitle(int Pont, int Dice)
        {
            Rubric rubric = new Rubric();
            Dictionary<int, string> table = rubric.GetRubric(Pont);
            return rubric.GetEvaluation(table[Dice]);
        }

        private void BtnRollAgain(object sender, EventArgs e)
        {
            Title = GetTitle(int.Parse(LblPont.Text), SetLabel());
        }
    }
}