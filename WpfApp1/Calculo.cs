using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    class Calculo:INotifyPropertyChanged
    {
        private string poseny1;
        private string poseny2;
        private string posenx1;
        private string posenx2;
        private string area;
        private string perimetro;

        public Calculo()
        {
            poseny1 = "0";
            poseny2 = "0";
            posenx1 = "0";
            posenx2 = "0";
            area = "2";
            perimetro = "0";
        }

        public string Poseny1
        {
            get
            {
                return poseny1;
            }
            set
            {
                poseny1 = value;
                OnPropertyChanged("Poseny1");
                OnPropertyChanged("Area");
                OnPropertyChanged("Perimetro");
            }
        }

        public string Poseny2
        {
            get
            {
                return poseny2;
            }
            set
            {
                poseny2 = value;
                OnPropertyChanged("Poseny2");
                OnPropertyChanged("Area");
                OnPropertyChanged("Perimetro");
            }
        }

        public string Posenx1
        {
            get
            {
                return posenx1;
            }
            set
            {
                posenx1 = value;
                OnPropertyChanged("Posenx1");
                OnPropertyChanged("Area");
                OnPropertyChanged("Perimetro");
            }
        }

        public string Posenx2
        {
            get
            {
                return posenx2;
            }
            set
            {
                posenx2 = value;
                OnPropertyChanged("Posenx2");
                OnPropertyChanged("Area");
                OnPropertyChanged("Perimetro");
            }
        }

        public string Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
                OnPropertyChanged("Area");
            }
        }

        public string Perimetro
        {
            get
            {
                return perimetro;
            }
            set
            {
                perimetro = value;
                OnPropertyChanged("Perimetro");
            }
        }

        public string Calcular_Rectangulo()
        {

            double altura, bas;

            altura = int.Parse(Poseny1) + int.Parse(Poseny2);
            bas = int.Parse(Posenx1) + int.Parse(Posenx2);

            if(altura!=bas)
            {
                double part1, part2, par11, par22, num,d;
                part1 = int.Parse(Poseny2) - int.Parse(Poseny1);
                part2 = int.Parse(Posenx2) - int.Parse(Posenx1);
                par11 = Math.Pow(part1, 2);
                par22 = Math.Pow(part2, 2);
                num = par22 + par11;
                d = Math.Sqrt(num);
                return d.ToString();



            }
            else if (altura==bas)
            {
                
            }


        }
        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }
}
