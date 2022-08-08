﻿using System;
using Xamarin.Forms;

namespace GlucoMan.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblAppName.Text += " " + Common.Version;
        }
        private async void btnGlucoseMeasurement_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlucoseMeasurementsPage(null));
        }
        private async void btnMeals_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MealsPage());
        }
        private async void btnNewMeal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MealPage(null));
        }
        private async void btnWeighFood_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeighFoodPage());
        }
        private async void btnInsulinCalc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsulinCalcPage());
        }
        private async void btnFoodToHitTargetCarbs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodToHitTargetCarbsPage());
        }
        private async void btnHypoPrediction_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HypoPredictionPage());
        }
        private async void btnAlarms_Clicked(object sender, EventArgs e)
        {
            // !!!! TODO 
        }
        private async void btnMiscellaneousFunctions_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MiscellaneousFunctionsPage());
        }
        private async void btnAbout_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void btnInjections_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InjectionsPage(null));
        }
        private async void btnFoods_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodsPage(new Food()));
        }
    }
}
