using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpiralSecGUI
{//Namespace start
   
    public partial class MainWindow : Window
    {//Class start

        public MainWindow()
        {//Main start
            InitializeComponent();

            //Create instances of the AIbot  User classes
            new AIbot();
            new User();

        private void EnterApp_Click(object sender, RoutedEventArgs e)
        {
            //Hide the logo grid and show the username grid
            Logo_grid.Visibility = Visibility.Hidden;
            Username_grid.Visibility = Visibility.Visible;
        }

        private void SubmitName(object sender, RoutedEventArgs e);

        string enteredName = Username.Text;
        UsernameValidator validator = new UsernameValidator(); 
        
        if(!validator.IsValid(enteredName, out string errorMessage ))
        {
         MessageBox.Show(errorMessage);
        return;
        }

     //If valid, store in User class
     User user = new User();
        User.SetUsername(enteredName);

        MessageBox.Show($"Welcome, {enteredName}! You can now enter the application.");

        //Switch grid
        Username_grid.Visibility = Visibility.Hidden;

        //Chatbot_grid.Visibility = Visibility.Visible;
    



}//Main end
}//Class end 
}//Namespace end
    