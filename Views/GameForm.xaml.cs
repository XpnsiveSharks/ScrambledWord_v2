﻿using ScrambledWord_v2.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScrambledWord_v2.Views
{
    /// <summary>
    /// Interaction logic for GameForm.xaml
    /// </summary>
    public partial class GameForm : Window
    {
        public GameForm()
        {
            InitializeComponent();
            TxtBlkDisplayWords.Text = Functionalities.printWord();
            TxtBlkScore.Text = Functionalities.Scoring();
            TxtBlkCorrectGuess.Text = Functionalities.TrackLevel();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtBlkDisplayWords.Text = Functionalities.VerifyAnswer(TxtAnswer.Text);
                TxtBlkCorrectGuess.Text = Functionalities.TrackLevel();
                TxtBlkWrongGuessNotif.Text = Functionalities.WrongGuessMessage();
                TxtBlkDisplayHints.Text = "";
                TxtAnswer.Text = "";
                TxtBlkScore.Text = Functionalities.Scoring();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHint_Click(object sender, RoutedEventArgs e)
        {
            TxtBlkDisplayHints.Text = Functionalities.printHint();
            TxtBlkScore.Text = Functionalities.Scoring();
        }

        private void BtnReShuffle_Click(object sender, RoutedEventArgs e)
        {

            TxtBlkDisplayWords.Text = Functionalities.ReShuffle();
        }
    }
}
