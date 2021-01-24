﻿using GlucoMan.BusinessLayer;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GlucoMan_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsulineCalc_Page : ContentPage
    {
        BolusCalculation bolus;
        public InsulineCalc_Page()
        {
            InitializeComponent();

            bolus = new BolusCalculation();
            bolus.RestoreData();
            FromClassToUi();
            txtGlucoseBeforeMeal.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            FromUiToClass();
            bolus.CalculateBolus();
            bolus.SaveData();
            FromClassToUi();
        }

        private void FromClassToUi()
        {
            txtChoToEat.Text = bolus.ChoToEat.Text;
            txtRatioEvening.Text = bolus.ChoInsulineRatioEvening.Text;
            txtRatioMidday.Text = bolus.ChoInsulineRatioMidday.Text;
            txtRatioMorning.Text = bolus.ChoInsulineRatioMorning.Text;
            txtSensitivity1800.Text = bolus.InsulineSensitivity1800.Text;
            txtSensitivity1500.Text = bolus.InsulineSensitivity1500.Text;
            txtTdd.Text = bolus.Tdd.Text;
            txtGlucoseBeforeMeal.Text = bolus.GlucoseBeforeMeal.Text;
            txtGlucoseToBeCorrected.Text = bolus.GlucoseToBeCorrected.Text;
            txtCorrectionInsuline.Text = bolus.CorrectionInsuline.Text;
  
            txtTotalChoDinner.Text = bolus.TotalChoDinner.Text;
            txtTotalChoLunch.Text = bolus.TotalChoLunch.Text;
            txtTotalChoBreakfast.Text = bolus.TotalChoBreakfast.Text;
            txtTypicalBolusMidday.Text = bolus.TypicalBolusMidday.Text;
            txtTypicalBolusMorning.Text = bolus.TypicalBolusMorning.Text;
            txtTypicalBolusEvening.Text = bolus.TypicalBolusEvening.Text;
            txtTypicalBolusNight.Text = bolus.TypicalBolusNight.Text;
            txtTargetGlucose.Text = bolus.TargetGlucose.Text;

            txtRatioEvening.Text = bolus.ChoInsulineRatioEvening.Text;
            txtRatioMidday.Text = bolus.ChoInsulineRatioMidday.Text;
            txtRatioMorning.Text = bolus.ChoInsulineRatioMorning.Text;
        }

        private void FromUiToClass()
        {
            // since it is easy to mistakenly insert blanks during editing, we tear blanks off 
            // from all the Entry controls that input a number 
            bolus.ChoToEat.Text = txtChoToEat.Text.Replace(" ", "");
            bolus.ChoInsulineRatioEvening.Text = txtRatioEvening.Text.Replace(" ", "");
            bolus.ChoInsulineRatioMidday.Text = txtRatioMidday.Text.Replace(" ", "");
            bolus.ChoInsulineRatioMorning.Text = txtRatioMorning.Text.Replace(" ", "");

            bolus.GlucoseBeforeMeal.Text = txtGlucoseBeforeMeal.Text.Replace(" ", "");

            bolus.TypicalBolusMidday.Text = txtTypicalBolusMidday.Text.Replace(" ", "");
            bolus.TypicalBolusMorning.Text = txtTypicalBolusMorning.Text.Replace(" ", "");
            bolus.TypicalBolusEvening.Text = txtTypicalBolusEvening.Text.Replace(" ", "");
            bolus.TypicalBolusNight.Text = txtTypicalBolusNight.Text.Replace(" ", "");
            bolus.TargetGlucose.Text = txtTargetGlucose.Text.Replace(" ", "");
        }
    }
}