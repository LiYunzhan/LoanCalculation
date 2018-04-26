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

namespace LoanCalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double temp;
            if (!double.TryParse(textBox.Text, out temp))
            {
                System.Windows.MessageBox.Show("只能输入数字", "提示");
            }
        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            double temp;
            if (!double.TryParse(textBox.Text, out temp))
            {
                System.Windows.MessageBox.Show("只能输入数字", "提示");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox_Copy.Text = "";
            datePickerCtl.Text = "";
            datePickerCtl_Copy.Text = "";
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var startDate = DateTime.Parse(datePickerCtl.Text);
            var endDate = DateTime.Parse(datePickerCtl_Copy.Text);
            var total = decimal.Parse(textBox.Text);
            var multiple = decimal.Parse(datePickerCtl_Copy.Text);
            var exchangeRate = listBox.SelectedValue;
        }

        public class Loan
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public decimal Min6MonthRate { get; set; }
            public decimal Min6MonthMax1YearRate { get; set; }
            public decimal Min1YearMax3YearRate { get; set; }
            public decimal Min3YearMax5YearRate { get; set; }
            public decimal Max5YearRate { get; set; }
        }

        public List<Loan> config = new List<Loan>
        {
            new Loan() { StartDate = new DateTime(2015,10,24),EndDate = new DateTime(2018,04,24), Min6MonthRate = 4.35M     ,Min6MonthMax1YearRate=4.35M    ,Min1YearMax3YearRate=4.75M     ,Min3YearMax5YearRate=4.75M        ,Max5YearRate=4.90M     },
            new Loan() { StartDate = new DateTime(2015,08,26),EndDate = new DateTime(2015,10,23), Min6MonthRate = 4.60M     ,Min6MonthMax1YearRate=4.60M    ,Min1YearMax3YearRate=5.00M     ,Min3YearMax5YearRate=5.00M        ,Max5YearRate=5.15M     },
            new Loan() { StartDate = new DateTime(2015,06,28),EndDate = new DateTime(2015,08,25), Min6MonthRate = 4.85M     ,Min6MonthMax1YearRate=4.85M    ,Min1YearMax3YearRate=5.25M     ,Min3YearMax5YearRate=5.25M        ,Max5YearRate=5.40M     },
            new Loan() { StartDate = new DateTime(2015,05,11),EndDate = new DateTime(2015,06,27), Min6MonthRate = 5.10M     ,Min6MonthMax1YearRate=5.10M    ,Min1YearMax3YearRate=5.50M     ,Min3YearMax5YearRate=5.50M        ,Max5YearRate=5.65M     },
            new Loan() { StartDate = new DateTime(2015,03,01),EndDate = new DateTime(2015,05,10), Min6MonthRate = 5.35M     ,Min6MonthMax1YearRate=5.35M    ,Min1YearMax3YearRate=5.75M     ,Min3YearMax5YearRate=5.75M        ,Max5YearRate=5.90M     },
            new Loan() { StartDate = new DateTime(2014,11,22),EndDate = new DateTime(2015,02,28), Min6MonthRate = 5.60M     ,Min6MonthMax1YearRate=5.60M    ,Min1YearMax3YearRate=6.00M     ,Min3YearMax5YearRate=6.00M        ,Max5YearRate=6.15M     },
            new Loan() { StartDate = new DateTime(2012,07,06),EndDate = new DateTime(2014,11,21), Min6MonthRate = 5.60M     ,Min6MonthMax1YearRate=6.00M    ,Min1YearMax3YearRate=6.15M     ,Min3YearMax5YearRate=6.40M        ,Max5YearRate=6.55M     },
            new Loan() { StartDate = new DateTime(2012,06,08),EndDate = new DateTime(2012,07,05), Min6MonthRate = 5.85M     ,Min6MonthMax1YearRate=6.31M    ,Min1YearMax3YearRate=6.40M     ,Min3YearMax5YearRate=6.65M        ,Max5YearRate=6.80M     },
            new Loan() { StartDate = new DateTime(2011,07,07),EndDate = new DateTime(2012,06,07), Min6MonthRate = 6.10M     ,Min6MonthMax1YearRate=6.56M    ,Min1YearMax3YearRate=6.65M     ,Min3YearMax5YearRate=6.90M        ,Max5YearRate=7.05M     },
            new Loan() { StartDate = new DateTime(2011,04,06),EndDate = new DateTime(2011,07,06), Min6MonthRate = 5.85M     ,Min6MonthMax1YearRate=6.31M    ,Min1YearMax3YearRate=6.40M     ,Min3YearMax5YearRate=6.65M        ,Max5YearRate=6.80M     },
            new Loan() { StartDate = new DateTime(2011,02,09),EndDate = new DateTime(2011,04,05), Min6MonthRate = 5.60M     ,Min6MonthMax1YearRate=6.06M    ,Min1YearMax3YearRate=6.10M     ,Min3YearMax5YearRate=6.45M        ,Max5YearRate=6.60M     },
            new Loan() { StartDate = new DateTime(2010,12,26),EndDate = new DateTime(2011,02,08), Min6MonthRate = 5.35M     ,Min6MonthMax1YearRate=5.81M    ,Min1YearMax3YearRate=5.85M     ,Min3YearMax5YearRate=6.22M        ,Max5YearRate=6.40M     },
            new Loan() { StartDate = new DateTime(2010,10,20),EndDate = new DateTime(2010,12,25), Min6MonthRate = 5.10M     ,Min6MonthMax1YearRate=5.56M    ,Min1YearMax3YearRate=5.60M     ,Min3YearMax5YearRate=5.96M        ,Max5YearRate=6.14M     },
            new Loan() { StartDate = new DateTime(2008,12,23),EndDate = new DateTime(2010,10,19), Min6MonthRate = 4.86M     ,Min6MonthMax1YearRate=5.31M    ,Min1YearMax3YearRate=5.40M     ,Min3YearMax5YearRate=5.76M        ,Max5YearRate=5.94M     },
            new Loan() { StartDate = new DateTime(2008,11,27),EndDate = new DateTime(2008,12,22), Min6MonthRate = 5.04M     ,Min6MonthMax1YearRate=5.58M    ,Min1YearMax3YearRate=5.67M     ,Min3YearMax5YearRate=5.94M        ,Max5YearRate=6.12M     },
            new Loan() { StartDate = new DateTime(2008,10,30),EndDate = new DateTime(2008,11,28), Min6MonthRate = 6.03M     ,Min6MonthMax1YearRate=6.66M    ,Min1YearMax3YearRate=6.75M     ,Min3YearMax5YearRate=7.02M        ,Max5YearRate=7.20M     },
            new Loan() { StartDate = new DateTime(2008,10,27),EndDate = new DateTime(2008,10,29), Min6MonthRate = 6.12M     ,Min6MonthMax1YearRate=6.93M    ,Min1YearMax3YearRate=7.02M     ,Min3YearMax5YearRate=7.29M        ,Max5YearRate=7.47M     },
            new Loan() { StartDate = new DateTime(2008,10,09),EndDate = new DateTime(2008,10,26), Min6MonthRate = 6.12M     ,Min6MonthMax1YearRate=6.93M    ,Min1YearMax3YearRate=7.02M     ,Min3YearMax5YearRate=7.29M        ,Max5YearRate=7.47M     },
            new Loan() { StartDate = new DateTime(2008,09,16),EndDate = new DateTime(2008,10,08), Min6MonthRate = 6.21M     ,Min6MonthMax1YearRate=7.20M    ,Min1YearMax3YearRate=7.29M     ,Min3YearMax5YearRate=7.56M        ,Max5YearRate=7.74M     },
            new Loan() { StartDate = new DateTime(2007,12,21),EndDate = new DateTime(2008,09,15), Min6MonthRate = 6.57M     ,Min6MonthMax1YearRate=7.47M    ,Min1YearMax3YearRate=7.56M     ,Min3YearMax5YearRate=7.74M        ,Max5YearRate=7.83M     },
            new Loan() { StartDate = new DateTime(2007,09,15),EndDate = new DateTime(2007,12,20), Min6MonthRate = 6.48M     ,Min6MonthMax1YearRate=7.29M    ,Min1YearMax3YearRate=7.47M     ,Min3YearMax5YearRate=7.65M        ,Max5YearRate=7.83M     },
            new Loan() { StartDate = new DateTime(2007,08,22),EndDate = new DateTime(2007,09,14), Min6MonthRate = 6.21M     ,Min6MonthMax1YearRate=7.02M    ,Min1YearMax3YearRate=7.20M     ,Min3YearMax5YearRate=7.38M        ,Max5YearRate=7.56M     },
            new Loan() { StartDate = new DateTime(2007,07,21),EndDate = new DateTime(2007,08,21), Min6MonthRate = 6.03M     ,Min6MonthMax1YearRate=6.84M    ,Min1YearMax3YearRate=7.02M     ,Min3YearMax5YearRate=7.20M        ,Max5YearRate=7.38M     },
            new Loan() { StartDate = new DateTime(2007,05,19),EndDate = new DateTime(2007,07,20), Min6MonthRate = 5.85M     ,Min6MonthMax1YearRate=6.57M    ,Min1YearMax3YearRate=6.75M     ,Min3YearMax5YearRate=6.93M        ,Max5YearRate=7.20M     },
            new Loan() { StartDate = new DateTime(2007,03,18),EndDate = new DateTime(2007,05,18), Min6MonthRate = 5.67M     ,Min6MonthMax1YearRate=6.39M    ,Min1YearMax3YearRate=6.57M     ,Min3YearMax5YearRate=6.75M        ,Max5YearRate=7.11M     },
            new Loan() { StartDate = new DateTime(2006,08,19),EndDate = new DateTime(2007,03,17), Min6MonthRate = 5.58M     ,Min6MonthMax1YearRate=6.12M    ,Min1YearMax3YearRate=6.30M     ,Min3YearMax5YearRate=6.48M        ,Max5YearRate=6.84M     },
            new Loan() { StartDate = new DateTime(2006,04,28),EndDate = new DateTime(2006,08,18), Min6MonthRate = 5.40M     ,Min6MonthMax1YearRate=5.85M    ,Min1YearMax3YearRate=6.03M     ,Min3YearMax5YearRate=6.12M        ,Max5YearRate=6.39M     },
            new Loan() { StartDate = new DateTime(2005,03,17),EndDate = new DateTime(2006,04,27), Min6MonthRate = 5.22M     ,Min6MonthMax1YearRate=5.58M    ,Min1YearMax3YearRate=5.76M     ,Min3YearMax5YearRate=5.85M        ,Max5YearRate=6.12M     },
            new Loan() { StartDate = new DateTime(2004,10,29),EndDate = new DateTime(2005,03,16), Min6MonthRate = 5.22M     ,Min6MonthMax1YearRate=5.58M    ,Min1YearMax3YearRate=5.76M     ,Min3YearMax5YearRate=5.85M        ,Max5YearRate=6.12M     },
            new Loan() { StartDate = new DateTime(2002,02,21),EndDate = new DateTime(2004,10,28), Min6MonthRate = 5.04M     ,Min6MonthMax1YearRate=5.31M    ,Min1YearMax3YearRate=5.49M     ,Min3YearMax5YearRate=5.58M        ,Max5YearRate=5.76M     },
            new Loan() { StartDate = new DateTime(1999,06,10),EndDate = new DateTime(2002,02,20), Min6MonthRate = 5.58M     ,Min6MonthMax1YearRate=5.85M    ,Min1YearMax3YearRate=5.94M     ,Min3YearMax5YearRate=6.03M        ,Max5YearRate=6.21M     },
            new Loan() { StartDate = new DateTime(1998,12,07),EndDate = new DateTime(1999,06,09), Min6MonthRate = 6.12M     ,Min6MonthMax1YearRate=6.39M    ,Min1YearMax3YearRate=6.66M     ,Min3YearMax5YearRate=7.20M        ,Max5YearRate=7.56M     },
            new Loan() { StartDate = new DateTime(1998,07,01),EndDate = new DateTime(1998,12,06), Min6MonthRate = 6.57M     ,Min6MonthMax1YearRate=6.93M    ,Min1YearMax3YearRate=7.11M     ,Min3YearMax5YearRate=7.65M        ,Max5YearRate=8.01M     },
            new Loan() { StartDate = new DateTime(1998,03,25),EndDate = new DateTime(1998,06,30), Min6MonthRate = 7.02M     ,Min6MonthMax1YearRate=7.92M    ,Min1YearMax3YearRate=9.00M     ,Min3YearMax5YearRate=9.72M        ,Max5YearRate=10.35M    },
            new Loan() { StartDate = new DateTime(1997,10,23),EndDate = new DateTime(1998,03,24), Min6MonthRate = 7.65M     ,Min6MonthMax1YearRate=8.64M    ,Min1YearMax3YearRate=9.36M     ,Min3YearMax5YearRate=9.90M        ,Max5YearRate=10.53M    },
            new Loan() { StartDate = new DateTime(1996,08,23),EndDate = new DateTime(1997,10,22), Min6MonthRate = 9.18M     ,Min6MonthMax1YearRate=10.08M   ,Min1YearMax3YearRate=10.98M    ,Min3YearMax5YearRate=11.70M       ,Max5YearRate=12.42M    },
            new Loan() { StartDate = new DateTime(1996,05,01),EndDate = new DateTime(1996,08,22), Min6MonthRate = 9.72M     ,Min6MonthMax1YearRate=10.98M   ,Min1YearMax3YearRate=13.14M    ,Min3YearMax5YearRate=14.94M       ,Max5YearRate=15.12M    },
            new Loan() { StartDate = new DateTime(1995,07,01),EndDate = new DateTime(1996,04,30), Min6MonthRate = 10.08M    ,Min6MonthMax1YearRate=12.06M   ,Min1YearMax3YearRate=13.50M    ,Min3YearMax5YearRate=15.12M       ,Max5YearRate=15.30M    },
            new Loan() { StartDate = new DateTime(1995,01,01),EndDate = new DateTime(1995,06,30), Min6MonthRate = 9.00M     ,Min6MonthMax1YearRate=10.98M   ,Min1YearMax3YearRate=12.96M    ,Min3YearMax5YearRate=14.58M       ,Max5YearRate=14.76M    },
            new Loan() { StartDate = new DateTime(1993,07,11),EndDate = new DateTime(1994,12,31), Min6MonthRate = 9.00M     ,Min6MonthMax1YearRate=10.98M   ,Min1YearMax3YearRate=12.24M    ,Min3YearMax5YearRate=13.86M       ,Max5YearRate=14.04M    },
            new Loan() { StartDate = new DateTime(1993,05,15),EndDate = new DateTime(1993,07,10), Min6MonthRate = 8.82M     ,Min6MonthMax1YearRate=9.36M    ,Min1YearMax3YearRate=10.80M    ,Min3YearMax5YearRate=12.06M       ,Max5YearRate=12.24M    },
            new Loan() { StartDate = new DateTime(1991,04,21),EndDate = new DateTime(1993,05,14), Min6MonthRate = 8.10M     ,Min6MonthMax1YearRate=8.64M    ,Min1YearMax3YearRate=9.00M     ,Min3YearMax5YearRate=9.54M       ,Max5YearRate=9.72M    },
            new Loan() { StartDate = new DateTime(1991,03,21),EndDate = new DateTime(1991,04,20), Min6MonthRate = 9.00M     ,Min6MonthMax1YearRate=10.08M   ,Min1YearMax3YearRate=10.80M    ,Min3YearMax5YearRate=11.52M       ,Max5YearRate=11.88M    },
            new Loan() { StartDate = new DateTime(1990,08,21),EndDate = new DateTime(1991,03,20), Min6MonthRate = 8.64M     ,Min6MonthMax1YearRate=9.36M    ,Min1YearMax3YearRate=10.08M    ,Min3YearMax5YearRate=10.80M       ,Max5YearRate=11.16M    },
            new Loan() { StartDate = new DateTime(1989,02,01),EndDate = new DateTime(1990,08,20), Min6MonthRate = 11.34M    ,Min6MonthMax1YearRate=11.34M   ,Min1YearMax3YearRate=12.78M    ,Min3YearMax5YearRate=14.40M       ,Max5YearRate=19.26M    },
        };
    }
}
