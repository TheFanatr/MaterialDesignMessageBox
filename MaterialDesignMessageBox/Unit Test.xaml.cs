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
using System.Windows.Shapes;

namespace MaterialDesignMessageBox
{
    /// <summary>
    /// Interaction logic for Unit_Test.xaml
    /// </summary>
    public partial class Unit_Test : Window
    {
        public Unit_Test()
        {
            InitializeComponent();
            Button testButton = new Button { Content = "Test MDMessageBox" };
            // TODO: Check that the variables in MDMessageBox can be set through initializing the MDMessageBox with the "curly brackets method".
            new MDMessageBox()
            {
                Message = "happy",
                message
            };

            testButton.Click += (s, e) => { };
            grid.Children.Add(testButton);
        }
    }
}
