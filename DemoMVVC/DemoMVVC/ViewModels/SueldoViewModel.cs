using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVC.ViewModels
{
    public class SueldoViewModel : INotifyPropertyChanged
    {
        private int sueldo;
        public int Sueldo
        {
            get { return sueldo; }
            set
            {
                if (sueldo != value)
                {
                    sueldo = value;
                    OnPropertyChanged();
                }
            }
        }

        private int gratificacion;
        public int Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged();
                }
            }
        }

        private int descuento;
        public int Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged();
                }
            }
        }

        private int sueldoNeto;
        public int SueldoNeto
        {
            get { return sueldoNeto; }
            set
            {
                if (sueldoNeto != value)
                {
                    sueldoNeto = value;
                    OnPropertyChanged();
                }
            }
        }

        private int sueldoNetoFinal;
        public int SueldoNetoFinal
        {
            get { return sueldoNetoFinal; }
            set
            {
                if (sueldoNetoFinal != value)
                {
                    sueldoNetoFinal = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularSueldoNeto { protected set; get; }
        public ICommand CalcularSueldoNetoFinal { protected set; get; }
        public ICommand CalcularImpuesto { protected set; get; }

        public SueldoViewModel()
        {
            CalcularSueldoNeto = new Command(() =>
            {
                SueldoNeto = Sueldo + Gratificacion;
            });

            CalcularSueldoNetoFinal = new Command(() =>
            {
                SueldoNetoFinal = SueldoNeto - Descuento;
            });

            CalcularImpuesto = new Command(() =>
            {
                SueldoNetoFinal = (int)(SueldoNeto * 0.08); 
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
