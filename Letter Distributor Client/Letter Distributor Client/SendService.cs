using System;
using System.Windows;

namespace Letter_Distributor_Client
{
    internal class SendService
    {
        internal static void SendLetter(Letter letter)
        {
            //TODO: We do not have an integration agreement yet, so for now we are saving to a local file for testing
            MessageBox.Show("Mock - The letter has been sent");
            throw new NotImplementedException();
        }
    }
}