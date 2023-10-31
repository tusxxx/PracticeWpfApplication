using System;
using PracticeWpfApplication.Database;

namespace PracticeWpfApplication
{
    public partial class MainWindow
    {
        private readonly DatabaseDao _database = new DatabaseDao("mongodb://localhost:27017", "PracticeWpfApplication");
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            var buyers = _database.GetAllBuyers();
            Customers.ItemsSource = buyers;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}