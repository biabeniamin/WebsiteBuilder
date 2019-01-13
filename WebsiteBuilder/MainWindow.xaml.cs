using Generator;
using Generator.Enums;
using Generator.Models;
using Luis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebsiteBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Test();
        }

        private async void Test()
        {
            LuisApi luis = new LuisApi();
            Website website = new Website("TEst", new Background(Generator.Models.Color.Blue), WebsiteType.Business);
            Interpreter interpreter = new Interpreter(luis, website);


            interpreter.SendMessage("change background color to red");
        }
         
    }
}
