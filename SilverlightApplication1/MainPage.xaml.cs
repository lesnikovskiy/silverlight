using System;
using System.Windows.Controls;

namespace SilverlightBanking
{
    public partial class MainPage : UserControl
    {
        private Owner _owner;

        public MainPage()
        {
            InitializeComponent();

            InitializeOwner();
            OwnerDetailsGrid.DataContext = _owner;
        }

        private void InitializeOwner()
        {
            _owner = new Owner
                {
                    OwnerId = 1234567,
                    FirstName = "John",
                    LastName = "Smith",
                    Address = "Oxford Street 24",
                    ZipCode = "W1A",
                    Country = "United Kingdom",
                    State = "NA",
                    ImageName = new Uri("/CustomerImages/man.jpg", UriKind.Relative),
                    LastActivityDate = DateTime.Today,
                    CurrentBalance = 1234.56,
                    BirthDate = new DateTime(1953, 6, 9),
                    CustomerSince = new DateTime(1999, 12, 20),
                    LastActivityAmount = 100
                };
        }
    }
}
