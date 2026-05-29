using SpiralSecGUI.SpiralSecGUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpiralSecGUI
{
    public partial class MainWindow : Window
    {//Start of class

        // Field to store username
        private string enteredName;

        //Creating an instance for the class array.
        ArrayList reply = new ArrayList();
        ArrayList ignore = new ArrayList();



        public MainWindow()
        {//Start of constructor
            InitializeComponent();
        }//End of constructor 

        AudioPlayer player = new AudioPlayer();

        private void EnterApp_Click(object sender, RoutedEventArgs e)
        {

            // Hide the logo grid and show the username grid
            LogoGrid.Visibility = Visibility.Visible;
            UsernameGrid.Visibility = Visibility.Visible;
            ChatGrid.Visibility = Visibility.Hidden;

            //Slide animation for the logo grid
            Storyboard sbOut = (Storyboard)FindResource("SlideOutLogo");
            Storyboard sbIn = (Storyboard)FindResource("SlideInUsername");

            sbOut.Begin();
            sbIn.Begin();

            //When logo finishes sliding out, hide it
            sbOut.Completed += (s, ev) =>
            {
                LogoGrid.Visibility = Visibility.Hidden;
            };


        }

        // Validate username and proceed
        private void SubmitUsername(object sender, RoutedEventArgs e)
        {
            enteredName = UsernameBox.Text;
            User validator = new User();

            if (!validator.IsValid(enteredName, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            // If valid, store in User class
            User user = new User();
            //Added Equals to say is the user's username is valid they may enter the application, if not they will be prompted with an error message.
            user.Equals(enteredName);

            MessageBox.Show($"Welcome, {enteredName}! You can now enter the application.");

            // Switch grid
            UsernameGrid.Visibility = Visibility.Visible;

            ChatGrid.Visibility = Visibility.Visible;

            //Slide animation for the chat grid 
            Storyboard sbOut = (Storyboard)FindResource("SlideOutUsername");
            Storyboard sbIn = (Storyboard)FindResource("ChatIn");

            sbOut.Begin();
            sbIn.Begin();

            //When username finishes sliding out, hide it
            sbOut.Completed += (s, ev) =>
            {
                UsernameGrid.Visibility = Visibility.Hidden;
            };



            //Dynamic username display in the chat area
            WelcomeLabel.Content = $"Welcome to SpiralSec, {enteredName}! Ask me anything.";
        }


        //Use the send button to send the message to the AI bot and get a response.
        private void SendQuestion(object sender, RoutedEventArgs e)
        {
            string userMessage = QuestionBox.Text;
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show($"Please enter a message before clicking Send , {enteredName}.");
                return;
            }
            // Get AI response
            string aiResponse = AIbots.GetResponse(userMessage);
            // Display the response in the chat area
            ChatList.Items.Add($"{enteredName}: {userMessage}");
            ChatList.Items.Add($"SpiBot: {aiResponse}");
            QuestionBox.Clear();
        }
    }
}

