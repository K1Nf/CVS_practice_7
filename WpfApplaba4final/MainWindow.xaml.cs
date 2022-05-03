using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Net;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    // nikitka.repin.2017@mail.ru
    // https://www.google.ru/
    // https://www.sports.ru/
    public partial class MainWindow : Window
    {
        IWebDriver driver; // Определяет интерфейс, через который пользователь управляет браузером

        public MainWindow()
        {
            InitializeComponent();

            Uri url = new Uri("https://www.google.ru/");
            WB1.Navigate(url);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WB1.GoBack();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WB1.GoForward();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //WebClient wc = new WebClient();
            //string url = "https://www.sports.ru/";
            //string path = "C:\\Users\\User\\Desktop\\file.txt";
            //wc.DownloadFile(url, path);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Uri url = new Uri("https://www.google.ru/");
            WB1.Navigate(url);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.sports.ru/");
            //driver.Manage().Window.Maximize();

            IWebElement elem = driver.FindElement(By.XPath("/html/body/nav/div[2]/div/div/div/div/a"));           
            elem.Click();

            elem = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[1]/div/div[2]/div[2]/div/div[1]/div/form/div[2]/label/input"));
            elem.SendKeys(loginbox.Text);

            elem = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[1]/div/div[2]/div[2]/div/div[1]/div/form/div[3]/label/input"));
            elem.SendKeys(Passbox.Password);

            elem = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[1]/div/div[2]/div[2]/div/div[1]/div/form/div[5]/button"));
            elem.Click();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Uri url1 = new Uri(URLText.Text);
            WB1.Navigate(url1);
        }

        private void URLText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
