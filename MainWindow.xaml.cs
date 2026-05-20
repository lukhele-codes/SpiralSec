using System;
using System.Collections;
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
{
    public partial class MainWindow : Window
    {//Start of class


        //Creating an instance for the class array.
        ArrayList reply = new ArrayList();
        ArrayList ignore = new ArrayList();
    
        public MainWindow()
        {//Start of constructor
          InitializeComponent();
          //Creating an instance of the AIbot class to respond without an object name.
          new AIbots(reply, ignore);
        }//End of constructor 

        private void EnterApp_Click(object sender, RoutedEventArgs e)
        {
            // Hide the logo grid and show the username grid
            Logo_grid.Visibility = Visibility.Hidden;
            Username_grid.Visibility = Visibility.Visible;
        }

        // Validate username and proceed
        private void SubmitName(object sender, RoutedEventArgs e)
        {
            string enteredName = Username.Text;
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
            Username_grid.Visibility = Visibility.Hidden;
        }

        //Use the send button to send the message to the AI bot and get a response.
        private void SendQuestion(object sender, RoutedEventArgs e)
        {
            string userMessage = Question.Text;
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }
            // Get AI response
            string aiResponse = AIbots.GetResponse(userMessage);
            // Display the response in the chat area
            ChatListView.Items.Add($"You: {userMessage}");
            ChatListView.Items.Add($"AI: {aiResponse}");
            Question.Clear();
        }
    }
}

