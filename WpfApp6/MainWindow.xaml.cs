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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Person
        {
            public string Name { get; }
            public Person(string name) => Name = name;

        }
        List<Person> people = new List<Person>()
        {
            new Person("Никита"),
            new Person("Кирилл"),
            new Person("Динар"),
            new Person("Субудай"),
            new Person("Булат")
        };
        class Buff
        {
            public string Name { get; }
            public Buff(string name) => Name = name;

        }
        List<Buff> buff = new List<Buff>()
        {
            new Buff("Одно красное"),
            new Buff("Запрет перка"),
            new Buff("Выбор мана"),
            new Buff("Дефолт перки + 1 рандомный"),
            new Buff("Рандомный набор перков")
        };

        public MainWindow()
        {
            InitializeComponent();

            LvYchast.ItemsSource = people.ToList();
            LvYchasts.ItemsSource = buff.ToList();
        }

        private void BtGen_Click(object sender, RoutedEventArgs e)
        {
            
            List<Person> people2 = people;
            List<Person> peopleMarder = new List<Person>();
            Random Rnd = new Random();
            while (people2.Count > 0)
            {
                int value = Rnd.Next(0, people2.Count);
                peopleMarder.Add(people2[value]);
                people2.Remove(people2[value]); 
            }
            LvMarder.ItemsSource = peopleMarder.ToList();
            MessageBox.Show("Сегенерировано");
            BtGen.Visibility = Visibility.Collapsed;
        }

        private void BtGens_Click(object sender, RoutedEventArgs e)
        {
        
            Random Rnd = new Random();
            int value = Rnd.Next(0, buff.Count);
            Buff buf = new Buff(Name);
            buf = buff[value];
            TbBuff.Text = buf.Name;
            MessageBox.Show("Сегенерировано") ;
        }
    }
}
