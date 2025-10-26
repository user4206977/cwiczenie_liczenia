using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace matematyka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Num1_A, Num2_A, sys;
        int ilosc_wynikow = 0;
        int ilosc_poprawnych = 0;
        int ilosc_niepoprawnych = 0;
        char sing = '+';

        public MainWindow()
        {
            InitializeComponent();
            One.IsChecked = true;
            Add.IsChecked = true;
            los.IsEnabled = false;

            int MIN = 1, MAX = 10;

            Random rnd = new Random();
            int Num1, Num2;
            Num1 = rnd.Next(MIN, MAX + 1);
            Num2 = rnd.Next(MIN, MAX + 1);

            if (sys == 3)
            {
                do
                {
                    Num1 = rnd.Next(MIN, MAX + 1);
                    Num2 = rnd.Next(MIN, MAX + 1);
                } while (Num1 % Num2 != 0);

                Num1_A = Num1;
                Num2_A = Num2;
                FirstNum.Content = Num1;
                SecondNum.Content = Num2;
                AnswerBox.Text = "?";
                Result.Content = "PODAJ POPRAWNY WYNIK!";
                Result.Foreground = Brushes.Black;
            }
            else
            {
                Num1_A = Num1;
                Num2_A = Num2;
                FirstNum.Content = Num1;
                SecondNum.Content = Num2;
                AnswerBox.Text = "?";
                Result.Content = "PODAJ POPRAWNY WYNIK!";
                Result.Foreground = Brushes.Black;
            }
            il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
            il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
            il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;
        }

        private void SelectNum(object sender, RoutedEventArgs e)
        {
            los.IsEnabled = false;
            spr.IsEnabled = true;
            int MIN = 1, MAX = 10;
            if (One.IsChecked == true)
            {
                MIN = 1;
                MAX = 10;
            }
            else if (Two.IsChecked == true)
            {
                MIN = 1;
                MAX = 20;
            }
            else if (Three.IsChecked == true)
            {
                MIN = 1;
                MAX = 30;
            }
            else
            {
                MIN = 1;
                MAX = 40;
            }

            Random rnd = new Random();
            int Num1, Num2;
            Num1 = rnd.Next(MIN, MAX + 1);
            Num2 = rnd.Next(MIN, MAX + 1);

            if (sys == 3)
            {
                do
                {
                    Num1 = rnd.Next(MIN, MAX + 1);
                    Num2 = rnd.Next(MIN, MAX + 1);
                } while (Num1 % Num2 != 0);

                Num1_A = Num1;
                Num2_A = Num2;
                FirstNum.Content = Num1;
                SecondNum.Content = Num2;
                AnswerBox.Text = "?";
                Result.Content = "PODAJ POPRAWNY WYNIK!";
                Result.Foreground = Brushes.Black;
            }
            else
            {
                Num1_A = Num1;
                Num2_A = Num2;
                FirstNum.Content = Num1;
                SecondNum.Content = Num2;
                AnswerBox.Text = "?";
                Result.Content = "PODAJ POPRAWNY WYNIK!";
                Result.Foreground = Brushes.Black;
            }
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            los.IsEnabled = true;
            spr.IsEnabled = false;
            if (AnswerBox.Text == "" || AnswerBox.Text == "?")
            {
                MessageBox.Show("Podaj wynik przed sprawdzeniem!", "Ostrzerzenie", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else if (AnswerBox.Text != "" && AnswerBox.Text.All(char.IsDigit))
            {
                int Ans = Int32.Parse(AnswerBox.Text);
                if (sys == 1)
                {
                    if (Ans == Num1_A + Num2_A)
                    {
                        Result.Content = "TAK! TO POPRAWNY WYNIK";
                        Result.Foreground = Brushes.Green;
                        ilosc_wynikow++;
                        ilosc_poprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;

                    }
                    else
                    {
                        Result.Content = "NIESTETY! ZŁA ODPOWIEDŹ!";
                        Result.Foreground = Brushes.Red;
                        ilosc_wynikow++;
                        ilosc_niepoprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;
                    }
                }
                else if (sys == 2)
                {
                    if (Ans == Num1_A - Num2_A)
                    {
                        Result.Content = "TAK! TO POPRAWNY WYNIK";
                        Result.Foreground = Brushes.Green;
                        ilosc_wynikow++;
                        ilosc_poprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;

                    }
                    else
                    {
                        Result.Content = "NIESTETY! ZŁA ODPOWIEDŹ!";
                        Result.Foreground = Brushes.Red;
                        ilosc_wynikow++;
                        ilosc_niepoprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;
                    }
                }
                else if (sys == 3)
                {
                    if (Ans == Num1_A / Num2_A)
                    {
                        Result.Content = "TAK! TO POPRAWNY WYNIK";
                        Result.Foreground = Brushes.Green;
                        ilosc_wynikow++;
                        ilosc_poprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;

                    }
                    else
                    {
                        Result.Content = "NIESTETY! ZŁA ODPOWIEDŹ!";
                        Result.Foreground = Brushes.Red;
                        ilosc_wynikow++;
                        ilosc_niepoprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;
                    }
                }
                else
                {
                    if (Ans == Num1_A * Num2_A)
                    {
                        Result.Content = "TAK! TO POPRAWNY WYNIK";
                        Result.Foreground = Brushes.Green;
                        ilosc_wynikow++;
                        ilosc_poprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;

                    }
                    else
                    {
                        Result.Content = "NIESTETY! ZŁA ODPOWIEDŹ!";
                        Result.Foreground = Brushes.Red;
                        ilosc_wynikow++;
                        ilosc_niepoprawnych++;
                        il_zad.Content = "Ilość zadań: " + ilosc_wynikow;
                        il_pop.Content = "Odpowiedzi Poprawnych: " + ilosc_poprawnych;
                        il_nie.Content = "Odpowiedzi Niepoprawnych: " + ilosc_niepoprawnych;
                    }
                }
            }
            else
            {
                MessageBox.Show("Wynik musi składać się tylko z liczb całkowitych!", "Ostrzerzenie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void AnswerBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            AnswerBox.Text = "";
        }

        private void Add_Checked(object sender, RoutedEventArgs e)
        {
            sing = '+';
            znak.Content = sing;
            sys = 1;
            Banner.Content = "DODAJEMY LICZBY";
            SelectNum(null, new RoutedEventArgs());
        }

        private void Sub_Checked(object sender, RoutedEventArgs e)
        {
            sing = '-';
            znak.Content = sing;
            sys = 2;
            Banner.Content = "ODEJMUJEMY LICZBY";
            SelectNum(null, new RoutedEventArgs());
        }

        private void Div_Checked(object sender, RoutedEventArgs e)
        {
            sing = '/';
            znak.Content = sing;
            sys = 3;
            Banner.Content = "DZIELIMY LICZBY";
            SelectNum(null, new RoutedEventArgs());
        }

        private void Mul_Checked(object sender, RoutedEventArgs e)
        {
            sing = '*';
            znak.Content = sing;
            sys = 4;
            Banner.Content = "MNOŻYMY LICZBY";
            SelectNum(null, new RoutedEventArgs());
        }
    }
}
